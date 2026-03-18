
using GroupProject.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BudgetPlanner
{
    public partial class BudgetPlannerForm : Form
    {
        private const int MESSAGE_VANISH_TIME = 5000; // 5 seconds

        // For error and success message system
        private System.Windows.Forms.Timer m_MessageTimer = new System.Windows.Forms.Timer();

        DebugConsoleForm m_DebugConsoleForm;
        SignInScreen m_SignInScreen;

        public BudgetPlannerForm()
        {
            InitializeComponent();
            Logger.OnLogToGUI += Logger_OnLog;
            ScreenManager.Initialize(MainPanel);
        }



        // CAN BE USED TO DISPLAY ERRORS IN THE GUI 
        private void ShowErrorMessage(string InMessage)
        {

        }

        // CAN BE USED TO DISPLAY MESSAGES (instead of Console.WriteLine) IN THE GUI 
        private void ShowSuccessMessage(string InMessage)
        {

        }

        private void Logger_OnLog(string msg, MessageType InType)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Logger_OnLog(msg, InType)));
                return;
            }

            switch (InType)
            {
                case MessageType.Error:
                    MessagePanel.BackColor = Color.IndianRed;
                    MessageIcon.Image = Resources.ErrorIcon;
                    break;
                case MessageType.Warn:
                    MessagePanel.BackColor = Color.Moccasin;
                    MessageIcon.Image = Resources.WarnIcon;
                    break;
                case MessageType.Info:
                    MessagePanel.BackColor = Color.PaleGreen;
                    MessageIcon.Image = Resources.SuccessIcon;
                    break;

            }

            Message.Text = msg;
            MessagePanel.Visible = true;


            m_MessageTimer.Stop();
            m_MessageTimer.Start();
        }


        private void BudgetPlannerForm_Load(object InSender, EventArgs InEvent)
        {
            // Creates error timer. Used to hide error message after five seconds
            m_MessageTimer = new System.Windows.Forms.Timer();
            m_MessageTimer.Interval = MESSAGE_VANISH_TIME; // 5 seconds
            m_MessageTimer.Tick += (s, e) =>
            {
                MessagePanel.Visible = false;
                m_MessageTimer.Stop();
            };


            // Initialize state of panels
            MessagePanel.Visible = false;

            ScreenManager.SwitchScreens(new SignInScreen());

            m_DebugConsoleForm = new DebugConsoleForm();
            m_DebugConsoleForm.Show();


            Logger.ConsoleError("This is an error test");
            Logger.ConsoleInfo("This is a Message test");
            Logger.ConsoleWarn("This is a warning test");
        }


        private void ShowDebugConsoleButton_Click(object sender, EventArgs e)
        {
            m_DebugConsoleForm.Show();
        }

        private void Message_Click(object sender, EventArgs e)
        {

        }
    }
}
