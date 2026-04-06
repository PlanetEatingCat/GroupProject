namespace BudgetPlanner
{
    partial class AccountTitle
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
            AccountIcon = new FontAwesome.Sharp.IconPictureBox();
            AccountOptionsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AccountIcon).BeginInit();
            SuspendLayout();
            // 
            // AccountOptionsMenu
            // 
            AccountOptionsMenu.BackColor = SystemColors.ActiveCaption;
            AccountOptionsMenu.ImageScalingSize = new Size(20, 20);
            AccountOptionsMenu.Items.AddRange(new ToolStripItem[] { signOutToolStripMenuItem, settingsToolStripMenuItem });
            AccountOptionsMenu.Name = "contextMenuStrip1";
            AccountOptionsMenu.ShowImageMargin = false;
            AccountOptionsMenu.Size = new Size(186, 80);
            AccountOptionsMenu.Opening += AccountOptionsMenu_Opening;
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.ForeColor = Color.White;
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(185, 24);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.ForeColor = Color.White;
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(185, 24);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
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
            AccountOptionsButton.TextAlign = ContentAlignment.MiddleLeft;
            AccountOptionsButton.UseVisualStyleBackColor = false;
            AccountOptionsButton.Click += AccountOptionsButton_Click;
            // 
            // AccountIcon
            // 
            AccountIcon.BackColor = SystemColors.Control;
            AccountIcon.Dock = DockStyle.Left;
            AccountIcon.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            AccountIcon.IconColor = Color.White;
            AccountIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AccountIcon.IconSize = 55;
            AccountIcon.Location = new Point(0, 0);
            AccountIcon.Name = "AccountIcon";
            AccountIcon.Size = new Size(55, 55);
            AccountIcon.TabIndex = 2;
            AccountIcon.TabStop = false;
            // 
            // AccountTitle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AccountOptionsButton);
            Controls.Add(AccountIcon);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AccountTitle";
            Size = new Size(169, 55);
            Load += RightMenuBar_Load;
            AccountOptionsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AccountIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip AccountOptionsMenu;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Button AccountOptionsButton;
        private FontAwesome.Sharp.IconPictureBox AccountIcon;
    }
}
