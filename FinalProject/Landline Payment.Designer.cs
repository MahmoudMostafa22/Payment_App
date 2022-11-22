
namespace FinalProject
{
    partial class Landline_Payment
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PayLandLine_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VisaLandLine_RB = new System.Windows.Forms.RadioButton();
            this.CashLandLine_RB = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.Proceed_Button = new System.Windows.Forms.Button();
            this.VisaTextBox = new System.Windows.Forms.TextBox();
            this.ErrorsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "500 Minutes Plan (25 Pounds)",
            "1000 Minutes Plan ( 40 Pounds)",
            "2000 Minutes Plan (60 Pounds)",
            "3000 Minutes Plan (100 Pounds)"});
            this.listBox1.Location = new System.Drawing.Point(12, 52);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(375, 100);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Your Plan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Choose Payment Method";
            // 
            // PayLandLine_Label
            // 
            this.PayLandLine_Label.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.PayLandLine_Label.Location = new System.Drawing.Point(95, 174);
            this.PayLandLine_Label.Name = "PayLandLine_Label";
            this.PayLandLine_Label.Size = new System.Drawing.Size(169, 54);
            this.PayLandLine_Label.TabIndex = 21;
            this.PayLandLine_Label.Text = "            ";
            this.PayLandLine_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PayLandLine_Label.Click += new System.EventHandler(this.PayLandLine_Label_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Your Bill is:";
            // 
            // VisaLandLine_RB
            // 
            this.VisaLandLine_RB.AutoSize = true;
            this.VisaLandLine_RB.Location = new System.Drawing.Point(9, 369);
            this.VisaLandLine_RB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisaLandLine_RB.Name = "VisaLandLine_RB";
            this.VisaLandLine_RB.Size = new System.Drawing.Size(100, 21);
            this.VisaLandLine_RB.TabIndex = 19;
            this.VisaLandLine_RB.TabStop = true;
            this.VisaLandLine_RB.Text = "Credit Card";
            this.VisaLandLine_RB.UseVisualStyleBackColor = true;
            this.VisaLandLine_RB.CheckedChanged += new System.EventHandler(this.VisaLandLine_RB_CheckedChanged);
            // 
            // CashLandLine_RB
            // 
            this.CashLandLine_RB.AutoSize = true;
            this.CashLandLine_RB.Location = new System.Drawing.Point(290, 369);
            this.CashLandLine_RB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CashLandLine_RB.Name = "CashLandLine_RB";
            this.CashLandLine_RB.Size = new System.Drawing.Size(61, 21);
            this.CashLandLine_RB.TabIndex = 18;
            this.CashLandLine_RB.TabStop = true;
            this.CashLandLine_RB.Text = "Cash";
            this.CashLandLine_RB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 454);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Proceed_Button
            // 
            this.Proceed_Button.Location = new System.Drawing.Point(293, 454);
            this.Proceed_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Proceed_Button.Name = "Proceed_Button";
            this.Proceed_Button.Size = new System.Drawing.Size(94, 23);
            this.Proceed_Button.TabIndex = 24;
            this.Proceed_Button.Text = "Proceed";
            this.Proceed_Button.UseVisualStyleBackColor = true;
            this.Proceed_Button.Click += new System.EventHandler(this.Proceed_Button_Click);
            // 
            // VisaTextBox
            // 
            this.VisaTextBox.Location = new System.Drawing.Point(9, 395);
            this.VisaTextBox.Name = "VisaTextBox";
            this.VisaTextBox.Size = new System.Drawing.Size(342, 22);
            this.VisaTextBox.TabIndex = 25;
            // 
            // ErrorsLabel
            // 
            this.ErrorsLabel.AutoSize = true;
            this.ErrorsLabel.Location = new System.Drawing.Point(14, 426);
            this.ErrorsLabel.Name = "ErrorsLabel";
            this.ErrorsLabel.Size = new System.Drawing.Size(56, 17);
            this.ErrorsLabel.TabIndex = 26;
            this.ErrorsLabel.Text = "            ";
            // 
            // Landline_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 489);
            this.Controls.Add(this.ErrorsLabel);
            this.Controls.Add(this.VisaTextBox);
            this.Controls.Add(this.Proceed_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PayLandLine_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VisaLandLine_RB);
            this.Controls.Add(this.CashLandLine_RB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Landline_Payment";
            this.Text = "Landline_Payment";
            this.Load += new System.EventHandler(this.Landline_Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PayLandLine_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton VisaLandLine_RB;
        private System.Windows.Forms.RadioButton CashLandLine_RB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Proceed_Button;
        private System.Windows.Forms.TextBox VisaTextBox;
        private System.Windows.Forms.Label ErrorsLabel;
    }
}