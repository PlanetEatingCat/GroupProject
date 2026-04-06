/********************************************
Name: GoalsScreen.cs
Purpose: Add, remove, and edit income
Notes: WIP by Ella.
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
    public partial class IncomeScreen : UserControl
    {
        public IncomeScreen(MainForm InMainForm, AccountTitle InAccountTitle, ScreenTitle InScreenTitle)
        {
            InitializeComponent();

            InMainForm.SetRightMenuBar(InAccountTitle);
            InMainForm.SetLeftMenuBar(InScreenTitle);

            InScreenTitle.SetIcon(MenuIcons.Income);
            InScreenTitle.SetText("Income");
        }
    }
}
