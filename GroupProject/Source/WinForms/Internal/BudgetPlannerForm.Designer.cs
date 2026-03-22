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
            MainPanel.Location = new Point(4, 16);
            MainPanel.Margin = new Padding(4, 3, 4, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1348, 694);
            MainPanel.TabIndex = 0;
            MainPanel.Paint += MainPanel_Paint;
            // 
            // MessagePanel
            // 
            MessagePanel.BackColor = Color.PaleGreen;
            MessagePanel.Controls.Add(Message);
            MessagePanel.Controls.Add(MessageIcon);
            MessagePanel.Dock = DockStyle.Fill;
            MessagePanel.Location = new Point(4, 716);
            MessagePanel.Margin = new Padding(4, 3, 4, 3);
            MessagePanel.Name = "MessagePanel";
            MessagePanel.Size = new Size(1348, 66);
            MessagePanel.TabIndex = 1;
            // 
            // Message
            // 
            Message.AutoSize = true;
            Message.Location = new Point(57, 3);
            Message.Margin = new Padding(4, 0, 4, 0);
            Message.Name = "Message";
            Message.Size = new Size(59, 25);
            Message.TabIndex = 2;
            Message.Text = "label1";
            Message.Click += Message_Click;
            // 
            // MessageIcon
            // 
            MessageIcon.Image = GroupProject.Properties.Resources.WarnIcon;
            MessageIcon.Location = new Point(4, 3);
            MessageIcon.Margin = new Padding(4, 3, 4, 3);
            MessageIcon.Name = "MessageIcon";
            MessageIcon.Size = new Size(46, 47);
            MessageIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            MessageIcon.TabIndex = 0;
            MessageIcon.TabStop = false;
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.AutoSize = true;
            TableLayoutPanel.ColumnCount = 1;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel.Controls.Add(MessagePanel, 0, 2);
            TableLayoutPanel.Controls.Add(MainPanel, 0, 1);
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(0, 0);
            TableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 3;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 1.65605092F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 89.1719742F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9.129512F));
            TableLayoutPanel.Size = new Size(1356, 785);
            TableLayoutPanel.TabIndex = 0;
            // 
            // BudgetPlannerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1356, 785);
            Controls.Add(TableLayoutPanel);
            Margin = new Padding(4, 5, 4, 5);
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
