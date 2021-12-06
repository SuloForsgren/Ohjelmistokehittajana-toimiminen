
namespace Pojat_ja_tytöt
{
    partial class NimiFORM
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
            this.NimiTB = new System.Windows.Forms.TextBox();
            this.TarkistusBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Antaisitko nimesi niin tarkistan onko se suosittu: ";
            // 
            // NimiTB
            // 
            this.NimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NimiTB.Location = new System.Drawing.Point(541, 35);
            this.NimiTB.Name = "NimiTB";
            this.NimiTB.Size = new System.Drawing.Size(100, 31);
            this.NimiTB.TabIndex = 1;
            // 
            // TarkistusBT
            // 
            this.TarkistusBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TarkistusBT.Location = new System.Drawing.Point(662, 39);
            this.TarkistusBT.Name = "TarkistusBT";
            this.TarkistusBT.Size = new System.Drawing.Size(100, 27);
            this.TarkistusBT.TabIndex = 2;
            this.TarkistusBT.Text = "Tarkista";
            this.TarkistusBT.UseVisualStyleBackColor = true;
            this.TarkistusBT.Click += new System.EventHandler(this.TarkistusBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(37, 91);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(250, 33);
            this.VastausLB.TabIndex = 3;
            this.VastausLB.Text = "Nimesi on suosituin nimi";
            this.VastausLB.Visible = false;
            // 
            // NimiFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 151);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.TarkistusBT);
            this.Controls.Add(this.NimiTB);
            this.Controls.Add(this.label1);
            this.Name = "NimiFORM";
            this.Text = "Onko nimesi top 50 joukossa?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NimiTB;
        private System.Windows.Forms.Button TarkistusBT;
        private System.Windows.Forms.Label VastausLB;
    }
}

