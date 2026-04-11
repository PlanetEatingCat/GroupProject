/********************************************
Name: GoalsScreen.cs
Purpose: Add, remove, and edit income
Notes: WIP by Ella, Income does not loop with frequency yet and currently only occurs once.
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
using Windows.Management;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BudgetPlanner
{
    public partial class IncomeScreen : UserControl
    {
        private SessionManager m_SessionManager;

        public IncomeScreen(MainForm InMainForm, AccountTitle InAccountTitle, ScreenTitle InScreenTitle, SessionManager sessionManager)
        {
            InitializeComponent();
            m_SessionManager = sessionManager;

            InMainForm.SetRightMenuBar(InAccountTitle);
            InMainForm.SetLeftMenuBar(InScreenTitle);

            InScreenTitle.SetIcon(MenuIcons.Income);
            InScreenTitle.SetText("Income");
            CurrentIncomeLbl.Visible = false;

        }

        private void IncomeScreen_Load(object sender, EventArgs e)
        {

        }
        public decimal amount;
        public string name;
        IncomeFrequency frequency;



        bool nameflag = false;
        bool frequencyflag = false;
        bool amountflag = false;

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

            if (NameTxtBx.Text == "")
            {
                MessageBox.Show("Name cannot be empty."); // ensure textbox not empty
                nameflag = false;
            }
            else
            {
                name = NameTxtBx.Text;
                nameflag = true;

            }
            if (AmountTxtBx.Text != "")
            {
                if (decimal.TryParse(AmountTxtBx.Text, out decimal number)) //ensures the text box contains a valid number converts to int
                {
                    amount = number;
                    amountflag = true;

                }
                else
                {
                    MessageBox.Show("Amount must be a number");
                    amountflag = false;
                }
            }
            else
            {
                MessageBox.Show("Amount cannot be empty.");
                amountflag = false;
            }


            if (FrequencyComboBx.Text == "Daily" || FrequencyComboBx.Text == "Monthly" || FrequencyComboBx.Text == "EveryTwoMonths" || FrequencyComboBx.Text == "Yearly")
            {
                if (Enum.TryParse<IncomeFrequency>(FrequencyComboBx.Text, true, out IncomeFrequency result))
                {
                    frequency = result;
                    frequencyflag = true;

                }
            }
            else
            {
                MessageBox.Show("Please Select a Valid Frequency");
                frequencyflag = false;
            }

            if (nameflag == true && frequencyflag == true && amountflag == true)
            {
                IncomeSource income = new
                IncomeSource(amount, frequency, name, m_SessionManager);
                CurrentIncomeLbl.Visible = true;
                if (FrequencyComboBx.Text != "EveryTwoMonths")
                {
                    CurrentIncomeLbl.Text = $"Current Income for {name} is set to ${amount} {frequency}";
                }
                else
                {
                    CurrentIncomeLbl.Text = $"Current Income for {name} is set to ${amount} Every Two Months";
                }
            }
        }



        private void IncomeLblSmall_Click(object sender, EventArgs e)
        {

        }
    }
}
