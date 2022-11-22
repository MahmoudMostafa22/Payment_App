
namespace FinalProject
{
    partial class Charge_Account_Form
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChargeValue_TextBox = new System.Windows.Forms.TextBox();
            this.Confirm_Button = new System.Windows.Forms.Button();
            this.MembershipNo_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VisaG_RB = new System.Windows.Forms.RadioButton();
            this.CashG_RB = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 341);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Your Charge Value ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChargeValue_TextBox
            // 
            this.ChargeValue_TextBox.Location = new System.Drawing.Point(12, 230);
            this.ChargeValue_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChargeValue_TextBox.Name = "ChargeValue_TextBox";
            this.ChargeValue_TextBox.Size = new System.Drawing.Size(462, 22);
            this.ChargeValue_TextBox.TabIndex = 3;
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.Location = new System.Drawing.Point(380, 341);
            this.Confirm_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(94, 23);
            this.Confirm_Button.TabIndex = 6;
            this.Confirm_Button.Text = "Confirm";
            this.Confirm_Button.UseVisualStyleBackColor = true;
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
            // 
            // MembershipNo_TextBox
            // 
            this.MembershipNo_TextBox.Location = new System.Drawing.Point(12, 41);
            this.MembershipNo_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MembershipNo_TextBox.Name = "MembershipNo_TextBox";
            this.MembershipNo_TextBox.Size = new System.Drawing.Size(462, 22);
            this.MembershipNo_TextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Your Membership Number ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Choose Payment Method";
            // 
            // VisaG_RB
            // 
            this.VisaG_RB.AutoSize = true;
            this.VisaG_RB.Location = new System.Drawing.Point(12, 304);
            this.VisaG_RB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisaG_RB.Name = "VisaG_RB";
            this.VisaG_RB.Size = new System.Drawing.Size(100, 21);
            this.VisaG_RB.TabIndex = 31;
            this.VisaG_RB.TabStop = true;
            this.VisaG_RB.Text = "Credit Card";
            this.VisaG_RB.UseVisualStyleBackColor = true;
            // 
            // CashG_RB
            // 
            this.CashG_RB.AutoSize = true;
            this.CashG_RB.Location = new System.Drawing.Point(176, 304);
            this.CashG_RB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CashG_RB.Name = "CashG_RB";
            this.CashG_RB.Size = new System.Drawing.Size(61, 21);
            this.CashG_RB.TabIndex = 30;
            this.CashG_RB.TabStop = true;
            this.CashG_RB.Text = "Cash";
            this.CashG_RB.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 81);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Charge_Account_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 373);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VisaG_RB);
            this.Controls.Add(this.CashG_RB);
            this.Controls.Add(this.MembershipNo_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.ChargeValue_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Charge_Account_Form";
            this.Text = "Charge Account";
            this.Load += new System.EventHandler(this.Charge_Account_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ChargeValue_TextBox;
        private System.Windows.Forms.Button Confirm_Button;
        private System.Windows.Forms.TextBox MembershipNo_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton VisaG_RB;
        private System.Windows.Forms.RadioButton CashG_RB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}