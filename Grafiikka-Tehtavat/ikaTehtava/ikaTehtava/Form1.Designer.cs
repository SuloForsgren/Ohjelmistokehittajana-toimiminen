
namespace ikaTehtava
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
            this.Pvm = new System.Windows.Forms.DateTimePicker();
            this.Vuosi = new System.Windows.Forms.Label();
            this.kuukausi = new System.Windows.Forms.Label();
            this.Päivä = new System.Windows.Forms.Label();
            this.Tunti = new System.Windows.Forms.Label();
            this.Minuutti = new System.Windows.Forms.Label();
            this.Sekunti = new System.Windows.Forms.Label();
            this.Nappula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pvm
            // 
            this.Pvm.Location = new System.Drawing.Point(279, 44);
            this.Pvm.Name = "Pvm";
            this.Pvm.Size = new System.Drawing.Size(200, 20);
            this.Pvm.TabIndex = 0;
            // 
            // Vuosi
            // 
            this.Vuosi.AutoSize = true;
            this.Vuosi.Location = new System.Drawing.Point(276, 137);
            this.Vuosi.Name = "Vuosi";
            this.Vuosi.Size = new System.Drawing.Size(35, 13);
            this.Vuosi.TabIndex = 1;
            this.Vuosi.Text = "label1";
            this.Vuosi.Visible = false;
            // 
            // kuukausi
            // 
            this.kuukausi.AutoSize = true;
            this.kuukausi.Location = new System.Drawing.Point(276, 182);
            this.kuukausi.Name = "kuukausi";
            this.kuukausi.Size = new System.Drawing.Size(35, 13);
            this.kuukausi.TabIndex = 2;
            this.kuukausi.Text = "label2";
            this.kuukausi.Visible = false;
            // 
            // Päivä
            // 
            this.Päivä.AutoSize = true;
            this.Päivä.Location = new System.Drawing.Point(276, 224);
            this.Päivä.Name = "Päivä";
            this.Päivä.Size = new System.Drawing.Size(35, 13);
            this.Päivä.TabIndex = 3;
            this.Päivä.Text = "label3";
            this.Päivä.Visible = false;
            // 
            // Tunti
            // 
            this.Tunti.AutoSize = true;
            this.Tunti.Location = new System.Drawing.Point(443, 137);
            this.Tunti.Name = "Tunti";
            this.Tunti.Size = new System.Drawing.Size(35, 13);
            this.Tunti.TabIndex = 4;
            this.Tunti.Text = "label4";
            this.Tunti.Visible = false;
            // 
            // Minuutti
            // 
            this.Minuutti.AutoSize = true;
            this.Minuutti.Location = new System.Drawing.Point(446, 181);
            this.Minuutti.Name = "Minuutti";
            this.Minuutti.Size = new System.Drawing.Size(35, 13);
            this.Minuutti.TabIndex = 5;
            this.Minuutti.Text = "label5";
            this.Minuutti.Visible = false;
            // 
            // Sekunti
            // 
            this.Sekunti.AutoSize = true;
            this.Sekunti.Location = new System.Drawing.Point(446, 223);
            this.Sekunti.Name = "Sekunti";
            this.Sekunti.Size = new System.Drawing.Size(35, 13);
            this.Sekunti.TabIndex = 6;
            this.Sekunti.Text = "label6";
            this.Sekunti.Visible = false;
            // 
            // Nappula
            // 
            this.Nappula.Location = new System.Drawing.Point(524, 40);
            this.Nappula.Name = "Nappula";
            this.Nappula.Size = new System.Drawing.Size(75, 23);
            this.Nappula.TabIndex = 7;
            this.Nappula.Text = "Laske";
            this.Nappula.UseVisualStyleBackColor = true;
            this.Nappula.Click += new System.EventHandler(this.Nappula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nappula);
            this.Controls.Add(this.Sekunti);
            this.Controls.Add(this.Minuutti);
            this.Controls.Add(this.Tunti);
            this.Controls.Add(this.Päivä);
            this.Controls.Add(this.kuukausi);
            this.Controls.Add(this.Vuosi);
            this.Controls.Add(this.Pvm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Pvm;
        private System.Windows.Forms.Label Vuosi;
        private System.Windows.Forms.Label kuukausi;
        private System.Windows.Forms.Label Päivä;
        private System.Windows.Forms.Label Tunti;
        private System.Windows.Forms.Label Minuutti;
        private System.Windows.Forms.Label Sekunti;
        private System.Windows.Forms.Button Nappula;
    }
}

