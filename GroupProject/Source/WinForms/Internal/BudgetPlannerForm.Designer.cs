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
            MessagePanel = new Panel();
            Message = new Label();
            MessageIcon = new PictureBox();
            TableLayoutPanel = new TableLayoutPanel();
            MessagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MessageIcon).BeginInit();
            TableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.GradientInactiveCaption;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(3, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1079, 566);
            MainPanel.TabIndex = 0;
            // 
            // MessagePanel
            // 
            MessagePanel.BackColor = Color.PaleGreen;
            MessagePanel.Controls.Add(Message);
            MessagePanel.Controls.Add(MessageIcon);
            MessagePanel.Dock = DockStyle.Fill;
            MessagePanel.Location = new Point(3, 575);
            MessagePanel.Name = "MessagePanel";
            MessagePanel.Size = new Size(1079, 50);
            MessagePanel.TabIndex = 1;
            // 
            // Message
            // 
            Message.AutoSize = true;
            Message.Location = new Point(46, 3);
            Message.Name = "Message";
            Message.Size = new Size(50, 20);
            Message.TabIndex = 2;
            Message.Text = "label1";
            Message.Click += Message_Click;
            // 
            // MessageIcon
            // 
            MessageIcon.Image = GroupProject.Properties.Resources.WarnIcon;
            MessageIcon.Location = new Point(3, 3);
            MessageIcon.Name = "MessageIcon";
            MessageIcon.Size = new Size(37, 37);
            MessageIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            MessageIcon.TabIndex = 0;
            MessageIcon.TabStop = false;
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.AutoSize = true;
            TableLayoutPanel.ColumnCount = 1;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel.Controls.Add(MessagePanel, 0, 1);
            TableLayoutPanel.Controls.Add(MainPanel, 0, 0);
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(0, 0);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 2;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 91.2408752F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.759123F));
            TableLayoutPanel.Size = new Size(1085, 628);
            TableLayoutPanel.TabIndex = 0;
            // 
            // BudgetPlannerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1085, 628);
            Controls.Add(TableLayoutPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BudgetPlannerForm";
            Text = "Budget Planner";
            Load += BudgetPlannerForm_Load;
            MessagePanel.ResumeLayout(false);
            MessagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MessageIcon).EndInit();
            TableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MainPanel;
        private Panel MessagePanel;
        private PictureBox MessageIcon;
        private Label Message;
        private TableLayoutPanel TableLayoutPanel;
    }
}
