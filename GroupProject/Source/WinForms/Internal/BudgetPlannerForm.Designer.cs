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
            panel1 = new Panel();
            MessagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MessageIcon).BeginInit();
            TableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.GradientInactiveCaption;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(3, 51);
            MainPanel.Margin = new Padding(3, 2, 3, 2);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(943, 374);
            MainPanel.TabIndex = 0;
            MainPanel.Paint += MainPanel_Paint;
            // 
            // MessagePanel
            // 
            MessagePanel.BackColor = Color.PaleGreen;
            MessagePanel.Controls.Add(Message);
            MessagePanel.Controls.Add(MessageIcon);
            MessagePanel.Dock = DockStyle.Fill;
            MessagePanel.Location = new Point(3, 429);
            MessagePanel.Margin = new Padding(3, 2, 3, 2);
            MessagePanel.Name = "MessagePanel";
            MessagePanel.Size = new Size(943, 40);
            MessagePanel.TabIndex = 1;
            // 
            // Message
            // 
            Message.AutoSize = true;
            Message.Location = new Point(40, 2);
            Message.Name = "Message";
            Message.Size = new Size(38, 15);
            Message.TabIndex = 2;
            Message.Text = "label1";
            Message.Click += Message_Click;
            // 
            // MessageIcon
            // 
            MessageIcon.Image = GroupProject.Properties.Resources.WarnIcon;
            MessageIcon.Location = new Point(3, 2);
            MessageIcon.Margin = new Padding(3, 2, 3, 2);
            MessageIcon.Name = "MessageIcon";
            MessageIcon.Size = new Size(32, 28);
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
            TableLayoutPanel.Controls.Add(panel1, 0, 0);
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(0, 0);
            TableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 3;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4033966F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 80.254776F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9.129512F));
            TableLayoutPanel.Size = new Size(949, 471);
            TableLayoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(943, 43);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // BudgetPlannerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(949, 471);
            Controls.Add(TableLayoutPanel);
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
        private Panel panel1;
    }
}
