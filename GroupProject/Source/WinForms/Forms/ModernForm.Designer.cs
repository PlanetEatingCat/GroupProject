namespace BudgetPlanner
{
    partial class ModernForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RightMenuBarPanel = new Panel();
            MinButton = new Button();
            MaxButton = new Button();
            CloseButton = new Button();
            LeftMenuBarPanel = new Panel();
            BaseMainPanel = new Panel();
            TitleBarPanel = new Panel();
            TitleBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RightMenuBarPanel
            // 
            RightMenuBarPanel.Dock = DockStyle.Right;
            RightMenuBarPanel.Location = new Point(231, 0);
            RightMenuBarPanel.Margin = new Padding(3, 4, 3, 4);
            RightMenuBarPanel.Name = "RightMenuBarPanel";
            RightMenuBarPanel.Size = new Size(118, 66);
            RightMenuBarPanel.TabIndex = 6;
            // 
            // MinButton
            // 
            MinButton.BackColor = SystemColors.GradientActiveCaption;
            MinButton.Dock = DockStyle.Right;
            MinButton.FlatAppearance.BorderSize = 0;
            MinButton.FlatStyle = FlatStyle.Flat;
            MinButton.Location = new Point(349, 0);
            MinButton.Margin = new Padding(0);
            MinButton.Name = "MinButton";
            MinButton.Size = new Size(56, 66);
            MinButton.TabIndex = 2;
            MinButton.UseVisualStyleBackColor = false;
            MinButton.Click += MinButton_Click;
            // 
            // MaxButton
            // 
            MaxButton.BackColor = Color.Transparent;
            MaxButton.Dock = DockStyle.Right;
            MaxButton.FlatAppearance.BorderSize = 0;
            MaxButton.FlatStyle = FlatStyle.Flat;
            MaxButton.Location = new Point(405, 0);
            MaxButton.Margin = new Padding(3, 4, 3, 4);
            MaxButton.Name = "MaxButton";
            MaxButton.Size = new Size(56, 66);
            MaxButton.TabIndex = 1;
            MaxButton.UseVisualStyleBackColor = false;
            MaxButton.Click += MaxButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Transparent;
            CloseButton.Dock = DockStyle.Right;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(461, 0);
            CloseButton.Margin = new Padding(3, 4, 3, 4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(56, 66);
            CloseButton.TabIndex = 0;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // LeftMenuBarPanel
            // 
            LeftMenuBarPanel.Dock = DockStyle.Left;
            LeftMenuBarPanel.Location = new Point(0, 0);
            LeftMenuBarPanel.Margin = new Padding(3, 4, 3, 4);
            LeftMenuBarPanel.Name = "LeftMenuBarPanel";
            LeftMenuBarPanel.Size = new Size(118, 66);
            LeftMenuBarPanel.TabIndex = 7;
            // 
            // BaseMainPanel
            // 
            BaseMainPanel.BackColor = SystemColors.GradientActiveCaption;
            BaseMainPanel.Dock = DockStyle.Fill;
            BaseMainPanel.Location = new Point(0, 66);
            BaseMainPanel.Name = "BaseMainPanel";
            BaseMainPanel.Size = new Size(517, 307);
            BaseMainPanel.TabIndex = 4;
            // 
            // TitleBarPanel
            // 
            TitleBarPanel.BackColor = SystemColors.GradientActiveCaption;
            TitleBarPanel.Controls.Add(RightMenuBarPanel);
            TitleBarPanel.Controls.Add(MinButton);
            TitleBarPanel.Controls.Add(LeftMenuBarPanel);
            TitleBarPanel.Controls.Add(MaxButton);
            TitleBarPanel.Controls.Add(CloseButton);
            TitleBarPanel.Dock = DockStyle.Top;
            TitleBarPanel.Location = new Point(0, 0);
            TitleBarPanel.Name = "TitleBarPanel";
            TitleBarPanel.Size = new Size(517, 66);
            TitleBarPanel.TabIndex = 5;
            TitleBarPanel.MouseDown += TitleBarPanel_MouseDown;
            TitleBarPanel.Resize += TitleBarPanel_Resize;
            // 
            // ModernForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(517, 373);
            Controls.Add(BaseMainPanel);
            Controls.Add(TitleBarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ModernForm";
            Text = "BaseForm";
            Load += BaseForm_Load;
            TitleBarPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        protected Panel RightMenuBarPanel;
        protected Button MinButton;
        protected Button MaxButton;
        protected Button CloseButton;
        protected Panel LeftMenuBarPanel;
        protected Panel BaseMainPanel;
        protected Panel TitleBarPanel;
    }
}