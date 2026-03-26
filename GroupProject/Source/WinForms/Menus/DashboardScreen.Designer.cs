namespace BudgetPlanner
{
    partial class DashboardScreen
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            panel1 = new Panel();
            SavingsProgressBar = new ProgressBar();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            formsPlot3 = new ScottPlot.WinForms.FormsPlot();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.BackColor = Color.Transparent;
            formsPlot1.DisplayScale = 1.25F;
            formsPlot1.Location = new Point(-29, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(296, 281);
            formsPlot1.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(SavingsProgressBar);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 71);
            panel1.TabIndex = 15;
            // 
            // SavingsProgressBar
            // 
            SavingsProgressBar.BackColor = SystemColors.ControlDarkDark;
            SavingsProgressBar.Dock = DockStyle.Fill;
            SavingsProgressBar.Location = new Point(0, 0);
            SavingsProgressBar.Margin = new Padding(5, 4, 5, 4);
            SavingsProgressBar.Maximum = 10000;
            SavingsProgressBar.Name = "SavingsProgressBar";
            SavingsProgressBar.Size = new Size(917, 71);
            SavingsProgressBar.TabIndex = 8;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.Dock = DockStyle.Right;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 70;
            iconPictureBox1.Location = new Point(917, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(70, 71);
            iconPictureBox1.TabIndex = 10;
            iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(formsPlot3);
            panel2.Controls.Add(formsPlot2);
            panel2.Controls.Add(formsPlot1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 284);
            panel2.Name = "panel2";
            panel2.Size = new Size(987, 364);
            panel2.TabIndex = 18;
            // 
            // formsPlot2
            // 
            formsPlot2.BackColor = Color.Transparent;
            formsPlot2.DisplayScale = 1.25F;
            formsPlot2.Location = new Point(333, 83);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(296, 281);
            formsPlot2.TabIndex = 17;
            // 
            // formsPlot3
            // 
            formsPlot3.BackColor = Color.Transparent;
            formsPlot3.DisplayScale = 1.25F;
            formsPlot3.Location = new Point(691, 0);
            formsPlot3.Name = "formsPlot3";
            formsPlot3.Size = new Size(296, 281);
            formsPlot3.TabIndex = 18;
            // 
            // DashboardScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DashboardScreen";
            Size = new Size(987, 648);
            Load += DashboardScreen_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Panel panel1;
        private ProgressBar SavingsProgressBar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel2;
        private ScottPlot.WinForms.FormsPlot formsPlot3;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
    }
}
