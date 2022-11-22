
namespace FinalProject
{
    partial class Electricity_Form
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
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.CalCBillElec_RB = new System.Windows.Forms.RadioButton();
            this.PayElec_RB = new System.Windows.Forms.RadioButton();
            this.CElec_RB = new System.Windows.Forms.RadioButton();
            this.Proceed_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.ChooseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Location = new System.Drawing.Point(14, 12);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(301, 20);
            this.CompanyLabel.TabIndex = 0;
            this.CompanyLabel.Text = "Alexandria Electricity Distrubution Company";
            // 
            // CalCBillElec_RB
            // 
            this.CalCBillElec_RB.AutoSize = true;
            this.CalCBillElec_RB.Location = new System.Drawing.Point(27, 100);
            this.CalCBillElec_RB.Name = "CalCBillElec_RB";
            this.CalCBillElec_RB.Size = new System.Drawing.Size(149, 24);
            this.CalCBillElec_RB.TabIndex = 1;
            this.CalCBillElec_RB.TabStop = true;
            this.CalCBillElec_RB.Text = "Calculate Your Bill";
            this.CalCBillElec_RB.UseVisualStyleBackColor = true;
            // 
            // PayElec_RB
            // 
            this.PayElec_RB.AutoSize = true;
            this.PayElec_RB.Location = new System.Drawing.Point(27, 130);
            this.PayElec_RB.Name = "PayElec_RB";
            this.PayElec_RB.Size = new System.Drawing.Size(110, 24);
            this.PayElec_RB.TabIndex = 3;
            this.PayElec_RB.TabStop = true;
            this.PayElec_RB.Text = "Pay Your Bill";
            this.PayElec_RB.UseVisualStyleBackColor = true;
            // 
            // CElec_RB
            // 
            this.CElec_RB.AutoSize = true;
            this.CElec_RB.Location = new System.Drawing.Point(27, 160);
            this.CElec_RB.Name = "CElec_RB";
            this.CElec_RB.Size = new System.Drawing.Size(145, 24);
            this.CElec_RB.TabIndex = 4;
            this.CElec_RB.TabStop = true;
            this.CElec_RB.Text = "Charge Your Card";
            this.CElec_RB.UseVisualStyleBackColor = true;
            // 
            // Proceed_Button
            // 
            this.Proceed_Button.Location = new System.Drawing.Point(217, 231);
            this.Proceed_Button.Name = "Proceed_Button";
            this.Proceed_Button.Size = new System.Drawing.Size(94, 29);
            this.Proceed_Button.TabIndex = 5;
            this.Proceed_Button.Text = "Proceed";
            this.Proceed_Button.UseVisualStyleBackColor = true;
            this.Proceed_Button.Click += new System.EventHandler(this.Proceed_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(14, 231);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(94, 29);
            this.Back_Button.TabIndex = 6;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            // 
            // ChooseLabel
            // 
            this.ChooseLabel.AutoSize = true;
            this.ChooseLabel.Location = new System.Drawing.Point(14, 66);
            this.ChooseLabel.Name = "ChooseLabel";
            this.ChooseLabel.Size = new System.Drawing.Size(142, 20);
            this.ChooseLabel.TabIndex = 7;
            this.ChooseLabel.Text = "Choose Your Service";
            // 
            // Electricity_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 276);
            this.Controls.Add(this.ChooseLabel);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Proceed_Button);
            this.Controls.Add(this.CElec_RB);
            this.Controls.Add(this.PayElec_RB);
            this.Controls.Add(this.CalCBillElec_RB);
            this.Controls.Add(this.CompanyLabel);
            this.Name = "Electricity_Form";
            this.Text = "Electricity";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.RadioButton CalCBillElec_RB;
        private System.Windows.Forms.RadioButton PayElec_RB;
        private System.Windows.Forms.RadioButton CElec_RB;
        private System.Windows.Forms.Button Proceed_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label ChooseLabel;
    }
}

