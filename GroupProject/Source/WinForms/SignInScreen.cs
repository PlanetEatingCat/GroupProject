using BudgetPlanner;
using LiveChartsCore.Themes;
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
            //ThemeManager.ApplyTheme(this);


            SignInPanel.Location = new Point(Size.Width / 2, Size.Height / 2);
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            User user = new User(UsernameInput.Text, PasswordInput.Text, 90);

            Profile profile = new Profile(user, 0);
            Session.SetActive(profile);


            UsernameInput.Text = PasswordInput.Text = "";

            Logger.Info($"Sign in as '{user.GetUsername()}' successful!");

            ScreenManager.SwitchScreens(new MainScreen());
        }

        private void TableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
