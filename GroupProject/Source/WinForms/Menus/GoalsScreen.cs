/********************************************
Name: GoalsScreen.cs
Purpose: The goals
Notes: WIP by Kiefer.
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
    public partial class GoalsScreen : UserControl
    {
        public GoalsScreen(MainForm InMainForm, AccountTitle InAccountTitle, ScreenTitle InScreenTitle)
        {
            InitializeComponent();

            InMainForm.SetRightMenuBar(InAccountTitle);
            InMainForm.SetLeftMenuBar(InScreenTitle);

            InScreenTitle.SetIcon(MenuIcons.Goals);
            InScreenTitle.SetText("Goals");
        }
    }
}
