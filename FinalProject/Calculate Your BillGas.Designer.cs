
namespace FinalProject
{
    partial class CalcGas_Form
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
            this.MeterG_Label = new System.Windows.Forms.Label();
            this.MoneyG_Label = new System.Windows.Forms.Label();
            this.NewRG_TextBox = new System.Windows.Forms.TextBox();
            this.OldRG_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BHG_Button = new System.Windows.Forms.Button();
            this.HomeG_button = new System.Windows.Forms.Button();
            this.CG_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MeterG_Label
            // 
            this.MeterG_Label.AutoSize = true;
            this.MeterG_Label.Location = new System.Drawing.Point(228, 76);
            this.MeterG_Label.Name = "MeterG_Label";
            this.MeterG_Label.Size = new System.Drawing.Size(32, 20);
            this.MeterG_Label.TabIndex = 19;
            this.MeterG_Label.Text = "Res";
            // 
            // MoneyG_Label
            // 
            this.MoneyG_Label.AutoSize = true;
            this.MoneyG_Label.Location = new System.Drawing.Point(228, 199);
            this.MoneyG_Label.Name = "MoneyG_Label";
            this.MoneyG_Label.Size = new System.Drawing.Size(32, 20);
            this.MoneyG_Label.TabIndex = 18;
            this.MoneyG_Label.Text = "Res";
            // 
            // NewRG_TextBox
            // 
            this.NewRG_TextBox.Location = new System.Drawing.Point(12, 192);
            this.NewRG_TextBox.Name = "NewRG_TextBox";
            this.NewRG_TextBox.Size = new System.Drawing.Size(163, 27);
            this.NewRG_TextBox.TabIndex = 17;
            // 
            // OldRG_TextBox
            // 
            this.OldRG_TextBox.Location = new System.Drawing.Point(12, 69);
            this.OldRG_TextBox.MaxLength = 16;
            this.OldRG_TextBox.Name = "OldRG_TextBox";
            this.OldRG_TextBox.Size = new System.Drawing.Size(163, 27);
            this.OldRG_TextBox.TabIndex = 16;
            this.OldRG_TextBox.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "No. of Meters Consumed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Your Reciept";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter Your New Reading ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Your Old Reading";
            // 
            // BHG_Button
            // 
            this.BHG_Button.AutoSize = true;
            this.BHG_Button.Location = new System.Drawing.Point(218, 309);
            this.BHG_Button.Name = "BHG_Button";
            this.BHG_Button.Size = new System.Drawing.Size(176, 30);
            this.BHG_Button.TabIndex = 11;
            this.BHG_Button.Text = "Back To Gas";
            this.BHG_Button.UseVisualStyleBackColor = true;
            this.BHG_Button.Click += new System.EventHandler(this.BHG_Button_Click);
            // 
            // HomeG_button
            // 
            this.HomeG_button.AutoSize = true;
            this.HomeG_button.Location = new System.Drawing.Point(12, 309);
            this.HomeG_button.Name = "HomeG_button";
            this.HomeG_button.Size = new System.Drawing.Size(148, 30);
            this.HomeG_button.TabIndex = 10;
            this.HomeG_button.Text = "Back To Main Menu";
            this.HomeG_button.UseVisualStyleBackColor = true;
            // 
            // CG_Button
            // 
            this.CG_Button.Location = new System.Drawing.Point(141, 249);
            this.CG_Button.Name = "CG_Button";
            this.CG_Button.Size = new System.Drawing.Size(94, 29);
            this.CG_Button.TabIndex = 20;
            this.CG_Button.Text = "Calculate";
            this.CG_Button.UseVisualStyleBackColor = true;
            // 
            // CalcGas_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(406, 369);
            this.Controls.Add(this.CG_Button);
            this.Controls.Add(this.MeterG_Label);
            this.Controls.Add(this.MoneyG_Label);
            this.Controls.Add(this.NewRG_TextBox);
            this.Controls.Add(this.OldRG_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BHG_Button);
            this.Controls.Add(this.HomeG_button);
            this.Name = "CalcGas_Form";
            this.Text = "Calculate Your Bill";
            this.Load += new System.EventHandler(this.CalcGas_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MeterG_Label;
        private System.Windows.Forms.Label MoneyG_Label;
        private System.Windows.Forms.TextBox NewRG_TextBox;
        private System.Windows.Forms.TextBox OldRG_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BHG_Button;
        private System.Windows.Forms.Button HomeG_button;
        private System.Windows.Forms.Button CG_Button;
    }
}