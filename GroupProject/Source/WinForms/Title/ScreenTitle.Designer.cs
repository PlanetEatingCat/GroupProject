namespace BudgetPlanner
{
    partial class ScreenTitle
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
            HomeMenuButton = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // HomeMenuButton
            // 
            HomeMenuButton.Dock = DockStyle.Top;
            HomeMenuButton.FlatAppearance.BorderSize = 0;
            HomeMenuButton.FlatStyle = FlatStyle.Flat;
            HomeMenuButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeMenuButton.ForeColor = Color.White;
            HomeMenuButton.IconChar = FontAwesome.Sharp.IconChar.House;
            HomeMenuButton.IconColor = Color.White;
            HomeMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HomeMenuButton.IconSize = 30;
            HomeMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            HomeMenuButton.Location = new Point(0, 0);
            HomeMenuButton.Margin = new Padding(3, 4, 3, 4);
            HomeMenuButton.Name = "HomeMenuButton";
            HomeMenuButton.Size = new Size(232, 46);
            HomeMenuButton.TabIndex = 3;
            HomeMenuButton.Tag = "Home";
            HomeMenuButton.Text = "Home";
            HomeMenuButton.TextAlign = ContentAlignment.MiddleLeft;
            HomeMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            HomeMenuButton.UseVisualStyleBackColor = true;
            HomeMenuButton.Click += HomeMenuButton_Click;
            // 
            // ScreenTitle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(HomeMenuButton);
            Name = "ScreenTitle";
            Size = new Size(232, 55);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton HomeMenuButton;
    }
}
