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
            DebugConsoleBox = new ListBox();
            SuspendLayout();
            // 
            // DebugConsoleBox
            // 
            DebugConsoleBox.BackColor = SystemColors.WindowText;
            DebugConsoleBox.Dock = DockStyle.Fill;
            DebugConsoleBox.DrawMode = DrawMode.OwnerDrawFixed;
            DebugConsoleBox.ForeColor = SystemColors.HighlightText;
            DebugConsoleBox.FormattingEnabled = true;
            DebugConsoleBox.HorizontalScrollbar = true;
            DebugConsoleBox.ItemHeight = 15;
            DebugConsoleBox.Location = new Point(0, 0);
            DebugConsoleBox.Margin = new Padding(3, 4, 3, 4);
            DebugConsoleBox.Name = "DebugConsoleBox";
            DebugConsoleBox.Size = new Size(914, 600);
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
            Controls.Add(DebugConsoleBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DebugConsoleForm";
            Text = "Debug Console";
            Load += DebugConsole_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox DebugConsoleBox;
    }
}