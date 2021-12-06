
namespace Päiväkirja
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
            this.TarinaTB = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TallennusBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TarinaTB
            // 
            this.TarinaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TarinaTB.Location = new System.Drawing.Point(12, 12);
            this.TarinaTB.Multiline = true;
            this.TarinaTB.Name = "TarinaTB";
            this.TarinaTB.Size = new System.Drawing.Size(776, 344);
            this.TarinaTB.TabIndex = 0;
            this.TarinaTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TallennusBT
            // 
            this.TallennusBT.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TallennusBT.Location = new System.Drawing.Point(12, 362);
            this.TallennusBT.Name = "TallennusBT";
            this.TallennusBT.Size = new System.Drawing.Size(776, 76);
            this.TallennusBT.TabIndex = 1;
            this.TallennusBT.Text = "Tallenna päiväkirjaan";
            this.TallennusBT.UseVisualStyleBackColor = true;
            this.TallennusBT.Click += new System.EventHandler(this.TallennusBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TallennusBT);
            this.Controls.Add(this.TarinaTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TarinaTB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button TallennusBT;
    }
}

