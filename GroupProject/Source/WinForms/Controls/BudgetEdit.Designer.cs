namespace BudgetPlanner
{
    partial class BudgetEdit
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
            NameLabel = new Label();
            SpentPanelBackground = new Panel();
            SpentPanelFill = new Panel();
            ProgressLabel = new Label();
            AmountInfoLabel = new Label();
            EditButton = new FontAwesome.Sharp.IconButton();
            HeaderPanel = new Panel();
            SpentPanelBackground.SuspendLayout();
            SpentPanelFill.SuspendLayout();
            HeaderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLabel.Location = new Point(10, 8);
            NameLabel.Margin = new Padding(2, 0, 2, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(85, 28);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Housing";
            // 
            // SpentPanelBackground
            // 
            SpentPanelBackground.BackColor = SystemColors.ControlDark;
            SpentPanelBackground.Controls.Add(SpentPanelFill);
            SpentPanelBackground.Dock = DockStyle.Fill;
            SpentPanelBackground.Location = new Point(0, 46);
            SpentPanelBackground.Margin = new Padding(2);
            SpentPanelBackground.Name = "SpentPanelBackground";
            SpentPanelBackground.Size = new Size(365, 47);
            SpentPanelBackground.TabIndex = 1;
            // 
            // SpentPanelFill
            // 
            SpentPanelFill.BackColor = Color.FromArgb(255, 128, 128);
            SpentPanelFill.Controls.Add(ProgressLabel);
            SpentPanelFill.Dock = DockStyle.Left;
            SpentPanelFill.Location = new Point(0, 0);
            SpentPanelFill.Margin = new Padding(2);
            SpentPanelFill.Name = "SpentPanelFill";
            SpentPanelFill.Size = new Size(253, 47);
            SpentPanelFill.TabIndex = 0;
            // 
            // ProgressLabel
            // 
            ProgressLabel.AutoSize = true;
            ProgressLabel.BackColor = Color.Transparent;
            ProgressLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProgressLabel.ForeColor = SystemColors.ActiveCaptionText;
            ProgressLabel.Location = new Point(10, 11);
            ProgressLabel.Margin = new Padding(2, 0, 2, 0);
            ProgressLabel.Name = "ProgressLabel";
            ProgressLabel.Size = new Size(128, 25);
            ProgressLabel.TabIndex = 0;
            ProgressLabel.Text = "$236 of $360";
            // 
            // AmountInfoLabel
            // 
            AmountInfoLabel.AutoSize = true;
            AmountInfoLabel.Dock = DockStyle.Right;
            AmountInfoLabel.Location = new Point(266, 0);
            AmountInfoLabel.Margin = new Padding(2, 0, 2, 0);
            AmountInfoLabel.Name = "AmountInfoLabel";
            AmountInfoLabel.Padding = new Padding(0, 16, 0, 0);
            AmountInfoLabel.Size = new Size(62, 36);
            AmountInfoLabel.TabIndex = 2;
            AmountInfoLabel.Text = "$25 Left";
            AmountInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditButton
            // 
            EditButton.Dock = DockStyle.Right;
            EditButton.FlatAppearance.BorderSize = 0;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.IconChar = FontAwesome.Sharp.IconChar.Cog;
            EditButton.IconColor = Color.Black;
            EditButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EditButton.Location = new Point(328, 0);
            EditButton.Margin = new Padding(2);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(37, 46);
            EditButton.TabIndex = 3;
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += iconButton1_Click;
            // 
            // HeaderPanel
            // 
            HeaderPanel.Controls.Add(AmountInfoLabel);
            HeaderPanel.Controls.Add(EditButton);
            HeaderPanel.Controls.Add(NameLabel);
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Margin = new Padding(2);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(365, 46);
            HeaderPanel.TabIndex = 4;
            // 
            // BudgetEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SpentPanelBackground);
            Controls.Add(HeaderPanel);
            Margin = new Padding(2);
            Name = "BudgetEdit";
            Size = new Size(365, 93);
            SpentPanelBackground.ResumeLayout(false);
            SpentPanelFill.ResumeLayout(false);
            SpentPanelFill.PerformLayout();
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label NameLabel;
        private Panel SpentPanelBackground;
        private Panel SpentPanelFill;
        private Label AmountInfoLabel;
        private FontAwesome.Sharp.IconButton EditButton;
        private Panel HeaderPanel;
        private Label ProgressLabel;
    }
}
