namespace BudgetPlanner
{
    partial class IncomeScreen
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
            IncomeLbl = new Label();
            AmountTxtBx = new TextBox();
            IncomeLblSmall = new Label();
            NameTxtBx = new TextBox();
            NameLbl = new Label();
            FrequencyLbl = new Label();
            ConfirmButton = new Button();
            CurrentIncomeLbl = new Label();
            FrequencyComboBx = new ComboBox();
            SuspendLayout();
            // 
            // IncomeLbl
            // 
            IncomeLbl.AutoSize = true;
            IncomeLbl.Font = new Font("Segoe UI", 24F);
            IncomeLbl.Location = new Point(460, 99);
            IncomeLbl.Name = "IncomeLbl";
            IncomeLbl.Size = new Size(153, 54);
            IncomeLbl.TabIndex = 0;
            IncomeLbl.Text = "Income";
            // 
            // AmountTxtBx
            // 
            AmountTxtBx.Location = new Point(237, 204);
            AmountTxtBx.Name = "AmountTxtBx";
            AmountTxtBx.Size = new Size(125, 27);
            AmountTxtBx.TabIndex = 1;
            // 
            // IncomeLblSmall
            // 
            IncomeLblSmall.AutoSize = true;
            IncomeLblSmall.Location = new Point(273, 262);
            IncomeLblSmall.Name = "IncomeLblSmall";
            IncomeLblSmall.Size = new Size(58, 20);
            IncomeLblSmall.TabIndex = 2;
            IncomeLblSmall.Text = "Income";
            IncomeLblSmall.Click += IncomeLblSmall_Click;
            // 
            // NameTxtBx
            // 
            NameTxtBx.Location = new Point(710, 204);
            NameTxtBx.Name = "NameTxtBx";
            NameTxtBx.Size = new Size(125, 27);
            NameTxtBx.TabIndex = 3;
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(746, 262);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(49, 20);
            NameLbl.TabIndex = 4;
            NameLbl.Text = "Name";
            // 
            // FrequencyLbl
            // 
            FrequencyLbl.AutoSize = true;
            FrequencyLbl.Location = new Point(499, 262);
            FrequencyLbl.Name = "FrequencyLbl";
            FrequencyLbl.Size = new Size(76, 20);
            FrequencyLbl.TabIndex = 5;
            FrequencyLbl.Text = "Frequency";
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(490, 333);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(94, 29);
            ConfirmButton.TabIndex = 7;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // CurrentIncomeLbl
            // 
            CurrentIncomeLbl.AutoSize = true;
            CurrentIncomeLbl.Location = new Point(411, 409);
            CurrentIncomeLbl.Name = "CurrentIncomeLbl";
            CurrentIncomeLbl.Size = new Size(263, 20);
            CurrentIncomeLbl.TabIndex = 8;
            CurrentIncomeLbl.Text = "Current Income for xxx is set to xxx xxx";
            // 
            // FrequencyComboBx
            // 
            FrequencyComboBx.AutoCompleteCustomSource.AddRange(new string[] { "Daily", "Monthly", "EveryTwoMonths", "Yearly" });
            FrequencyComboBx.FormattingEnabled = true;
            FrequencyComboBx.Items.AddRange(new object[] { "Daily", "Monthly", "EveryTwoMonths", "Yearly" });
            FrequencyComboBx.Location = new Point(462, 204);
            FrequencyComboBx.Name = "FrequencyComboBx";
            FrequencyComboBx.Size = new Size(151, 28);
            FrequencyComboBx.TabIndex = 9;
            // 
            // IncomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(FrequencyComboBx);
            Controls.Add(CurrentIncomeLbl);
            Controls.Add(ConfirmButton);
            Controls.Add(FrequencyLbl);
            Controls.Add(NameLbl);
            Controls.Add(NameTxtBx);
            Controls.Add(IncomeLblSmall);
            Controls.Add(AmountTxtBx);
            Controls.Add(IncomeLbl);
            Margin = new Padding(2);
            Name = "IncomeScreen";
            Size = new Size(987, 648);
            Load += IncomeScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IncomeLbl;
        private TextBox AmountTxtBx;
        private Label IncomeLblSmall;
        private TextBox NameTxtBx;
        private Label NameLbl;
        private Label FrequencyLbl;
        private Button ConfirmButton;
        private Label CurrentIncomeLbl;
        private ComboBox FrequencyComboBx;
    }
}
