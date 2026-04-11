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
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // SavingsGoalBar
            // 
            SavingsGoalBar.ForeColor = Color.LawnGreen;
            SavingsGoalBar.Location = new Point(258, 207);
            SavingsGoalBar.Name = "SavingsGoalBar";
            SavingsGoalBar.Size = new Size(650, 74);
            SavingsGoalBar.TabIndex = 0;
            // 
            // ProgressTitle
            // 
            ProgressTitle.AutoSize = true;
            ProgressTitle.Font = new Font("Segoe UI", 20F);
            ProgressTitle.Location = new Point(469, 52);
            ProgressTitle.Name = "ProgressTitle";
            ProgressTitle.Size = new Size(265, 54);
            ProgressTitle.TabIndex = 1;
            ProgressTitle.Text = "Savings Goals";
            // 
            // SavingsList
            // 
            SavingsList.FormattingEnabled = true;
            SavingsList.ItemHeight = 25;
            SavingsList.Location = new Point(258, 339);
            SavingsList.Name = "SavingsList";
            SavingsList.Size = new Size(650, 279);
            SavingsList.TabIndex = 2;
            // 
            // GoalAmount
            // 
            GoalAmount.AutoSize = true;
            GoalAmount.Location = new Point(303, 154);
            GoalAmount.Name = "GoalAmount";
            GoalAmount.Size = new Size(122, 25);
            GoalAmount.TabIndex = 3;
            GoalAmount.Text = "Goal Amount:";
            GoalAmount.Click += GoalAmount_Click;
            // 
            // GoalAmountEntry
            // 
            GoalAmountEntry.Location = new Point(441, 151);
            GoalAmountEntry.Name = "GoalAmountEntry";
            GoalAmountEntry.Size = new Size(150, 31);
            GoalAmountEntry.TabIndex = 4;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(622, 149);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(112, 34);
            ConfirmButton.TabIndex = 5;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // ProgressAmount
            // 
            ProgressAmount.AutoSize = true;
            ProgressAmount.Location = new Point(258, 298);
            ProgressAmount.Name = "ProgressAmount";
            ProgressAmount.Size = new Size(151, 25);
            ProgressAmount.TabIndex = 6;
            ProgressAmount.Text = "Progress Amount";
            // 
            // SavingsGoalAmount
            // 
            SavingsGoalAmount.AutoSize = true;
            SavingsGoalAmount.Location = new Point(688, 298);
            SavingsGoalAmount.Name = "SavingsGoalAmount";
            SavingsGoalAmount.Size = new Size(118, 25);
            SavingsGoalAmount.TabIndex = 7;
            SavingsGoalAmount.Text = "Goal Amount";
            // 
            // button1
            // 
            button1.Location = new Point(607, 739);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(607, 675);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // GoalsScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(textBox1);
            Controls.Add(button1);
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
            Size = new Size(1234, 810);
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
        private Button button1;
        private TextBox textBox1;
    }
}
