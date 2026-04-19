/********************************************
Name: AppContext.cs
Purpose: Decides which form to open and when to exit app
Notes: Authored by Daniel (based on Microsoft example code)
********************************************/

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Windows.Management;

namespace BudgetPlanner
{

    // The class that handles the creation of main application windows
    // Handles switching between the login form and the main form and closing the 
    // Application when either one closes
    class AppContext : ApplicationContext
    {
        //-----------------------------------------------------------------------------------------------
        // Dependencies
        //-----------------------------------------------------------------------------------------------
        private readonly MainForm m_MainForm;
        private readonly LoginForm m_LoginForm;
        private readonly EventDispatcher m_EventDispatcher;
        private readonly SessionManager m_SessionManager;

        //-----------------------------------------------------------------------------------------------
        // Variables
        //-----------------------------------------------------------------------------------------------

        private int m_FormCount;

        private Rectangle m_MainFormPosition;
        private Rectangle m_LoginFormPosition;

        private FileStream m_UserData;


        //-----------------------------------------------------------------------------------------------
        // Functionality
        //-----------------------------------------------------------------------------------------------

        public AppContext(MainForm InMainForm, LoginForm InLoginForm, SessionManager InSessionManager, EventDispatcher InEventDispatcher)
        {
            m_MainForm = InMainForm;
            m_LoginForm = InLoginForm;
            m_EventDispatcher = InEventDispatcher;
            m_SessionManager = InSessionManager;


            m_FormCount = 0;

            // Handle the ApplicationExit event to know when the application is exiting.
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            try
            {
                // Create a file that the application will store user specific data in.
                m_UserData = new FileStream(Application.UserAppDataPath + "\\appdata.txt", FileMode.OpenOrCreate);
            }
            catch (IOException e)
            {
                // Inform the user that an error occurred.
                MessageBox.Show("An error occurred while attempting to show the application." +
                                "The error is:" + e.ToString());

                // Exit the current thread instead of showing the windows.
                ExitThread();
            }

            // Create both application forms and handle the Closed event
            // to know when both forms are closed.
            m_MainForm.Closed += new EventHandler(OnFormClosed);
            m_MainForm.Closing += new CancelEventHandler(OnFormClosing);
            m_FormCount++;

            m_LoginForm.Closed += new EventHandler(OnFormClosed);
            m_LoginForm.Closing += new CancelEventHandler(OnFormClosing);
            m_FormCount++;

            // Get the form positions based upon the user specific data.
         /* if (ReadFormDataFromFile())
            {
                // If the data was read from the file, set the form
                // positions manually.
                m_MainForm.StartPosition = FormStartPosition.Manual;
                m_LoginForm.StartPosition = FormStartPosition.Manual;

                m_MainForm.Bounds = m_MainFormPosition;
                m_LoginForm.Bounds = m_LoginFormPosition;
            }*/

            // Show both forms.
            m_MainForm.Hide();
            m_LoginForm.Show();


            m_EventDispatcher.Subscribe<LogInEvent>(OnLogin);
            m_EventDispatcher.Subscribe<LogOutEvent>(OnLogOut);
        }

        private void OnLogin(LogInEvent InEvent)
        {
           // User user = new User(InEvent.Username, InEvent.Password, 90);

            Profile profile = new Profile(InEvent.Username, InEvent.Password, 0);
            m_SessionManager.Login(profile);

            m_MainForm.Show();
            m_LoginForm.Hide();
        }

        private void OnLogOut(LogOutEvent InEvent)
        {
            Save Profile = new Save(m_SessionManager);
            Profile.SaveProfile();

            m_SessionManager.Logout();

            m_MainForm.Hide();
            m_LoginForm.Show();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            // When the application is exiting, write the application data to the
            // user file and close it.
            WriteFormDataToFile();

            try
            {
                // Ignore any errors that might occur while closing the file handle.
                m_UserData.Close();
            }
            catch { }
        }

        private void OnFormClosing(object sender, CancelEventArgs e)
        {
            // When a form is closing, remember the form position so it
            // can be saved in the user data file.
            if (sender is MainForm)
                m_MainFormPosition = ((Form)sender).Bounds;
            else if (sender is LoginForm)
                m_LoginFormPosition = ((Form)sender).Bounds;
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            // When a form is closed, decrement the count of open forms.

            // When the count gets to 0, exit the app by calling
            // ExitThread().

            ExitThread();
        }

        private bool WriteFormDataToFile()
        {
            // Write the form positions to the file.
            UTF8Encoding encoding = new UTF8Encoding();

            RectangleConverter rectConv = new RectangleConverter();
            string form1pos = rectConv.ConvertToString(m_MainFormPosition);
            string form2pos = rectConv.ConvertToString(m_LoginFormPosition);

            byte[] dataToWrite = encoding.GetBytes("~" + form1pos + "~" + form2pos);

            try
            {
                // Set the write position to the start of the file and write
                m_UserData.Seek(0, SeekOrigin.Begin);
                m_UserData.Write(dataToWrite, 0, dataToWrite.Length);
                m_UserData.Flush();

                m_UserData.SetLength(dataToWrite.Length);
                return true;
            }
            catch
            {
                // An error occurred while attempting to write, return false.
                return false;
            }
        }

        private bool ReadFormDataFromFile()
        {
            // Read the form positions from the file.
            UTF8Encoding encoding = new UTF8Encoding();
            string data;

            if (m_UserData.Length != 0)
            {
                byte[] dataToRead = new byte[m_UserData.Length];

                try
                {
                    // Set the read position to the start of the file and read.
                    m_UserData.Seek(0, SeekOrigin.Begin);
                    m_UserData.Read(dataToRead, 0, dataToRead.Length);
                }
                catch (IOException e)
                {
                    string errorInfo = e.ToString();
                    // An error occurred while attempt to read, return false.
                    return false;
                }

                // Parse out the data to get the window rectangles
                data = encoding.GetString(dataToRead);

                try
                {
                    // Convert the string data to rectangles
                    RectangleConverter rectConv = new RectangleConverter();
                    string form1pos = data.Substring(1, data.IndexOf("~", 1) - 1);

                    m_MainFormPosition = (Rectangle)rectConv.ConvertFromString(form1pos);

                    string form2pos = data.Substring(data.IndexOf("~", 1) + 1);
                    m_LoginFormPosition = (Rectangle)rectConv.ConvertFromString(form2pos);

                    return true;
                }
                catch
                {
                    // Error occurred while attempting to convert the rectangle data.
                    // Return false to use default values.
                    return false;
                }
            }
            else
            {
                // No data in the file, return false to use default values.
                return false;
            }
        }
    }
}