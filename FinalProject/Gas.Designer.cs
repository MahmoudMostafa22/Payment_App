
namespace FinalProject
{
    partial class Gas_Form
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
            this.ChooseLabel = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Proceed_Button = new System.Windows.Forms.Button();
            this.CGas_RB = new System.Windows.Forms.RadioButton();
            this.PayGas_RB = new System.Windows.Forms.RadioButton();
            this.CalCBillGas_RB = new System.Windows.Forms.RadioButton();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseLabel
            // 
            this.ChooseLabel.AutoSize = true;
            this.ChooseLabel.Location = new System.Drawing.Point(12, 75);
            this.ChooseLabel.Name = "ChooseLabel";
            this.ChooseLabel.Size = new System.Drawing.Size(142, 20);
            this.ChooseLabel.TabIndex = 15;
            this.ChooseLabel.Text = "Choose Your Service";
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(12, 240);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(94, 29);
            this.Back_Button.TabIndex = 14;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            // 
            // Proceed_Button
            // 
            this.Proceed_Button.Location = new System.Drawing.Point(142, 240);
            this.Proceed_Button.Name = "Proceed_Button";
            this.Proceed_Button.Size = new System.Drawing.Size(94, 29);
            this.Proceed_Button.TabIndex = 13;
            this.Proceed_Button.Text = "Proceed";
            this.Proceed_Button.UseVisualStyleBackColor = true;
            this.Proceed_Button.Click += new System.EventHandler(this.Proceed_Button_Click);
            // 
            // CGas_RB
            // 
            this.CGas_RB.AutoSize = true;
            this.CGas_RB.Location = new System.Drawing.Point(25, 169);
            this.CGas_RB.Name = "CGas_RB";
            this.CGas_RB.Size = new System.Drawing.Size(135, 24);
            this.CGas_RB.TabIndex = 12;
            this.CGas_RB.TabStop = true;
            this.CGas_RB.Text = "Charge Account";
            this.CGas_RB.UseVisualStyleBackColor = true;
            // 
            // PayGas_RB
            // 
            this.PayGas_RB.AutoSize = true;
            this.PayGas_RB.Location = new System.Drawing.Point(25, 139);
            this.PayGas_RB.Name = "PayGas_RB";
            this.PayGas_RB.Size = new System.Drawing.Size(110, 24);
            this.PayGas_RB.TabIndex = 11;
            this.PayGas_RB.TabStop = true;
            this.PayGas_RB.Text = "Pay Your Bill";
            this.PayGas_RB.UseVisualStyleBackColor = true;
            // 
            // CalCBillGas_RB
            // 
            this.CalCBillGas_RB.AutoSize = true;
            this.CalCBillGas_RB.Location = new System.Drawing.Point(25, 109);
            this.CalCBillGas_RB.Name = "CalCBillGas_RB";
            this.CalCBillGas_RB.Size = new System.Drawing.Size(149, 24);
            this.CalCBillGas_RB.TabIndex = 9;
            this.CalCBillGas_RB.TabStop = true;
            this.CalCBillGas_RB.Text = "Calculate Your Bill";
            this.CalCBillGas_RB.UseVisualStyleBackColor = true;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CompanyLabel.Location = new System.Drawing.Point(12, 21);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(142, 20);
            this.CompanyLabel.TabIndex = 8;
            this.CompanyLabel.Text = "Egypt Gas Company";
            // 
            // Gas_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(272, 321);
            this.Controls.Add(this.ChooseLabel);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Proceed_Button);
            this.Controls.Add(this.CGas_RB);
            this.Controls.Add(this.PayGas_RB);
            this.Controls.Add(this.CalCBillGas_RB);
            this.Controls.Add(this.CompanyLabel);
            this.Name = "Gas_Form";
            this.Text = "Gas";
            this.Load += new System.EventHandler(this.Gas_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChooseLabel;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Proceed_Button;
        private System.Windows.Forms.RadioButton CGas_RB;
        private System.Windows.Forms.RadioButton PayGas_RB;
        private System.Windows.Forms.RadioButton CalCBillGas_RB;
        private System.Windows.Forms.Label CompanyLabel;
    }
}

