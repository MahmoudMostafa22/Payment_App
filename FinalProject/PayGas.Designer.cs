
namespace FinalProject
{
    partial class PayGas_Form
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
            this.Proceed_Button = new System.Windows.Forms.Button();
            this.Home_Button = new System.Windows.Forms.Button();
            this.PayG_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CG_Button = new System.Windows.Forms.Button();
            this.NewRG_TextBox = new System.Windows.Forms.TextBox();
            this.OldRG_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VisaG_RB = new System.Windows.Forms.RadioButton();
            this.CashG_RB = new System.Windows.Forms.RadioButton();
            this.ErrorsLabel = new System.Windows.Forms.Label();
            this.VisaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Choose Payment Method";
            // 
            // Proceed_Button
            // 
            this.Proceed_Button.Location = new System.Drawing.Point(274, 347);
            this.Proceed_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Proceed_Button.Name = "Proceed_Button";
            this.Proceed_Button.Size = new System.Drawing.Size(94, 23);
            this.Proceed_Button.TabIndex = 28;
            this.Proceed_Button.Text = "Proceed";
            this.Proceed_Button.UseVisualStyleBackColor = true;
            // 
            // Home_Button
            // 
            this.Home_Button.Location = new System.Drawing.Point(21, 347);
            this.Home_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Size = new System.Drawing.Size(94, 23);
            this.Home_Button.TabIndex = 27;
            this.Home_Button.Text = "Home";
            this.Home_Button.UseVisualStyleBackColor = true;
            this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
            // 
            // PayG_Label
            // 
            this.PayG_Label.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.PayG_Label.Location = new System.Drawing.Point(113, 160);
            this.PayG_Label.Name = "PayG_Label";
            this.PayG_Label.Size = new System.Drawing.Size(169, 54);
            this.PayG_Label.TabIndex = 26;
            this.PayG_Label.Text = "         ";
            this.PayG_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Your Bill is:";
            // 
            // CG_Button
            // 
            this.CG_Button.Location = new System.Drawing.Point(254, 74);
            this.CG_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CG_Button.Name = "CG_Button";
            this.CG_Button.Size = new System.Drawing.Size(94, 23);
            this.CG_Button.TabIndex = 24;
            this.CG_Button.Text = "Calculate";
            this.CG_Button.UseVisualStyleBackColor = true;
            this.CG_Button.Click += new System.EventHandler(this.CG_Button_Click);
            // 
            // NewRG_TextBox
            // 
            this.NewRG_TextBox.Location = new System.Drawing.Point(25, 108);
            this.NewRG_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewRG_TextBox.Name = "NewRG_TextBox";
            this.NewRG_TextBox.Size = new System.Drawing.Size(200, 22);
            this.NewRG_TextBox.TabIndex = 23;
            // 
            // OldRG_TextBox
            // 
            this.OldRG_TextBox.Location = new System.Drawing.Point(25, 48);
            this.OldRG_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OldRG_TextBox.Name = "OldRG_TextBox";
            this.OldRG_TextBox.Size = new System.Drawing.Size(200, 22);
            this.OldRG_TextBox.TabIndex = 22;
            this.OldRG_TextBox.TextChanged += new System.EventHandler(this.OldRG_TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Enter Your New Reading ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Enter Your Old Reading";
            // 
            // VisaG_RB
            // 
            this.VisaG_RB.AutoSize = true;
            this.VisaG_RB.Location = new System.Drawing.Point(21, 265);
            this.VisaG_RB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisaG_RB.Name = "VisaG_RB";
            this.VisaG_RB.Size = new System.Drawing.Size(100, 21);
            this.VisaG_RB.TabIndex = 19;
            this.VisaG_RB.TabStop = true;
            this.VisaG_RB.Text = "Credit Card";
            this.VisaG_RB.UseVisualStyleBackColor = true;
            this.VisaG_RB.CheckedChanged += new System.EventHandler(this.VisaG_RB_CheckedChanged);
            // 
            // CashG_RB
            // 
            this.CashG_RB.AutoSize = true;
            this.CashG_RB.Location = new System.Drawing.Point(274, 265);
            this.CashG_RB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CashG_RB.Name = "CashG_RB";
            this.CashG_RB.Size = new System.Drawing.Size(61, 21);
            this.CashG_RB.TabIndex = 18;
            this.CashG_RB.TabStop = true;
            this.CashG_RB.Text = "Cash";
            this.CashG_RB.UseVisualStyleBackColor = true;
            // 
            // ErrorsLabel
            // 
            this.ErrorsLabel.AutoSize = true;
            this.ErrorsLabel.Location = new System.Drawing.Point(26, 318);
            this.ErrorsLabel.Name = "ErrorsLabel";
            this.ErrorsLabel.Size = new System.Drawing.Size(56, 17);
            this.ErrorsLabel.TabIndex = 31;
            this.ErrorsLabel.Text = "            ";
            // 
            // VisaTextBox
            // 
            this.VisaTextBox.Location = new System.Drawing.Point(21, 287);
            this.VisaTextBox.Name = "VisaTextBox";
            this.VisaTextBox.Size = new System.Drawing.Size(342, 22);
            this.VisaTextBox.TabIndex = 30;
            // 
            // PayGas_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 381);
            this.Controls.Add(this.ErrorsLabel);
            this.Controls.Add(this.VisaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Proceed_Button);
            this.Controls.Add(this.Home_Button);
            this.Controls.Add(this.PayG_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CG_Button);
            this.Controls.Add(this.NewRG_TextBox);
            this.Controls.Add(this.OldRG_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VisaG_RB);
            this.Controls.Add(this.CashG_RB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PayGas_Form";
            this.Text = "Charge your Gas";
            this.Load += new System.EventHandler(this.PayGas_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Proceed_Button;
        private System.Windows.Forms.Button Home_Button;
        private System.Windows.Forms.Label PayG_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CG_Button;
        private System.Windows.Forms.TextBox NewRG_TextBox;
        private System.Windows.Forms.TextBox OldRG_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton VisaG_RB;
        private System.Windows.Forms.RadioButton CashG_RB;
        private System.Windows.Forms.Label ErrorsLabel;
        private System.Windows.Forms.TextBox VisaTextBox;
    }
}