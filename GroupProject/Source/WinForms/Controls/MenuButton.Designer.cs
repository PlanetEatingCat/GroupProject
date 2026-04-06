namespace BudgetPlanner
{
    partial class MenuButton
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
            MenuIconButton = new FontAwesome.Sharp.IconButton();
            ActiveImageBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ActiveImageBox).BeginInit();
            SuspendLayout();
            // 
            // MenuIconButton
            // 
            MenuIconButton.BackColor = Color.Transparent;
            MenuIconButton.Dock = DockStyle.Fill;
            MenuIconButton.FlatAppearance.BorderSize = 0;
            MenuIconButton.FlatStyle = FlatStyle.Flat;
            MenuIconButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuIconButton.ForeColor = Color.White;
            MenuIconButton.IconChar = FontAwesome.Sharp.IconChar.House;
            MenuIconButton.IconColor = Color.White;
            MenuIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuIconButton.IconSize = 30;
            MenuIconButton.ImageAlign = ContentAlignment.MiddleLeft;
            MenuIconButton.Location = new Point(10, 0);
            MenuIconButton.Margin = new Padding(3, 4, 3, 4);
            MenuIconButton.Name = "MenuIconButton";
            MenuIconButton.Size = new Size(220, 46);
            MenuIconButton.TabIndex = 3;
            MenuIconButton.Tag = "Home";
            MenuIconButton.Text = "Home";
            MenuIconButton.TextAlign = ContentAlignment.MiddleLeft;
            MenuIconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            MenuIconButton.UseVisualStyleBackColor = false;
            // 
            // ActiveImageBox
            // 
            ActiveImageBox.BackColor = Color.White;
            ActiveImageBox.Dock = DockStyle.Left;
            ActiveImageBox.Enabled = false;
            ActiveImageBox.Location = new Point(0, 0);
            ActiveImageBox.Name = "ActiveImageBox";
            ActiveImageBox.Size = new Size(10, 46);
            ActiveImageBox.TabIndex = 4;
            ActiveImageBox.TabStop = false;
            // 
            // MenuButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            Controls.Add(MenuIconButton);
            Controls.Add(ActiveImageBox);
            Name = "MenuButton";
            Size = new Size(230, 46);
            Paint += MenuButton_Paint;
            ((System.ComponentModel.ISupportInitialize)ActiveImageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton MenuIconButton;
        private PictureBox ActiveImageBox;
    }
}
