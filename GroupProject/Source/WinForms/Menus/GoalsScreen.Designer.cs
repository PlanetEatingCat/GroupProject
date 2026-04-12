namespace BudgetPlanner
{
    partial class GoalsScreen
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
            SavingsGoalBar = new ProgressBar();
            ProgressTitle = new Label();
            SavingsList = new ListBox();
            GoalAmount = new Label();
            GoalAmountEntry = new TextBox();
            ConfirmButton = new Button();
            ProgressAmount = new Label();
            SavingsGoalAmount = new Label();
            ConfirmAddBtn = new Button();
            AmountLabel = new Label();
            AmountToAdd = new TextBox();
            SuspendLayout();
            // 
            // SavingsGoalBar
            // 
            SavingsGoalBar.Anchor = AnchorStyles.None;
            SavingsGoalBar.ForeColor = Color.LawnGreen;
            SavingsGoalBar.Location = new Point(206, 166);
            SavingsGoalBar.Margin = new Padding(2);
            SavingsGoalBar.Name = "SavingsGoalBar";
            SavingsGoalBar.Size = new Size(520, 59);
            SavingsGoalBar.TabIndex = 0;
            // 
            // ProgressTitle
            // 
            ProgressTitle.Anchor = AnchorStyles.Top;
            ProgressTitle.AutoSize = true;
            ProgressTitle.Font = new Font("Segoe UI", 20F);
            ProgressTitle.Location = new Point(357, 41);
            ProgressTitle.Margin = new Padding(2, 0, 2, 0);
            ProgressTitle.Name = "ProgressTitle";
            ProgressTitle.Size = new Size(223, 46);
            ProgressTitle.TabIndex = 1;
            ProgressTitle.Text = "Savings Goals";
            // 
            // SavingsList
            // 
            SavingsList.Anchor = AnchorStyles.None;
            SavingsList.BorderStyle = BorderStyle.FixedSingle;
            SavingsList.FormattingEnabled = true;
            SavingsList.Location = new Point(206, 271);
            SavingsList.Margin = new Padding(2);
            SavingsList.Name = "SavingsList";
            SavingsList.Size = new Size(521, 222);
            SavingsList.TabIndex = 2;
            // 
            // GoalAmount
            // 
            GoalAmount.Anchor = AnchorStyles.None;
            GoalAmount.AutoSize = true;
            GoalAmount.Location = new Point(242, 123);
            GoalAmount.Margin = new Padding(2, 0, 2, 0);
            GoalAmount.Name = "GoalAmount";
            GoalAmount.Size = new Size(100, 20);
            GoalAmount.TabIndex = 3;
            GoalAmount.Text = "Goal Amount:";
            GoalAmount.Click += GoalAmount_Click;
            // 
            // GoalAmountEntry
            // 
            GoalAmountEntry.Anchor = AnchorStyles.None;
            GoalAmountEntry.BorderStyle = BorderStyle.None;
            GoalAmountEntry.Location = new Point(346, 123);
            GoalAmountEntry.Margin = new Padding(2);
            GoalAmountEntry.Name = "GoalAmountEntry";
            GoalAmountEntry.Size = new Size(121, 20);
            GoalAmountEntry.TabIndex = 4;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Anchor = AnchorStyles.None;
            ConfirmButton.BackColor = SystemColors.MenuHighlight;
            ConfirmButton.FlatAppearance.BorderSize = 0;
            ConfirmButton.FlatStyle = FlatStyle.Flat;
            ConfirmButton.Location = new Point(490, 120);
            ConfirmButton.Margin = new Padding(2);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(90, 27);
            ConfirmButton.TabIndex = 5;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // ProgressAmount
            // 
            ProgressAmount.Anchor = AnchorStyles.None;
            ProgressAmount.AutoSize = true;
            ProgressAmount.Location = new Point(206, 238);
            ProgressAmount.Margin = new Padding(2, 0, 2, 0);
            ProgressAmount.Name = "ProgressAmount";
            ProgressAmount.Size = new Size(122, 20);
            ProgressAmount.TabIndex = 6;
            ProgressAmount.Text = "Progress Amount";
            // 
            // SavingsGoalAmount
            // 
            SavingsGoalAmount.Anchor = AnchorStyles.None;
            SavingsGoalAmount.AutoSize = true;
            SavingsGoalAmount.Location = new Point(550, 238);
            SavingsGoalAmount.Margin = new Padding(2, 0, 2, 0);
            SavingsGoalAmount.Name = "SavingsGoalAmount";
            SavingsGoalAmount.Size = new Size(97, 20);
            SavingsGoalAmount.TabIndex = 7;
            SavingsGoalAmount.Text = "Goal Amount";
            // 
            // ConfirmAddBtn
            // 
            ConfirmAddBtn.Anchor = AnchorStyles.None;
            ConfirmAddBtn.BackColor = SystemColors.MenuHighlight;
            ConfirmAddBtn.FlatAppearance.BorderSize = 0;
            ConfirmAddBtn.FlatStyle = FlatStyle.Flat;
            ConfirmAddBtn.Location = new Point(412, 562);
            ConfirmAddBtn.Margin = new Padding(2);
            ConfirmAddBtn.Name = "ConfirmAddBtn";
            ConfirmAddBtn.Size = new Size(90, 27);
            ConfirmAddBtn.TabIndex = 8;
            ConfirmAddBtn.Text = "Confirm";
            ConfirmAddBtn.UseVisualStyleBackColor = false;
            ConfirmAddBtn.Click += ConfirmAddBtn_Click;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.None;
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(401, 506);
            AmountLabel.Margin = new Padding(2, 0, 2, 0);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(114, 20);
            AmountLabel.TabIndex = 9;
            AmountLabel.Text = "Amount To Add";
            // 
            // AmountToAdd
            // 
            AmountToAdd.Anchor = AnchorStyles.None;
            AmountToAdd.BorderStyle = BorderStyle.None;
            AmountToAdd.Location = new Point(401, 533);
            AmountToAdd.Margin = new Padding(2);
            AmountToAdd.Name = "AmountToAdd";
            AmountToAdd.Size = new Size(112, 20);
            AmountToAdd.TabIndex = 10;
            // 
            // GoalsScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(AmountToAdd);
            Controls.Add(AmountLabel);
            Controls.Add(ConfirmAddBtn);
            Controls.Add(SavingsGoalAmount);
            Controls.Add(ProgressAmount);
            Controls.Add(ConfirmButton);
            Controls.Add(GoalAmountEntry);
            Controls.Add(GoalAmount);
            Controls.Add(SavingsList);
            Controls.Add(ProgressTitle);
            Controls.Add(SavingsGoalBar);
            Margin = new Padding(2);
            Name = "GoalsScreen";
            Size = new Size(987, 648);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar SavingsGoalBar;
        private Label ProgressTitle;
        private ListBox SavingsList;
        private Label GoalAmount;
        private TextBox GoalAmountEntry;
        private Button ConfirmButton;
        private Label ProgressAmount;
        private Label SavingsGoalAmount;
        private Button ConfirmAddBtn;
        private Label AmountLabel;
        private TextBox AmountToAdd;
    }
}
