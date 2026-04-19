/********************************************
Name: GoalsScreen.cs
Purpose: Add, remove, and edit income
Notes: Authored by Ella
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
        //EP Start
    {
        private SessionManager m_SessionManager;
        private readonly EventDispatcher m_EventDispatcher;
        private readonly ThemeManager m_ThemeManager;

        public IncomeScreen(MainForm InMainForm, AccountTitle InAccountTitle, ScreenTitle InScreenTitle, 
            SessionManager sessionManager, EventDispatcher InEventDispatcher,
            ThemeManager InThemeManager)
        {
            InitializeComponent();
            m_SessionManager = sessionManager;
            m_EventDispatcher = InEventDispatcher;
            m_ThemeManager = InThemeManager;

            ApplyTheme(InThemeManager.GetCurrentTheme());
            m_EventDispatcher.Subscribe<ThemeChangedEvent>(OnThemeChanged);



            InMainForm.SetRightMenuBar(InAccountTitle);
            InMainForm.SetLeftMenuBar(InScreenTitle);

            InScreenTitle.SetIcon(MenuIcons.Income);
            InScreenTitle.SetText("Income");
            CurrentIncomeLbl.Visible = false;

        }

        private void OnThemeChanged(ThemeChangedEvent InEvent)
        {
            ApplyTheme(InEvent.NewTheme);
        }

        private void IncomeScreen_Load(object sender, EventArgs e)
        {

        }
        public decimal amount;
        public string name;
        IncomeFrequency frequency;
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }



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
                IncomeSource income 
                    = new IncomeSource(amount, frequency, name, StartDate, EndDate);

                income.ApplyInitialDeposit(m_SessionManager);
                m_SessionManager.GetActiveProfile().AddIncomeSource(income);

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

        //EP end



        private void IncomeLblSmall_Click(object sender, EventArgs e)
        {

        }

        public void ApplyTheme(Theme InTheme)
        {
            this.BackColor = InTheme.Background;

            IncomeLbl.BackColor = InTheme.Background;
            IncomeLbl.ForeColor = InTheme.Text;

            AmountTxtBx.BackColor = InTheme.Box;
            AmountTxtBx.ForeColor = InTheme.Text;

            IncomeLblSmall.BackColor = InTheme.Background;
            IncomeLblSmall.ForeColor = InTheme.Text;

            NameTxtBx.BackColor = InTheme.Box;
            NameTxtBx.ForeColor = InTheme.Text;


            NameLbl.BackColor = InTheme.Background;
            NameLbl.ForeColor = InTheme.Text;

            FrequencyLbl.BackColor = InTheme.Background;
            FrequencyLbl.ForeColor = InTheme.Text;

            ConfirmButton.BackColor = InTheme.Accent;
            ConfirmButton.ForeColor = Color.White;

            CurrentIncomeLbl.BackColor = InTheme.Background;
            CurrentIncomeLbl.ForeColor = InTheme.Text;

            FrequencyComboBx.BackColor = InTheme.Box;
            FrequencyComboBx.ForeColor = InTheme.Text;
        }
    }
}

