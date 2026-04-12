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
            PlanPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            PlanHeaderPanel = new Panel();
            AddBudgetButton = new FontAwesome.Sharp.IconButton();
            BudgetsLabel = new Label();
            panel2 = new Panel();
            TransactionPanel = new FlowLayoutPanel();
            TransactionHeaderPanel = new Panel();
            TransactionsTitle = new Label();
            panel1.SuspendLayout();
            PlanHeaderPanel.SuspendLayout();
            panel2.SuspendLayout();
            TransactionHeaderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PlanPanel
            // 
            PlanPanel.Anchor = AnchorStyles.None;
            PlanPanel.AutoScroll = true;
            PlanPanel.BackColor = SystemColors.ActiveCaption;
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
            PlanHeaderPanel.Anchor = AnchorStyles.None;
            PlanHeaderPanel.BackColor = SystemColors.MenuHighlight;
            PlanHeaderPanel.BorderStyle = BorderStyle.FixedSingle;
            PlanHeaderPanel.Controls.Add(AddBudgetButton);
            PlanHeaderPanel.Controls.Add(BudgetsLabel);
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
            TransactionPanel.Anchor = AnchorStyles.None;
            TransactionPanel.BackColor = SystemColors.ActiveCaption;
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
            TransactionsTitle.Anchor = AnchorStyles.None;
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
            Name = "DashboardScreen";
            Size = new Size(987, 816);
            Load += DashboardScreen_Load;
            panel1.ResumeLayout(false);
            PlanHeaderPanel.ResumeLayout(false);
            PlanHeaderPanel.PerformLayout();
            panel2.ResumeLayout(false);
            TransactionHeaderPanel.ResumeLayout(false);
            TransactionHeaderPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
