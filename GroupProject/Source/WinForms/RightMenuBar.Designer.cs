namespace BudgetPlanner
{
    partial class RightMenuBar
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
            components = new System.ComponentModel.Container();
            AccountOptionsMenu = new ContextMenuStrip(components);
            signOutToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            AccountOptionsButton = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            AccountOptionsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AccountOptionsMenu
            // 
            AccountOptionsMenu.BackColor = SystemColors.ActiveCaption;
            AccountOptionsMenu.ImageScalingSize = new Size(20, 20);
            AccountOptionsMenu.Items.AddRange(new ToolStripItem[] { signOutToolStripMenuItem, settingsToolStripMenuItem });
            AccountOptionsMenu.Name = "contextMenuStrip1";
            AccountOptionsMenu.ShowImageMargin = false;
            AccountOptionsMenu.Size = new Size(111, 52);
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.ForeColor = Color.White;
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(110, 24);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.ForeColor = Color.White;
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(110, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // AccountOptionsButton
            // 
            AccountOptionsButton.BackColor = Color.Transparent;
            AccountOptionsButton.Dock = DockStyle.Left;
            AccountOptionsButton.FlatAppearance.BorderSize = 0;
            AccountOptionsButton.FlatStyle = FlatStyle.Flat;
            AccountOptionsButton.ForeColor = Color.White;
            AccountOptionsButton.Location = new Point(55, 0);
            AccountOptionsButton.Margin = new Padding(3, 4, 3, 4);
            AccountOptionsButton.Name = "AccountOptionsButton";
            AccountOptionsButton.Size = new Size(86, 55);
            AccountOptionsButton.TabIndex = 1;
            AccountOptionsButton.Text = "Superman";
            AccountOptionsButton.UseVisualStyleBackColor = false;
            AccountOptionsButton.Click += AccountOptionsButton_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.Dock = DockStyle.Left;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 55;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(55, 55);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // RightMenuBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AccountOptionsButton);
            Controls.Add(iconPictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RightMenuBar";
            Size = new Size(169, 55);
            Load += RightMenuBar_Load;
            AccountOptionsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip AccountOptionsMenu;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Button AccountOptionsButton;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
