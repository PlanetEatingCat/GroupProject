namespace BudgetPlanner
{
    partial class DebugConsoleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugConsoleForm));
            DebugConsoleBox = new ListBox();
            BaseMainPanel.SuspendLayout();
            TitleBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RightMenuBarPanel
            // 
            RightMenuBarPanel.Location = new Point(732, 0);
            RightMenuBarPanel.Size = new Size(10, 66);
            // 
            // MinButton
            // 
            MinButton.BackColor = Color.Black;
            MinButton.FlatAppearance.BorderSize = 0;
            MinButton.Image = (Image)resources.GetObject("MinButton.Image");
            MinButton.Location = new Point(742, 0);
            // 
            // MaxButton
            // 
            MaxButton.BackColor = Color.Black;
            MaxButton.FlatAppearance.BorderSize = 0;
            MaxButton.Image = (Image)resources.GetObject("MaxButton.Image");
            MaxButton.Location = new Point(798, 0);
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Black;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.Image = (Image)resources.GetObject("CloseButton.Image");
            CloseButton.Location = new Point(854, 0);
            // 
            // LeftMenuBarPanel
            // 
            LeftMenuBarPanel.Size = new Size(10, 66);
            // 
            // BaseMainPanel
            // 
            BaseMainPanel.BackColor = SystemColors.ControlText;
            BaseMainPanel.Controls.Add(DebugConsoleBox);
            BaseMainPanel.Location = new Point(2, 68);
            BaseMainPanel.Size = new Size(910, 530);
            // 
            // TitleBarPanel
            // 
            TitleBarPanel.BackColor = Color.Black;
            TitleBarPanel.Location = new Point(2, 2);
            TitleBarPanel.Size = new Size(910, 66);
            // 
            // DebugConsoleBox
            // 
            DebugConsoleBox.BackColor = Color.Black;
            DebugConsoleBox.BorderStyle = BorderStyle.None;
            DebugConsoleBox.Dock = DockStyle.Fill;
            DebugConsoleBox.DrawMode = DrawMode.OwnerDrawFixed;
            DebugConsoleBox.ForeColor = SystemColors.HighlightText;
            DebugConsoleBox.FormattingEnabled = true;
            DebugConsoleBox.HorizontalScrollbar = true;
            DebugConsoleBox.ItemHeight = 15;
            DebugConsoleBox.Location = new Point(0, 0);
            DebugConsoleBox.Margin = new Padding(3, 4, 3, 4);
            DebugConsoleBox.Name = "DebugConsoleBox";
            DebugConsoleBox.Size = new Size(910, 530);
            DebugConsoleBox.TabIndex = 1;
            DebugConsoleBox.DrawItem += DebugConsoleBox_DrawItem;
            DebugConsoleBox.SelectedIndexChanged += DebugConsoleBox_SelectedIndexChanged;
            // 
            // DebugConsoleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(914, 600);
            Location = new Point(0, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DebugConsoleForm";
            Padding = new Padding(2);
            Text = "Debug Console";
            Load += DebugConsole_Load;
            BaseMainPanel.ResumeLayout(false);
            TitleBarPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox DebugConsoleBox;
    }
}