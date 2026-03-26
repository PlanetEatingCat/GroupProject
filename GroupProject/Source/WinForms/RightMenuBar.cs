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
    public partial class RightMenuBar : UserControl
    {
        public RightMenuBar()
        {
            InitializeComponent();
        }

        private void RightMenuBar_Load(object sender, EventArgs e)
        {
            AccountOptionsButton.Text = Session.ActiveProfile.GetUser().GetUsername();
        }

        private void AccountOptionsButton_Click(object sender, EventArgs e)
        {
            AccountOptionsMenu.Show(AccountOptionsButton, new Point(0, AccountOptionsButton.Height));
        }

   
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScreenManager.SwitchScreens(new SignInScreen());
        }
    }
}
