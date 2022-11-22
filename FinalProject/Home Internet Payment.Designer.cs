
namespace FinalProject
{
    partial class Home_Internet_Payment
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
            this.Proceed_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PayInternet_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VisaLandLine_RB = new System.Windows.Forms.RadioButton();
            this.CashLandLine_RB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NetPlans_ListBox = new System.Windows.Forms.ListBox();
            this.VisaTextBox = new System.Windows.Forms.TextBox();
            this.ErrorsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Proceed_Button
            // 
            this.Proceed_Button.Location = new System.Drawing.Point(260, 330);
            this.Proceed_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Proceed_Button.Name = "Proceed_Button";
            this.Proceed_Button.Size = new System.Drawing.Size(94, 23);
            this.Proceed_Button.TabIndex = 33;
            this.Proceed_Button.Text = "Proceed";
            this.Proceed_Button.UseVisualStyleBackColor = true;
            this.Proceed_Button.Click += new System.EventHandler(this.Proceed_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 340);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Choose Payment Method";
            // 
            // PayInternet_Label
            // 
            this.PayInternet_Label.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.PayInternet_Label.Location = new System.Drawing.Point(104, 146);
            this.PayInternet_Label.Name = "PayInternet_Label";
            this.PayInternet_Label.Size = new System.Drawing.Size(169, 54);
            this.PayInternet_Label.TabIndex = 30;
            this.PayInternet_Label.Text = "                 ";
            this.PayInternet_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PayInternet_Label.Click += new System.EventHandler(this.PayInternet_Label_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Your Bill is:";
            // 
            // VisaLandLine_RB
            // 
            this.VisaLandLine_RB.AutoSize = true;
            this.VisaLandLine_RB.Location = new System.Drawing.Point(12, 251);
            this.VisaLandLine_RB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisaLandLine_RB.Name = "VisaLandLine_RB";
            this.VisaLandLine_RB.Size = new System.Drawing.Size(100, 21);
            this.VisaLandLine_RB.TabIndex = 28;
            this.VisaLandLine_RB.TabStop = true;
            this.VisaLandLine_RB.Text = "Credit Card";
            this.VisaLandLine_RB.UseVisualStyleBackColor = true;
            this.VisaLandLine_RB.CheckedChanged += new System.EventHandler(this.VisaLandLine_RB_CheckedChanged);
            // 
            // CashLandLine_RB
            // 
            this.CashLandLine_RB.AutoSize = true;
            this.CashLandLine_RB.Location = new System.Drawing.Point(293, 251);
            this.CashLandLine_RB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CashLandLine_RB.Name = "CashLandLine_RB";
            this.CashLandLine_RB.Size = new System.Drawing.Size(61, 21);
            this.CashLandLine_RB.TabIndex = 27;
            this.CashLandLine_RB.TabStop = true;
            this.CashLandLine_RB.Text = "Cash";
            this.CashLandLine_RB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Choose Your Plan";
            // 
            // NetPlans_ListBox
            // 
            this.NetPlans_ListBox.FormattingEnabled = true;
            this.NetPlans_ListBox.ItemHeight = 16;
            this.NetPlans_ListBox.Items.AddRange(new object[] {
            "140 GigaByte Plan (180 Pounds)",
            "200 GigaByte Plan (200 Pounds)",
            "240 GigaByte Plan (280 Pounds)",
            "280 GigaByte Plan (340 Pounds)"});
            this.NetPlans_ListBox.Location = new System.Drawing.Point(12, 26);
            this.NetPlans_ListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NetPlans_ListBox.Name = "NetPlans_ListBox";
            this.NetPlans_ListBox.Size = new System.Drawing.Size(323, 100);
            this.NetPlans_ListBox.TabIndex = 25;
            this.NetPlans_ListBox.SelectedIndexChanged += new System.EventHandler(this.NetPlans_ListBox_SelectedIndexChanged);
            // 
            // VisaTextBox
            // 
            this.VisaTextBox.Location = new System.Drawing.Point(12, 290);
            this.VisaTextBox.Name = "VisaTextBox";
            this.VisaTextBox.Size = new System.Drawing.Size(342, 22);
            this.VisaTextBox.TabIndex = 34;
            // 
            // ErrorsLabel
            // 
            this.ErrorsLabel.AutoSize = true;
            this.ErrorsLabel.Location = new System.Drawing.Point(12, 315);
            this.ErrorsLabel.Name = "ErrorsLabel";
            this.ErrorsLabel.Size = new System.Drawing.Size(56, 17);
            this.ErrorsLabel.TabIndex = 35;
            this.ErrorsLabel.Text = "            ";
            // 
            // Home_Internet_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 372);
            this.Controls.Add(this.ErrorsLabel);
            this.Controls.Add(this.VisaTextBox);
            this.Controls.Add(this.Proceed_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PayInternet_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VisaLandLine_RB);
            this.Controls.Add(this.CashLandLine_RB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NetPlans_ListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home_Internet_Payment";
            this.Text = "Home_Internet_Payment";
            this.Load += new System.EventHandler(this.Home_Internet_Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Proceed_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PayInternet_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton VisaLandLine_RB;
        private System.Windows.Forms.RadioButton CashLandLine_RB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox NetPlans_ListBox;
        private System.Windows.Forms.TextBox VisaTextBox;
        private System.Windows.Forms.Label ErrorsLabel;
    }
}