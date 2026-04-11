namespace BudgetPlanner
{
    partial class DashboardScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SubscriptionInfoPanel = new Panel();
            SubscriptionTotal = new Label();
            DollarLabel1 = new Label();
            SubscriptionInfoLabel = new Label();
            SubscriptionPlot = new ScottPlot.WinForms.FormsPlot();
            IncomeTotal = new Label();
            IncomeInfoLabel = new Label();
            IncomePlot = new ScottPlot.WinForms.FormsPlot();
            IncomeInfoPanel = new Panel();
            DollarLabel2 = new Label();
            PlanPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            PlanHeaderPanel = new Panel();
            AddBudgetButton = new FontAwesome.Sharp.IconButton();
            BudgetsLabel = new Label();
            panel2 = new Panel();
            TransactionPanel = new FlowLayoutPanel();
            TransactionHeaderPanel = new Panel();
            TransactionsTitle = new Label();
            SubscriptionInfoPanel.SuspendLayout();
            IncomeInfoPanel.SuspendLayout();
            PlanPanel.SuspendLayout();
            panel1.SuspendLayout();
            PlanHeaderPanel.SuspendLayout();
            panel2.SuspendLayout();
            TransactionHeaderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SubscriptionInfoPanel
            // 
            SubscriptionInfoPanel.BackColor = SystemColors.ActiveCaption;
            SubscriptionInfoPanel.BorderStyle = BorderStyle.FixedSingle;
            SubscriptionInfoPanel.Controls.Add(SubscriptionTotal);
            SubscriptionInfoPanel.Controls.Add(DollarLabel1);
            SubscriptionInfoPanel.Controls.Add(SubscriptionInfoLabel);
            SubscriptionInfoPanel.Controls.Add(SubscriptionPlot);
            SubscriptionInfoPanel.Location = new Point(39, 22);
            SubscriptionInfoPanel.Margin = new Padding(2);
            SubscriptionInfoPanel.Name = "SubscriptionInfoPanel";
            SubscriptionInfoPanel.Size = new Size(218, 134);
            SubscriptionInfoPanel.TabIndex = 0;
            // 
            // SubscriptionTotal
            // 
            SubscriptionTotal.AutoSize = true;
            SubscriptionTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubscriptionTotal.Location = new Point(38, 74);
            SubscriptionTotal.Margin = new Padding(2, 0, 2, 0);
            SubscriptionTotal.Name = "SubscriptionTotal";
            SubscriptionTotal.Size = new Size(48, 28);
            SubscriptionTotal.TabIndex = 2;
            SubscriptionTotal.Text = "672";
            // 
            // DollarLabel1
            // 
            DollarLabel1.AutoSize = true;
            DollarLabel1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DollarLabel1.Location = new Point(18, 69);
            DollarLabel1.Margin = new Padding(2, 0, 2, 0);
            DollarLabel1.Name = "DollarLabel1";
            DollarLabel1.Size = new Size(28, 32);
            DollarLabel1.TabIndex = 1;
            DollarLabel1.Text = "$";
            // 
            // SubscriptionInfoLabel
            // 
            SubscriptionInfoLabel.AutoSize = true;
            SubscriptionInfoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubscriptionInfoLabel.Location = new Point(14, 14);
            SubscriptionInfoLabel.Margin = new Padding(2, 0, 2, 0);
            SubscriptionInfoLabel.Name = "SubscriptionInfoLabel";
            SubscriptionInfoLabel.Size = new Size(139, 28);
            SubscriptionInfoLabel.TabIndex = 0;
            SubscriptionInfoLabel.Text = "Subscriptions";
            // 
            // SubscriptionPlot
            // 
            SubscriptionPlot.DisplayScale = 1.5F;
            SubscriptionPlot.Location = new Point(88, 33);
            SubscriptionPlot.Margin = new Padding(2);
            SubscriptionPlot.Name = "SubscriptionPlot";
            SubscriptionPlot.Size = new Size(130, 121);
            SubscriptionPlot.TabIndex = 3;
            // 
            // planCategoryEdit2
            // 
         
            // 
            // planCategoryEdit1
            // 
 
            // IncomeTotal
            // 
            IncomeTotal.AutoSize = true;
            IncomeTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IncomeTotal.Location = new Point(38, 74);
            IncomeTotal.Margin = new Padding(2, 0, 2, 0);
            IncomeTotal.Name = "IncomeTotal";
            IncomeTotal.Size = new Size(48, 28);
            IncomeTotal.TabIndex = 2;
            IncomeTotal.Text = "672";
            // 
            // IncomeInfoLabel
            // 
            IncomeInfoLabel.AutoSize = true;
            IncomeInfoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IncomeInfoLabel.Location = new Point(14, 14);
            IncomeInfoLabel.Margin = new Padding(2, 0, 2, 0);
            IncomeInfoLabel.Name = "IncomeInfoLabel";
            IncomeInfoLabel.Size = new Size(81, 28);
            IncomeInfoLabel.TabIndex = 0;
            IncomeInfoLabel.Text = "Income";
            // 
            // IncomePlot
            // 
            IncomePlot.DisplayScale = 1.5F;
            IncomePlot.Location = new Point(88, 33);
            IncomePlot.Margin = new Padding(2);
            IncomePlot.Name = "IncomePlot";
            IncomePlot.Size = new Size(130, 121);
            IncomePlot.TabIndex = 3;
            // 
            // IncomeInfoPanel
            // 
            IncomeInfoPanel.BackColor = SystemColors.ActiveCaption;
            IncomeInfoPanel.BorderStyle = BorderStyle.FixedSingle;
            IncomeInfoPanel.Controls.Add(IncomeTotal);
            IncomeInfoPanel.Controls.Add(DollarLabel2);
            IncomeInfoPanel.Controls.Add(IncomeInfoLabel);
            IncomeInfoPanel.Controls.Add(IncomePlot);
            IncomeInfoPanel.Location = new Point(292, 22);
            IncomeInfoPanel.Margin = new Padding(2);
            IncomeInfoPanel.Name = "IncomeInfoPanel";
            IncomeInfoPanel.Size = new Size(218, 134);
            IncomeInfoPanel.TabIndex = 2;
            // 
            // DollarLabel2
            // 
            DollarLabel2.AutoSize = true;
            DollarLabel2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DollarLabel2.Location = new Point(18, 69);
            DollarLabel2.Margin = new Padding(2, 0, 2, 0);
            DollarLabel2.Name = "DollarLabel2";
            DollarLabel2.Size = new Size(28, 32);
            DollarLabel2.TabIndex = 1;
            DollarLabel2.Text = "$";
            // 
            // PlanPanel
            // 
            PlanPanel.AutoScroll = true;
            PlanPanel.BackColor = SystemColors.ActiveCaption;
            PlanPanel.Controls.Add(planCategoryEdit2);
            PlanPanel.Controls.Add(planCategoryEdit1);
            PlanPanel.Dock = DockStyle.Fill;
            PlanPanel.FlowDirection = FlowDirection.TopDown;
            PlanPanel.Location = new Point(0, 39);
            PlanPanel.Name = "PlanPanel";
            PlanPanel.Size = new Size(439, 442);
            PlanPanel.TabIndex = 0;
            PlanPanel.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(PlanPanel);
            panel1.Controls.Add(PlanHeaderPanel);
            panel1.Location = new Point(39, 179);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 483);
            panel1.TabIndex = 3;
            // 
            // PlanHeaderPanel
            // 
            PlanHeaderPanel.BackColor = SystemColors.MenuHighlight;
            PlanHeaderPanel.BorderStyle = BorderStyle.FixedSingle;
            PlanHeaderPanel.Controls.Add(AddBudgetButton);
            PlanHeaderPanel.Controls.Add(BudgetsLabel);
            PlanHeaderPanel.Dock = DockStyle.Top;
            PlanHeaderPanel.Location = new Point(0, 0);
            PlanHeaderPanel.Name = "PlanHeaderPanel";
            PlanHeaderPanel.Size = new Size(439, 39);
            PlanHeaderPanel.TabIndex = 1;
            // 
            // AddBudgetButton
            // 
            AddBudgetButton.FlatAppearance.BorderSize = 0;
            AddBudgetButton.FlatStyle = FlatStyle.Flat;
            AddBudgetButton.IconChar = FontAwesome.Sharp.IconChar.Add;
            AddBudgetButton.IconColor = Color.White;
            AddBudgetButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddBudgetButton.IconSize = 30;
            AddBudgetButton.Location = new Point(396, 7);
            AddBudgetButton.Name = "AddBudgetButton";
            AddBudgetButton.Size = new Size(30, 26);
            AddBudgetButton.TabIndex = 1;
            AddBudgetButton.UseVisualStyleBackColor = true;
            AddBudgetButton.Click += AddBudgetButton_Click;
            // 
            // BudgetsLabel
            // 
            BudgetsLabel.AutoSize = true;
            BudgetsLabel.BackColor = SystemColors.MenuHighlight;
            BudgetsLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BudgetsLabel.ForeColor = SystemColors.Control;
            BudgetsLabel.Location = new Point(3, 2);
            BudgetsLabel.Name = "BudgetsLabel";
            BudgetsLabel.Size = new Size(99, 31);
            BudgetsLabel.TabIndex = 0;
            BudgetsLabel.Text = "Budgets";
            // 
            // panel2
            // 
            panel2.Controls.Add(TransactionPanel);
            panel2.Controls.Add(TransactionHeaderPanel);
            panel2.Location = new Point(530, 179);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 483);
            panel2.TabIndex = 4;
            // 
            // TransactionPanel
            // 
            TransactionPanel.BackColor = SystemColors.ActiveCaption;
            TransactionPanel.Dock = DockStyle.Fill;
            TransactionPanel.Location = new Point(0, 40);
            TransactionPanel.Margin = new Padding(2);
            TransactionPanel.Name = "TransactionPanel";
            TransactionPanel.Size = new Size(414, 443);
            TransactionPanel.TabIndex = 1;
            // 
            // TransactionHeaderPanel
            // 
            TransactionHeaderPanel.BackColor = SystemColors.MenuHighlight;
            TransactionHeaderPanel.BorderStyle = BorderStyle.FixedSingle;
            TransactionHeaderPanel.Controls.Add(TransactionsTitle);
            TransactionHeaderPanel.Dock = DockStyle.Top;
            TransactionHeaderPanel.Location = new Point(0, 0);
            TransactionHeaderPanel.Margin = new Padding(2);
            TransactionHeaderPanel.Name = "TransactionHeaderPanel";
            TransactionHeaderPanel.Size = new Size(414, 40);
            TransactionHeaderPanel.TabIndex = 0;
            // 
            // TransactionsTitle
            // 
            TransactionsTitle.AutoSize = true;
            TransactionsTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TransactionsTitle.ForeColor = SystemColors.Control;
            TransactionsTitle.Location = new Point(12, 3);
            TransactionsTitle.Name = "TransactionsTitle";
            TransactionsTitle.Size = new Size(143, 31);
            TransactionsTitle.TabIndex = 1;
            TransactionsTitle.Text = "Transactions";
            // 
            // DashboardScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(IncomeInfoPanel);
            Controls.Add(SubscriptionInfoPanel);
            Name = "DashboardScreen";
            Size = new Size(987, 816);
            Load += DashboardScreen_Load;
            SubscriptionInfoPanel.ResumeLayout(false);
            SubscriptionInfoPanel.PerformLayout();
            IncomeInfoPanel.ResumeLayout(false);
            IncomeInfoPanel.PerformLayout();
            PlanPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            PlanHeaderPanel.ResumeLayout(false);
            PlanHeaderPanel.PerformLayout();
            panel2.ResumeLayout(false);
            TransactionHeaderPanel.ResumeLayout(false);
            TransactionHeaderPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SubscriptionInfoPanel;
        private Label SubscriptionInfoLabel;
        private Label SubscriptionTotal;
        private Label DollarLabel1;
        private ScottPlot.WinForms.FormsPlot SubscriptionPlot;
        private Label IncomeTotal;
        private Label IncomeInfoLabel;
        private ScottPlot.WinForms.FormsPlot IncomePlot;
        private Panel IncomeInfoPanel;
        private Label DollarLabel2;
        private BudgetEdit planCategoryEdit2;
        private BudgetEdit planCategoryEdit1;
        private FlowLayoutPanel PlanPanel;
        private Panel panel1;
        private Panel PlanHeaderPanel;
        private FontAwesome.Sharp.IconButton AddBudgetButton;
        private Label BudgetsLabel;
        private Panel panel2;
        private Panel TransactionHeaderPanel;
        private Label TransactionsTitle;
        private FlowLayoutPanel TransactionPanel;
    }
}
