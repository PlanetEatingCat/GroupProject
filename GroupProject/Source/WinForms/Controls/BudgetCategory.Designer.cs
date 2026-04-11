namespace BudgetPlanner
{
    partial class BudgetCategory
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
            CategoryLabel = new Label();
            SuspendLayout();
            // 
            // CategoryLabel
            // 
            CategoryLabel.Anchor = AnchorStyles.None;
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CategoryLabel.Location = new Point(127, -2);
            CategoryLabel.Margin = new Padding(2, 0, 2, 0);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(156, 28);
            CategoryLabel.TabIndex = 0;
            CategoryLabel.Text = "Auto / Transport";
            // 
            // BudgetCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CategoryLabel);
            Margin = new Padding(2);
            Name = "BudgetCategory";
            Size = new Size(397, 26);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CategoryLabel;
    }
}
