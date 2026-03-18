namespace BudgetPlanner
{
    partial class BudgetPlannerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainPanel = new Panel();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.GradientInactiveCaption;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1085, 628);
            MainPanel.TabIndex = 0;
            // 
            // BudgetPlannerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1085, 628);
            Controls.Add(MainPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BudgetPlannerForm";
            Text = "Budget Planner";
            Load += BudgetPlannerForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
    }
}
