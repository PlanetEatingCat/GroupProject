/********************************************
Name: CalendarScreen.cs
Purpose: Calendar display of expenses
Notes: WIP.
********************************************/

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
    public partial class CalendarScreen : UserControl
    {
        public CalendarScreen(MainForm InMainForm, ThemeManager InThemeManager,
            AccountTitle InAccountTitle, ScreenTitle InScreenTitle)
        {
            InitializeComponent();

            var rightMenuBar = InAccountTitle;
            var leftMenuBar = InScreenTitle;

            var mainForm = InMainForm;
            mainForm.SetRightMenuBar(rightMenuBar);
            mainForm.SetLeftMenuBar(leftMenuBar);

            leftMenuBar.SetIcon(MenuIcons.Calendar);
            leftMenuBar.SetText("Calendar");
        }
    }
}
