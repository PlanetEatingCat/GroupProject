/********************************************
Name: LeftMenuBar.cs
Purpose: Menu bar in the left of the title bar
Notes: Work in Progress.
********************************************/
using FontAwesome.Sharp;
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
    public partial class ScreenTitle : UserControl
    {
        public ScreenTitle()
        {
            InitializeComponent();

            HomeMenuButton.FlatAppearance.MouseOverBackColor = HomeMenuButton.BackColor;
            HomeMenuButton.FlatAppearance.MouseDownBackColor = HomeMenuButton.BackColor;

        }

        public void SetIcon(IconChar InChar)
        {
            HomeMenuButton.IconChar = InChar;
        }

        public void SetText(string InText)
        {
            HomeMenuButton.Text = InText;
        }

        private void HomeMenuButton_Click(object sender, EventArgs e)
        {

        }
    }
}
