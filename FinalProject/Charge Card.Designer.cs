
namespace FinalProject
{
    partial class Charge_Card
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
            this.label4 = new System.Windows.Forms.Label();
            this.VisaElec_RB = new System.Windows.Forms.RadioButton();
            this.CashElec_RB = new System.Windows.Forms.RadioButton();
            this.MembershipNo_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Confirm_Button = new System.Windows.Forms.Button();
            this.ChargeValue_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Choose Payment Method";
            // 
            // VisaElec_RB
            // 
            this.VisaElec_RB.AutoSize = true;
            this.VisaElec_RB.Location = new System.Drawing.Point(9, 238);
            this.VisaElec_RB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisaElec_RB.Name = "VisaElec_RB";
            this.VisaElec_RB.Size = new System.Drawing.Size(100, 21);
            this.VisaElec_RB.TabIndex = 40;
            this.VisaElec_RB.TabStop = true;
            this.VisaElec_RB.Text = "Credit Card";
            this.VisaElec_RB.UseVisualStyleBackColor = true;
            // 
            // CashElec_RB
            // 
            this.CashElec_RB.AutoSize = true;
            this.CashElec_RB.Location = new System.Drawing.Point(176, 238);
            this.CashElec_RB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CashElec_RB.Name = "CashElec_RB";
            this.CashElec_RB.Size = new System.Drawing.Size(61, 21);
            this.CashElec_RB.TabIndex = 39;
            this.CashElec_RB.TabStop = true;
            this.CashElec_RB.Text = "Cash";
            this.CashElec_RB.UseVisualStyleBackColor = true;
            // 
            // MembershipNo_TextBox
            // 
            this.MembershipNo_TextBox.Location = new System.Drawing.Point(12, 61);
            this.MembershipNo_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MembershipNo_TextBox.Name = "MembershipNo_TextBox";
            this.MembershipNo_TextBox.Size = new System.Drawing.Size(256, 22);
            this.MembershipNo_TextBox.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Enter Your Membership Number ";
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.Location = new System.Drawing.Point(174, 294);
            this.Confirm_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(94, 23);
            this.Confirm_Button.TabIndex = 36;
            this.Confirm_Button.Text = "Confirm";
            this.Confirm_Button.UseVisualStyleBackColor = true;
            // 
            // ChargeValue_TextBox
            // 
            this.ChargeValue_TextBox.Location = new System.Drawing.Point(12, 148);
            this.ChargeValue_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChargeValue_TextBox.Name = "ChargeValue_TextBox";
            this.ChargeValue_TextBox.Size = new System.Drawing.Size(256, 22);
            this.ChargeValue_TextBox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Enter Your Charge Value ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 294);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Charge_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 338);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VisaElec_RB);
            this.Controls.Add(this.CashElec_RB);
            this.Controls.Add(this.MembershipNo_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.ChargeValue_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Charge_Card";
            this.Text = "Charge_Card";
            this.Load += new System.EventHandler(this.Charge_Card_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton VisaElec_RB;
        private System.Windows.Forms.RadioButton CashElec_RB;
        private System.Windows.Forms.TextBox MembershipNo_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Confirm_Button;
        private System.Windows.Forms.TextBox ChargeValue_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}