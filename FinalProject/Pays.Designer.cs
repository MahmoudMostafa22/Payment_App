
namespace FinalProject
{
    partial class pays
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
            this.internet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Netflix = new System.Windows.Forms.Button();
            this.GasButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // internet
            // 
            this.internet.Location = new System.Drawing.Point(203, 14);
            this.internet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.internet.Name = "internet";
            this.internet.Size = new System.Drawing.Size(113, 69);
            this.internet.TabIndex = 0;
            this.internet.Text = "Internet";
            this.internet.UseVisualStyleBackColor = true;
            this.internet.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "Phone";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 21);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 69);
            this.button3.TabIndex = 2;
            this.button3.Text = "Electricity";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // Netflix
            // 
            this.Netflix.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Netflix.Location = new System.Drawing.Point(101, 102);
            this.Netflix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Netflix.Name = "Netflix";
            this.Netflix.Size = new System.Drawing.Size(275, 69);
            this.Netflix.TabIndex = 4;
            this.Netflix.Text = "Netflix";
            this.Netflix.UseVisualStyleBackColor = true;
            this.Netflix.Click += new System.EventHandler(this.Netflix_click);
            // 
            // GasButton
            // 
            this.GasButton.Location = new System.Drawing.Point(17, 21);
            this.GasButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GasButton.Name = "GasButton";
            this.GasButton.Size = new System.Drawing.Size(164, 69);
            this.GasButton.TabIndex = 5;
            this.GasButton.Text = "Gas";
            this.GasButton.UseVisualStyleBackColor = true;
            this.GasButton.Click += new System.EventHandler(this.GasButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GasButton);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(60, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 109);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utilities";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.internet);
            this.groupBox2.Location = new System.Drawing.Point(77, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phone";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose your service: ";
            // 
            // pays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(492, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Netflix);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "pays";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.pays_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button internet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Netflix;
        private System.Windows.Forms.Button GasButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}