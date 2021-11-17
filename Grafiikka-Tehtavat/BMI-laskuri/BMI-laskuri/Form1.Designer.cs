
namespace BMI_laskuri
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TulostekstiLB = new System.Windows.Forms.Label();
            this.PainoTB = new System.Windows.Forms.TextBox();
            this.PituusTB = new System.Windows.Forms.TextBox();
            this.PainoIndeksiBT = new System.Windows.Forms.Button();
            this.PainotulosLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna paino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna pituus:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TulostekstiLB
            // 
            this.TulostekstiLB.AutoSize = true;
            this.TulostekstiLB.Location = new System.Drawing.Point(35, 142);
            this.TulostekstiLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TulostekstiLB.Name = "TulostekstiLB";
            this.TulostekstiLB.Size = new System.Drawing.Size(70, 25);
            this.TulostekstiLB.TabIndex = 2;
            this.TulostekstiLB.Text = "label3";
            this.TulostekstiLB.Visible = false;
            // 
            // PainoTB
            // 
            this.PainoTB.Location = new System.Drawing.Point(171, 32);
            this.PainoTB.Name = "PainoTB";
            this.PainoTB.Size = new System.Drawing.Size(95, 31);
            this.PainoTB.TabIndex = 3;
            // 
            // PituusTB
            // 
            this.PituusTB.Location = new System.Drawing.Point(429, 35);
            this.PituusTB.Name = "PituusTB";
            this.PituusTB.Size = new System.Drawing.Size(95, 31);
            this.PituusTB.TabIndex = 4;
            // 
            // PainoIndeksiBT
            // 
            this.PainoIndeksiBT.Location = new System.Drawing.Point(171, 86);
            this.PainoIndeksiBT.Name = "PainoIndeksiBT";
            this.PainoIndeksiBT.Size = new System.Drawing.Size(241, 39);
            this.PainoIndeksiBT.TabIndex = 5;
            this.PainoIndeksiBT.Text = "Laske painoindeksi";
            this.PainoIndeksiBT.UseVisualStyleBackColor = true;
            this.PainoIndeksiBT.Click += new System.EventHandler(this.PainoIndeksiBT_Click);
            // 
            // PainotulosLB
            // 
            this.PainotulosLB.AutoSize = true;
            this.PainotulosLB.Location = new System.Drawing.Point(35, 177);
            this.PainotulosLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PainotulosLB.Name = "PainotulosLB";
            this.PainotulosLB.Size = new System.Drawing.Size(70, 25);
            this.PainotulosLB.TabIndex = 6;
            this.PainotulosLB.Text = "label4";
            this.PainotulosLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(550, 221);
            this.Controls.Add(this.PainotulosLB);
            this.Controls.Add(this.PainoIndeksiBT);
            this.Controls.Add(this.PituusTB);
            this.Controls.Add(this.PainoTB);
            this.Controls.Add(this.TulostekstiLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TulostekstiLB;
        private System.Windows.Forms.TextBox PainoTB;
        private System.Windows.Forms.TextBox PituusTB;
        private System.Windows.Forms.Button PainoIndeksiBT;
        private System.Windows.Forms.Label PainotulosLB;
    }
}

