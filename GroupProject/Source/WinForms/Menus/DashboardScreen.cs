/********************************************
Name: DashboardScreen.cs
Purpose: The darshboard to display important stats and info
Notes: Authored by Daniel
********************************************/

using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Windows.Management;
using static SkiaSharp.HarfBuzz.SKShaper;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace BudgetPlanner
{
    public partial class DashboardScreen : UserControl
    {
        //-----------------------------------------------------------------------------------------------
        // Dependencies
        //-----------------------------------------------------------------------------------------------

        private readonly MainForm m_MainForm;
        private readonly EventDispatcher m_EventDispatcher;
        private readonly SessionManager m_SessionManager;
        private readonly ThemeManager m_ThemeManager;

        //-----------------------------------------------------------------------------------------------
        // Form
        //-----------------------------------------------------------------------------------------------

        public DashboardScreen(EventDispatcher InEventDispatcher, MainForm InMainForm,
            ThemeManager InThemeManager, AccountTitle InAccountTitle, ScreenTitle InScreenTitle,
            SessionManager InSessionManager)
        {
            InitializeComponent();

            // Setup dependencies and events
            ApplyTheme(InThemeManager.GetCurrentTheme());

            m_MainForm = InMainForm;
            m_EventDispatcher = InEventDispatcher;
            m_SessionManager = InSessionManager;
            m_ThemeManager = InThemeManager;

            m_EventDispatcher.Subscribe<ThemeChangedEvent>(OnThemeChanged);

            // Set the title bar items
            var rightMenuBar = InAccountTitle;
            var leftMenuBar = InScreenTitle;
            m_MainForm.SetRightMenuBar(rightMenuBar);
            m_MainForm.SetLeftMenuBar(leftMenuBar);
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            // Disable Budget panel horizontal scrollbar
            PlanPanel.AutoScroll = false;
            PlanPanel.HorizontalScroll.Maximum = 0;
            PlanPanel.HorizontalScroll.Visible = false;
            PlanPanel.AutoScroll = true;

            // Disable transaction panel horizontal scrollbar
            TransactionPanel.AutoScroll = false;
            TransactionPanel.HorizontalScroll.Maximum = 0;
            TransactionPanel.HorizontalScroll.Visible = false;
            TransactionPanel.AutoScroll = true;

            UpdateTransactionPanel();
            UpdateBudgetPanel();
        }

        //-----------------------------------------------------------------------------------------------
        // Controls
        //-----------------------------------------------------------------------------------------------

        private void AddBudgetButton_Click(object InSender, EventArgs InEventArgs)
        {
            var addBudgetForm = new AddBudgetForm(m_SessionManager, this, m_EventDispatcher, m_ThemeManager);
            addBudgetForm.ShowDialog();
        }

        //-----------------------------------------------------------------------------------------------
        // Utils
        //-----------------------------------------------------------------------------------------------

        private void OnThemeChanged(ThemeChangedEvent InEvent)
        {
            ApplyTheme(InEvent.NewTheme);
        }

        public void UpdateTransactionPanel()
        {
            // Clear panel
            TransactionPanel.Controls.Clear();

            // Create transaction views
            foreach (var transaction in m_SessionManager.GetActiveProfile().GetTransactions())
            {
                var transactionView = new TransactionView();
                transactionView.SetAmount(transaction.GetAmount());
                transactionView.SetDeposit(transaction.GetType() == "Deposit");
                transactionView.SetType(transaction.GetExpenseType());
                transactionView.SetUpcomming(false);
                transactionView.UpdateTheme(m_ThemeManager.GetCurrentTheme());
                transactionView.Width = TransactionPanel.Width;

                TransactionPanel.Controls.Add(transactionView);
            }
        }

        public void UpdateBudgetPanel()
        {
            // Clear panel
            PlanPanel.Controls.Clear();

            Theme currentTheme = m_ThemeManager.GetCurrentTheme();

            var budgetsByCategory = m_SessionManager.GetActiveProfile().GetBudgetsByCategory();
            foreach (var budgetCategory in budgetsByCategory)
            {
                // Create new budget category marker
                var budgetCategoryWidget = new BudgetCategory();
                budgetCategoryWidget.Width = PlanPanel.ClientSize.Width;
                budgetCategoryWidget.SetLabel(budgetCategory.Key);
                budgetCategoryWidget.UpdateTheme(currentTheme);
                PlanPanel.Controls.Add(budgetCategoryWidget);

                // Create new budget edit(s)  
                foreach (var budget in budgetCategory.Value)
                {
                    var budgetWidget = new BudgetEdit(m_SessionManager, this, m_EventDispatcher, m_ThemeManager);
                    budgetWidget.UpdateTheme(currentTheme);
                    budgetWidget.SetValue(budget.GetCurrentSpentAmount());
                    budgetWidget.SetMaxValue(budget.GetMaxSpentAmount());
                    budgetWidget.SetName(budget.GetName());

                    PlanPanel.Controls.Add(budgetWidget);
                }
            }
        }

        public void ApplyTheme(Theme InTheme)
        {
            PlanPanel.BackColor = InTheme.Surface;
            PlanHeaderPanel.BackColor = InTheme.Surface;
            BudgetsLabel.BackColor = InTheme.Surface;

            TransactionPanel.BackColor = InTheme.Surface;
            TransactionHeaderPanel.BackColor = InTheme.Surface;
            TransactionsTitle.BackColor = InTheme.Surface;

            foreach (var control in PlanPanel.Controls)
            {
                if (control is BudgetCategory)
                {
                    var budgetCategory = control as BudgetCategory;
                    budgetCategory.UpdateTheme(InTheme);
                }
                else if (control is BudgetEdit)
                {
                    var budgetEdit = control as BudgetEdit;
                    budgetEdit.UpdateTheme(InTheme);
                }
            }

            foreach (var control in TransactionPanel.Controls)
            {
                if (control is TransactionView)
                {
                    var transactionView = control as TransactionView;
                    transactionView.UpdateTheme(InTheme);
                }
            }
        }
    }



    /*  decimal totalSubscriptionSpending = 0;

          var subscriptions = m_SessionManager.GetActiveProfile().GetSubscriptions();
          foreach (var subscription in subscriptions)
          {
              var calculator = new TimelineCalculator(subscription.GetName(), new DateTime(2026, 1, 1), CalendarRepeatType.Month);
              var result = calculator.GetOccurrencesInMonth(2026, 4);

              foreach (var date in result)
              {
                  Logger.ConsoleInfo($"Subscription: {subscription.GetName()}; Amount: {subscription.GetChargeAmount()}, Date: {date}");
                  totalSubscriptionSpending += subscription.GetChargeAmount();
              }
          }

          Logger.ConsoleInfo($"{totalSubscriptionSpending}");

          SubscriptionTotal.Text = totalSubscriptionSpending.ToString();

          {
              List<PieSlice> slices = new()
              {
                  new PieSlice() { Value = 5, FillColor = new ScottPlot.Color(255, 96, 165) },
                  new PieSlice() { Value = 2, FillColor = new ScottPlot.Color(255, 162, 96) },
              };

              var pie = SubscriptionPlot.Plot.Add.Pie(slices);
              pie.DonutFraction = .5;

              SubscriptionPlot.Plot.ShowLegend();

              // hide unnecessary plot components
              SubscriptionPlot.Plot.Axes.Frameless();
              SubscriptionPlot.Plot.HideGrid();

              ////  SubscriptionPlot.Plot.FigureBackground.Color = ScottPlot.Color.FromSDColor(SystemColors.ActiveCaption);
              //  SubscriptionPlot.Plot.DataBackground.Color = ScottPlot.Color.FromSDColor(SystemColors.ActiveCaption);
              SubscriptionPlot.Refresh();
          }

          {
              List<PieSlice> slices = new()
              {
                  new PieSlice() { Value = 5, FillColor = new ScottPlot.Color(255, 96, 165) },
                  new PieSlice() { Value = 2, FillColor = new ScottPlot.Color(255, 162, 96) },
              };

              var pie = IncomePlot.Plot.Add.Pie(slices);
              pie.DonutFraction = .5;

              IncomePlot.Plot.ShowLegend();

              // hide unnecessary plot components
              IncomePlot.Plot.Axes.Frameless();
              IncomePlot.Plot.HideGrid();

              ////  SubscriptionPlot.Plot.FigureBackground.Color = ScottPlot.Color.FromSDColor(SystemColors.ActiveCaption);
              //  SubscriptionPlot.Plot.DataBackground.Color = ScottPlot.Color.FromSDColor(SystemColors.ActiveCaption);
              IncomePlot.Refresh();
          }*/
}
