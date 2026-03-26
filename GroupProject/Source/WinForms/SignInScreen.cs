using BudgetPlanner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetPlanner
{
    public partial class SignInScreen : UserControl
    {
        public SignInScreen()
        {
            InitializeComponent();
        }

        private void SignInScreen_Load(object sender, EventArgs e)
        {
            ScreenManager.HostForm.SetMenuBarActive(false);
            ScreenManager.UnsetRightMenuBar();
            SignInPanel.Location = new Point(Size.Width / 2, Size.Height / 2);
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            User user = new User(UsernameInput.Text, PasswordInput.Text, 90);

            Profile profile = new Profile(user, 0);
            Session.SetActive(profile);


            UsernameInput.Text = PasswordInput.Text = "";

            Logger.Info($"Sign in as '{user.GetUsername()}' successful!");

            ScreenManager.SwitchScreens(new DashboardScreen());
        }

        private void TableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignInScreen_Resize(object sender, EventArgs e)
        {
            SignInPanel.Left = (this.Width - SignInPanel.Width) / 2;
            SignInPanel.Top = (this.Height - SignInPanel.Height) / 2;
        }

        private void SignInScreen_SizeChanged(object sender, EventArgs e)
        {
            SignInPanel.Left = (this.Width - SignInPanel.Width) / 2;
            SignInPanel.Top = (this.Height - SignInPanel.Height) / 2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordInputLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
