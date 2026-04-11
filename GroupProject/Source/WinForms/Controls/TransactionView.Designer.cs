namespace BudgetPlanner
{
    partial class TransactionView
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
            Icon = new FontAwesome.Sharp.IconPictureBox();
            TypeAndAmountLabel = new Label();
            UpcommingLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)Icon).BeginInit();
            SuspendLayout();
            // 
            // Icon
            // 
            Icon.BackColor = SystemColors.Control;
            Icon.Dock = DockStyle.Left;
            Icon.ForeColor = SystemColors.ControlText;
            Icon.IconChar = FontAwesome.Sharp.IconChar.CircleArrowUp;
            Icon.IconColor = SystemColors.ControlText;
            Icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Icon.IconSize = 75;
            Icon.Location = new Point(0, 0);
            Icon.Name = "Icon";
            Icon.Size = new Size(77, 75);
            Icon.TabIndex = 0;
            Icon.TabStop = false;
            // 
            // TypeAndAmountLabel
            // 
            TypeAndAmountLabel.Anchor = AnchorStyles.Left;
            TypeAndAmountLabel.AutoSize = true;
            TypeAndAmountLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TypeAndAmountLabel.Location = new Point(83, 20);
            TypeAndAmountLabel.Name = "TypeAndAmountLabel";
            TypeAndAmountLabel.Size = new Size(106, 32);
            TypeAndAmountLabel.TabIndex = 1;
            TypeAndAmountLabel.Text = "Gas: $60";
            TypeAndAmountLabel.Click += label1_Click;
            // 
            // UpcommingLabel
            // 
            UpcommingLabel.Anchor = AnchorStyles.Right;
            UpcommingLabel.AutoSize = true;
            UpcommingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpcommingLabel.Location = new Point(313, 20);
            UpcommingLabel.Name = "UpcommingLabel";
            UpcommingLabel.Size = new Size(154, 32);
            UpcommingLabel.TabIndex = 2;
            UpcommingLabel.Text = "Upcomming";
            // 
            // TransactionView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UpcommingLabel);
            Controls.Add(TypeAndAmountLabel);
            Controls.Add(Icon);
            Name = "TransactionView";
            Size = new Size(482, 75);
            ((System.ComponentModel.ISupportInitialize)Icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox Icon;
        private Label TypeAndAmountLabel;
        private Label UpcommingLabel;
    }
}
