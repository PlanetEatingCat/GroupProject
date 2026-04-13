/********************************************
Name: BudgetCategory.cs
Purpose: For separating budgets in home screen
Notes: Authored by Daniel
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
    public partial class BudgetCategory : UserControl
    {
        public BudgetCategory()
        {
            InitializeComponent();
        }

        public void SetLabel(string InLabel)
        {
            CategoryLabel.Text = InLabel;
        }

        public void UpdateTheme(Theme InTheme)
        {
            CategoryLabel.BackColor = InTheme.Box;
            CategoryLabel.ForeColor = Color.White;

            this.BackColor = InTheme.Box;
        }
    }
}
