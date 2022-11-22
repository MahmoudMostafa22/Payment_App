
namespace FinalProject
{
    partial class PayElec_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CashElec_RB = new System.Windows.Forms.RadioButton();
            this.VisaElec_RB = new System.Windows.Forms.RadioButton();
            this.NewRElec_TextBox = new System.Windows.Forms.TextBox();
            this.OldRElec_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CElec_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Pay_Label = new System.Windows.Forms.Label();
            this.Home_Button = new System.Windows.Forms.Button();
            this.Proceed_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CashElec_RB
            // 
            this.CashElec_RB.AutoSize = true;
            this.CashElec_RB.Location = new System.Drawing.Point(271, 264);
            this.CashElec_RB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CashElec_RB.Name = "CashElec_RB";
            this.CashElec_RB.Size = new System.Drawing.Size(61, 21);
            this.CashElec_RB.TabIndex = 0;
            this.CashElec_RB.TabStop = true;
            this.CashElec_RB.Text = "Cash";
            this.CashElec_RB.UseVisualStyleBackColor = true;
            // 
            // VisaElec_RB
            // 
            this.VisaElec_RB.AutoSize = true;
            this.VisaElec_RB.Location = new System.Drawing.Point(18, 264);
            this.VisaElec_RB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisaElec_RB.Name = "VisaElec_RB";
            this.VisaElec_RB.Size = new System.Drawing.Size(100, 21);
            this.VisaElec_RB.TabIndex = 1;
            this.VisaElec_RB.TabStop = true;
            this.VisaElec_RB.Text = "Credit Card";
            this.VisaElec_RB.UseVisualStyleBackColor = true;
            // 
            // NewRElec_TextBox
            // 
            this.NewRElec_TextBox.Location = new System.Drawing.Point(22, 107);
            this.NewRElec_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewRElec_TextBox.Name = "NewRElec_TextBox";
            this.NewRElec_TextBox.Size = new System.Drawing.Size(168, 22);
            this.NewRElec_TextBox.TabIndex = 11;
            // 
            // OldRElec_TextBox
            // 
            this.OldRElec_TextBox.Location = new System.Drawing.Point(22, 47);
            this.OldRElec_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OldRElec_TextBox.Name = "OldRElec_TextBox";
            this.OldRElec_TextBox.Size = new System.Drawing.Size(168, 22);
            this.OldRElec_TextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Your New Reading ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Your Old Reading";
            // 
            // CElec_Button
            // 
            this.CElec_Button.Location = new System.Drawing.Point(251, 74);
            this.CElec_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CElec_Button.Name = "CElec_Button";
            this.CElec_Button.Size = new System.Drawing.Size(94, 23);
            this.CElec_Button.TabIndex = 12;
            this.CElec_Button.Text = "Calculate";
            this.CElec_Button.UseVisualStyleBackColor = true;
            this.CElec_Button.Click += new System.EventHandler(this.CElec_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Your Bill is:";
            // 
            // Pay_Label
            // 
            this.Pay_Label.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.Pay_Label.Location = new System.Drawing.Point(110, 159);
            this.Pay_Label.Name = "Pay_Label";
            this.Pay_Label.Size = new System.Drawing.Size(169, 54);
            this.Pay_Label.TabIndex = 14;
            this.Pay_Label.Text = "          ";
            this.Pay_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home_Button
            // 
            this.Home_Button.Location = new System.Drawing.Point(18, 313);
            this.Home_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Size = new System.Drawing.Size(94, 23);
            this.Home_Button.TabIndex = 15;
            this.Home_Button.Text = "Home";
            this.Home_Button.UseVisualStyleBackColor = true;
            this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
            // 
            // Proceed_Button
            // 
            this.Proceed_Button.Location = new System.Drawing.Point(271, 313);
            this.Proceed_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Proceed_Button.Name = "Proceed_Button";
            this.Proceed_Button.Size = new System.Drawing.Size(94, 23);
            this.Proceed_Button.TabIndex = 16;
            this.Proceed_Button.Text = "Proceed";
            this.Proceed_Button.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Choose Payment Method";
            // 
            // PayElec_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Proceed_Button);
            this.Controls.Add(this.Home_Button);
            this.Controls.Add(this.Pay_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CElec_Button);
            this.Controls.Add(this.NewRElec_TextBox);
            this.Controls.Add(this.OldRElec_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VisaElec_RB);
            this.Controls.Add(this.CashElec_RB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PayElec_Form";
            this.Text = "Pay Your Bill";
            this.Load += new System.EventHandler(this.PayElec_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CashElec_RB;
        private System.Windows.Forms.RadioButton VisaElec_RB;
        private System.Windows.Forms.TextBox NewRElec_TextBox;
        private System.Windows.Forms.TextBox OldRElec_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CElec_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Pay_Label;
        private System.Windows.Forms.Button Home_Button;
        private System.Windows.Forms.Button Proceed_Button;
        private System.Windows.Forms.Label label4;
    }
}