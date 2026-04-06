namespace BudgetPlanner
{
    partial class ThemeScreen
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
            colorDialog1 = new ColorDialog();
            BackgroundEdit = new ThemeEdit();
            SurfaceEdit = new ThemeEdit();
            InfoColorLabel = new Label();
            Subheading1 = new Label();
            Description1 = new Label();
            label1 = new Label();
            label2 = new Label();
            ComplimentEdit = new ThemeEdit();
            AccentEdit = new ThemeEdit();
            SiblingEdit = new ThemeEdit();
            TwinComplimentEdit = new ThemeEdit();
            label3 = new Label();
            label4 = new Label();
            SoulAccentEdit = new ThemeEdit();
            ExtraEdit = new ThemeEdit();
            label5 = new Label();
            label6 = new Label();
            ActiveEdit = new ThemeEdit();
            BorderEdit = new ThemeEdit();
            EditorPanel = new Panel();
            label9 = new Label();
            NameInput = new TextBox();
            label8 = new Label();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label7 = new Label();
            CreateThemeButton = new Button();
            EditorPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BackgroundEdit
            // 
            BackgroundEdit.DarkModeElement = ThemeColorElement.Background;
            BackgroundEdit.Location = new Point(6, 289);
            BackgroundEdit.Margin = new Padding(4);
            BackgroundEdit.Name = "BackgroundEdit";
            BackgroundEdit.Size = new Size(259, 163);
            BackgroundEdit.TabIndex = 0;
            BackgroundEdit.ThemeLabel = "Background";
            // 
            // SurfaceEdit
            // 
            SurfaceEdit.DarkModeElement = ThemeColorElement.Surface;
            SurfaceEdit.Location = new Point(323, 289);
            SurfaceEdit.Margin = new Padding(4);
            SurfaceEdit.Name = "SurfaceEdit";
            SurfaceEdit.Size = new Size(255, 163);
            SurfaceEdit.TabIndex = 1;
            SurfaceEdit.ThemeLabel = "Surface";
            // 
            // InfoColorLabel
            // 
            InfoColorLabel.AutoSize = true;
            InfoColorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InfoColorLabel.ForeColor = Color.White;
            InfoColorLabel.Location = new Point(6, 147);
            InfoColorLabel.Name = "InfoColorLabel";
            InfoColorLabel.Size = new Size(62, 28);
            InfoColorLabel.TabIndex = 2;
            InfoColorLabel.Text = "Color";
            // 
            // Subheading1
            // 
            Subheading1.AutoSize = true;
            Subheading1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subheading1.ForeColor = Color.White;
            Subheading1.Location = new Point(6, 194);
            Subheading1.Name = "Subheading1";
            Subheading1.Size = new Size(225, 20);
            Subheading1.TabIndex = 3;
            Subheading1.Text = "Background and Surface colors";
            // 
            // Description1
            // 
            Description1.AutoSize = true;
            Description1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Description1.ForeColor = Color.White;
            Description1.Location = new Point(6, 226);
            Description1.Name = "Description1";
            Description1.Size = new Size(603, 60);
            Description1.TabIndex = 4;
            Description1.Text = "The background color is the the color behind most panels and the surface color is a slight \r\nvariation of the background color for display panels.\r\n\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 799);
            label1.Name = "label1";
            label1.Size = new Size(583, 80);
            label1.TabIndex = 8;
            label1.Text = "The accent is the main color that goes with the background and surface colors. And the\r\ncompliment is a similar color the surface color.\r\n\r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 764);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 7;
            label2.Text = "Accent Colors";
            // 
            // ComplimentEdit
            // 
            ComplimentEdit.DarkModeElement = ThemeColorElement.Compliment;
            ComplimentEdit.Location = new Point(323, 862);
            ComplimentEdit.Margin = new Padding(4);
            ComplimentEdit.Name = "ComplimentEdit";
            ComplimentEdit.Size = new Size(255, 163);
            ComplimentEdit.TabIndex = 6;
            ComplimentEdit.ThemeLabel = "Compliment";
            // 
            // AccentEdit
            // 
            AccentEdit.DarkModeElement = ThemeColorElement.Accent;
            AccentEdit.Location = new Point(6, 862);
            AccentEdit.Margin = new Padding(4);
            AccentEdit.Name = "AccentEdit";
            AccentEdit.Size = new Size(259, 163);
            AccentEdit.TabIndex = 5;
            AccentEdit.ThemeLabel = "Accent";
            // 
            // SiblingEdit
            // 
            SiblingEdit.DarkModeElement = ThemeColorElement.Sibling;
            SiblingEdit.Location = new Point(323, 1119);
            SiblingEdit.Margin = new Padding(4);
            SiblingEdit.Name = "SiblingEdit";
            SiblingEdit.Size = new Size(255, 163);
            SiblingEdit.TabIndex = 10;
            SiblingEdit.ThemeLabel = "Sibling";
            // 
            // TwinComplimentEdit
            // 
            TwinComplimentEdit.DarkModeElement = ThemeColorElement.TwinCompliment;
            TwinComplimentEdit.Location = new Point(6, 1119);
            TwinComplimentEdit.Margin = new Padding(4);
            TwinComplimentEdit.Name = "TwinComplimentEdit";
            TwinComplimentEdit.Size = new Size(259, 163);
            TwinComplimentEdit.TabIndex = 9;
            TwinComplimentEdit.ThemeLabel = "Twin Compliment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 1039);
            label3.Name = "label3";
            label3.Size = new Size(615, 100);
            label3.TabIndex = 11;
            label3.Text = "The twin compliment is a color similar to the compliment. And the sibling color is a color of\r\n similar hue (cool/warm) to the background and surface\r\n\r\n\r\n\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 1296);
            label4.Name = "label4";
            label4.Size = new Size(505, 80);
            label4.TabIndex = 14;
            label4.Text = "The extra color is a contrasting color and the Soul Accent is an accent color\r\nthat is close in hue to the background and surface\r\n \r\n\r\n";
            // 
            // SoulAccentEdit
            // 
            SoulAccentEdit.DarkModeElement = ThemeColorElement.SoulAccent;
            SoulAccentEdit.Location = new Point(323, 1375);
            SoulAccentEdit.Margin = new Padding(4);
            SoulAccentEdit.Name = "SoulAccentEdit";
            SoulAccentEdit.Size = new Size(255, 163);
            SoulAccentEdit.TabIndex = 13;
            SoulAccentEdit.ThemeLabel = "Soul Accent";
            // 
            // ExtraEdit
            // 
            ExtraEdit.DarkModeElement = ThemeColorElement.Extra;
            ExtraEdit.Location = new Point(6, 1375);
            ExtraEdit.Margin = new Padding(4);
            ExtraEdit.Name = "ExtraEdit";
            ExtraEdit.Size = new Size(259, 163);
            ExtraEdit.TabIndex = 12;
            ExtraEdit.ThemeLabel = "Extra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(6, 513);
            label5.Name = "label5";
            label5.Size = new Size(434, 80);
            label5.TabIndex = 18;
            label5.Text = "The Border color is the colored border surrounding the window. \r\nThe Active color is the color when a menu item is selected\r\n\r\n\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(6, 481);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 17;
            label6.Text = "Border and Active";
            // 
            // ActiveEdit
            // 
            ActiveEdit.DarkModeElement = ThemeColorElement.Active;
            ActiveEdit.Location = new Point(323, 576);
            ActiveEdit.Margin = new Padding(4);
            ActiveEdit.Name = "ActiveEdit";
            ActiveEdit.Size = new Size(255, 163);
            ActiveEdit.TabIndex = 16;
            ActiveEdit.ThemeLabel = "Active";
            // 
            // BorderEdit
            // 
            BorderEdit.DarkModeElement = ThemeColorElement.Border;
            BorderEdit.Location = new Point(6, 576);
            BorderEdit.Margin = new Padding(4);
            BorderEdit.Name = "BorderEdit";
            BorderEdit.Size = new Size(259, 163);
            BorderEdit.TabIndex = 15;
            BorderEdit.ThemeLabel = "Border";
            // 
            // EditorPanel
            // 
            EditorPanel.AutoScroll = true;
            EditorPanel.Controls.Add(label9);
            EditorPanel.Controls.Add(NameInput);
            EditorPanel.Controls.Add(label8);
            EditorPanel.Controls.Add(BackgroundEdit);
            EditorPanel.Controls.Add(SurfaceEdit);
            EditorPanel.Controls.Add(label6);
            EditorPanel.Controls.Add(InfoColorLabel);
            EditorPanel.Controls.Add(ActiveEdit);
            EditorPanel.Controls.Add(Subheading1);
            EditorPanel.Controls.Add(BorderEdit);
            EditorPanel.Controls.Add(Description1);
            EditorPanel.Controls.Add(label4);
            EditorPanel.Controls.Add(AccentEdit);
            EditorPanel.Controls.Add(SoulAccentEdit);
            EditorPanel.Controls.Add(ComplimentEdit);
            EditorPanel.Controls.Add(ExtraEdit);
            EditorPanel.Controls.Add(label2);
            EditorPanel.Controls.Add(label1);
            EditorPanel.Controls.Add(SiblingEdit);
            EditorPanel.Controls.Add(TwinComplimentEdit);
            EditorPanel.Controls.Add(label3);
            EditorPanel.Controls.Add(label5);
            EditorPanel.Dock = DockStyle.Fill;
            EditorPanel.Location = new Point(250, 0);
            EditorPanel.Name = "EditorPanel";
            EditorPanel.Size = new Size(615, 1567);
            EditorPanel.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(9, 48);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 21;
            label9.Text = "Name";
            // 
            // NameInput
            // 
            NameInput.BackColor = Color.FromArgb(64, 64, 64);
            NameInput.BorderStyle = BorderStyle.None;
            NameInput.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameInput.ForeColor = Color.White;
            NameInput.Location = new Point(9, 81);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(125, 20);
            NameInput.TabIndex = 20;
            NameInput.TextChanged += NameInput_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(6, 9);
            label8.Name = "label8";
            label8.Size = new Size(125, 28);
            label8.TabIndex = 19;
            label8.Text = "Information";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(CreateThemeButton);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1567);
            panel2.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 28);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 1484);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(139, 28);
            label7.TabIndex = 1;
            label7.Text = "Select Theme";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreateThemeButton
            // 
            CreateThemeButton.BackColor = SystemColors.MenuHighlight;
            CreateThemeButton.Dock = DockStyle.Bottom;
            CreateThemeButton.FlatAppearance.BorderSize = 0;
            CreateThemeButton.FlatStyle = FlatStyle.Flat;
            CreateThemeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateThemeButton.ForeColor = Color.White;
            CreateThemeButton.Location = new Point(0, 1512);
            CreateThemeButton.Name = "CreateThemeButton";
            CreateThemeButton.Size = new Size(250, 55);
            CreateThemeButton.TabIndex = 0;
            CreateThemeButton.Text = "New Theme";
            CreateThemeButton.UseVisualStyleBackColor = false;
            CreateThemeButton.Click += CreateThemeButton_Click;
            // 
            // ThemeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(EditorPanel);
            Controls.Add(panel2);
            Name = "ThemeScreen";
            Size = new Size(865, 1567);
            EditorPanel.ResumeLayout(false);
            EditorPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ColorDialog colorDialog1;
        private BudgetPlanner.ThemeEdit BackgroundEdit;
        private BudgetPlanner.ThemeEdit SurfaceEdit;
        private Label InfoColorLabel;
        private Label Subheading1;
        private Label Description1;
        private Label label1;
        private Label label2;
        private BudgetPlanner.ThemeEdit ComplimentEdit;
        private BudgetPlanner.ThemeEdit AccentEdit;
        private BudgetPlanner.ThemeEdit SiblingEdit;
        private BudgetPlanner.ThemeEdit TwinComplimentEdit;
        private Label label3;
        private Label label4;
        private BudgetPlanner.ThemeEdit SoulAccentEdit;
        private BudgetPlanner.ThemeEdit ExtraEdit;
        private Label label5;
        private Label label6;
        private BudgetPlanner.ThemeEdit ActiveEdit;
        private BudgetPlanner.ThemeEdit BorderEdit;
        private Panel EditorPanel;
        private Panel panel2;
        private Button CreateThemeButton;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox NameInput;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
