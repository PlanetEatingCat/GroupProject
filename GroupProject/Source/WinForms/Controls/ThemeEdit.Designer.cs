namespace BudgetPlanner
{
    partial class ThemeEdit
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
            DarkModeColorPanel = new Panel();
            DarkModeLabel = new Label();
            CurrentColorPanel = new Panel();
            ThemeColorLabel = new Label();
            ColorSelectButton = new FontAwesome.Sharp.IconButton();
            ColorSelect = new ColorDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            DarkModeColorPanel.SuspendLayout();
            CurrentColorPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // DarkModeColorPanel
            // 
            DarkModeColorPanel.BackColor = Color.White;
            DarkModeColorPanel.Controls.Add(DarkModeLabel);
            DarkModeColorPanel.Dock = DockStyle.Fill;
            DarkModeColorPanel.Location = new Point(0, 93);
            DarkModeColorPanel.Margin = new Padding(0);
            DarkModeColorPanel.Name = "DarkModeColorPanel";
            DarkModeColorPanel.Size = new Size(259, 93);
            DarkModeColorPanel.TabIndex = 3;
            // 
            // DarkModeLabel
            // 
            DarkModeLabel.AutoSize = true;
            DarkModeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DarkModeLabel.Location = new Point(3, 3);
            DarkModeLabel.Name = "DarkModeLabel";
            DarkModeLabel.Size = new Size(115, 28);
            DarkModeLabel.TabIndex = 0;
            DarkModeLabel.Text = "Dark Mode";
            // 
            // CurrentColorPanel
            // 
            CurrentColorPanel.BackColor = SystemColors.MenuHighlight;
            CurrentColorPanel.Controls.Add(ThemeColorLabel);
            CurrentColorPanel.Controls.Add(ColorSelectButton);
            CurrentColorPanel.Dock = DockStyle.Fill;
            CurrentColorPanel.Location = new Point(0, 0);
            CurrentColorPanel.Margin = new Padding(0);
            CurrentColorPanel.Name = "CurrentColorPanel";
            CurrentColorPanel.Size = new Size(259, 93);
            CurrentColorPanel.TabIndex = 2;
            // 
            // ThemeColorLabel
            // 
            ThemeColorLabel.AutoSize = true;
            ThemeColorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ThemeColorLabel.ForeColor = Color.White;
            ThemeColorLabel.Location = new Point(3, 3);
            ThemeColorLabel.Name = "ThemeColorLabel";
            ThemeColorLabel.Size = new Size(88, 28);
            ThemeColorLabel.TabIndex = 1;
            ThemeColorLabel.Text = "Primary";
            // 
            // ColorSelectButton
            // 
            ColorSelectButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ColorSelectButton.FlatAppearance.BorderSize = 0;
            ColorSelectButton.FlatStyle = FlatStyle.Flat;
            ColorSelectButton.IconChar = FontAwesome.Sharp.IconChar.Cog;
            ColorSelectButton.IconColor = Color.White;
            ColorSelectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ColorSelectButton.IconSize = 30;
            ColorSelectButton.Location = new Point(214, 3);
            ColorSelectButton.Name = "ColorSelectButton";
            ColorSelectButton.Size = new Size(43, 40);
            ColorSelectButton.TabIndex = 0;
            ColorSelectButton.UseVisualStyleBackColor = true;
            ColorSelectButton.Click += ColorSelectButton_Click;
            // 
            // ColorSelect
            // 
            ColorSelect.Color = SystemColors.MenuHighlight;
            ColorSelect.FullOpen = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(DarkModeColorPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(CurrentColorPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(259, 186);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // ThemeEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ThemeEdit";
            Size = new Size(259, 186);
            DarkModeColorPanel.ResumeLayout(false);
            DarkModeColorPanel.PerformLayout();
            CurrentColorPanel.ResumeLayout(false);
            CurrentColorPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel DarkModeColorPanel;
        private Label DarkModeLabel;
        private Panel CurrentColorPanel;
        private Label ThemeColorLabel;
        private FontAwesome.Sharp.IconButton ColorSelectButton;
        private ColorDialog ColorSelect;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
