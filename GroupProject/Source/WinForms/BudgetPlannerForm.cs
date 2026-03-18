
using System;
using System.Diagnostics;

namespace BudgetPlanner
{
    public partial class BudgetPlannerForm : Form
    {

        DebugConsoleForm m_DebugConsoleForm;
        SignInScreen m_SignInScreen;

        public BudgetPlannerForm()
        {
            InitializeComponent();
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

        private void BudgetPlannerForm_Load(object InSender, EventArgs InEvent)
        {
            ScreenManager.SwitchScreens(new SignInScreen());

            m_DebugConsoleForm = new DebugConsoleForm();
            m_DebugConsoleForm.Show();

            DebugConsole.Info("This is a Message test");
            DebugConsole.Error("This is an error test");
            DebugConsole.Warn("This is a warining test");
        }


        private void ShowDebugConsoleButton_Click(object sender, EventArgs e)
        {
            m_DebugConsoleForm.Show();
        }
    }
}
