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
    public partial class TransactionView : UserControl
    {
        private decimal m_Amount = 0;
        private string m_Type = "None";

        public TransactionView()
        {
            InitializeComponent();
        }

        public void SetType(string InType)
        {
            m_Type = InType;
            TypeAndAmountLabel.Text = $"{m_Type}: ${m_Amount}";
        }

        public void SetAmount(decimal InAmount)
        {
            m_Amount = InAmount;
            TypeAndAmountLabel.Text = $"{m_Type}: ${m_Amount}";
        }

        public void SetUpcomming(bool InUpcomming)
        {
            UpcommingLabel.Visible = InUpcomming;
        }

        public void SetDeposit(bool InDeposit)
        {
            Icon.IconChar = InDeposit ? FontAwesome.Sharp.IconChar.CircleArrowUp : FontAwesome.Sharp.IconChar.ArrowCircleDown;
        }

        public void UpdateTheme(Theme InTheme)
        {
            TypeAndAmountLabel.ForeColor = Color.White;
            TypeAndAmountLabel.BackColor = InTheme.Box;

            UpcommingLabel.ForeColor = Color.White;
            UpcommingLabel.BackColor = InTheme.Box;

            Icon.IconColor = Color.White;
            Icon.BackColor = InTheme.Box;

            this.BackColor = InTheme.Box;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
