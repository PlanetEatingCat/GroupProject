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

namespace GroupProject.Source.WinForms.Menus
{
    public partial class ExpensesScreen : UserControl
    {
        public ExpensesScreen(MainForm InMainForm, AccountTitle InAccountTitle, ScreenTitle InScreenTitle)
        {
            InitializeComponent();

            InMainForm.SetRightMenuBar(InAccountTitle);
            InMainForm.SetLeftMenuBar(InScreenTitle);

            InScreenTitle.SetIcon(MenuIcons.Expenses);
            InScreenTitle.SetText("Expenses");
        }
    }
}
