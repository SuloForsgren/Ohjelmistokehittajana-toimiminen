
namespace Salasanan_tarkistus
{
    partial class salasanaForm
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
            this.salasanaPanel = new System.Windows.Forms.Panel();
            this.salasanaOikeinPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VirheviestiLB = new System.Windows.Forms.Label();
            this.TarkistaBT = new System.Windows.Forms.Button();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.KayttajatunnusTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KayttajaNaytaLB = new System.Windows.Forms.Label();
            this.SalasanaNaytaLB = new System.Windows.Forms.Label();
            this.salasanaPanel.SuspendLayout();
            this.salasanaOikeinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // salasanaPanel
            // 
            this.salasanaPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.salasanaPanel.Controls.Add(this.SalasanaNaytaLB);
            this.salasanaPanel.Controls.Add(this.KayttajaNaytaLB);
            this.salasanaPanel.Controls.Add(this.salasanaOikeinPanel);
            this.salasanaPanel.Controls.Add(this.VirheviestiLB);
            this.salasanaPanel.Controls.Add(this.TarkistaBT);
            this.salasanaPanel.Controls.Add(this.SalasanaTB);
            this.salasanaPanel.Controls.Add(this.KayttajatunnusTB);
            this.salasanaPanel.Controls.Add(this.label2);
            this.salasanaPanel.Controls.Add(this.label1);
            this.salasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salasanaPanel.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaPanel.ForeColor = System.Drawing.Color.Yellow;
            this.salasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.salasanaPanel.Name = "salasanaPanel";
            this.salasanaPanel.Size = new System.Drawing.Size(845, 441);
            this.salasanaPanel.TabIndex = 0;
            // 
            // salasanaOikeinPanel
            // 
            this.salasanaOikeinPanel.BackColor = System.Drawing.Color.DarkRed;
            this.salasanaOikeinPanel.Controls.Add(this.label4);
            this.salasanaOikeinPanel.Controls.Add(this.label3);
            this.salasanaOikeinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salasanaOikeinPanel.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaOikeinPanel.ForeColor = System.Drawing.Color.Snow;
            this.salasanaOikeinPanel.Location = new System.Drawing.Point(0, 0);
            this.salasanaOikeinPanel.Name = "salasanaOikeinPanel";
            this.salasanaOikeinPanel.Size = new System.Drawing.Size(845, 441);
            this.salasanaOikeinPanel.TabIndex = 1;
            this.salasanaOikeinPanel.Visible = false;
            this.salasanaOikeinPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.salasanaOikeinPanel_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(754, 80);
            this.label4.TabIndex = 1;
            this.label4.Text = "Olet syöttänyt tiedot oikein!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(567, 80);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tervetuloa sivulleni!";
            // 
            // VirheviestiLB
            // 
            this.VirheviestiLB.AutoSize = true;
            this.VirheviestiLB.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirheviestiLB.Location = new System.Drawing.Point(102, 47);
            this.VirheviestiLB.Name = "VirheviestiLB";
            this.VirheviestiLB.Size = new System.Drawing.Size(35, 40);
            this.VirheviestiLB.TabIndex = 5;
            this.VirheviestiLB.Text = "...";
            this.VirheviestiLB.Visible = false;
            // 
            // TarkistaBT
            // 
            this.TarkistaBT.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TarkistaBT.Location = new System.Drawing.Point(251, 228);
            this.TarkistaBT.Name = "TarkistaBT";
            this.TarkistaBT.Size = new System.Drawing.Size(174, 44);
            this.TarkistaBT.TabIndex = 4;
            this.TarkistaBT.Text = "Tarkista";
            this.TarkistaBT.UseVisualStyleBackColor = true;
            this.TarkistaBT.Click += new System.EventHandler(this.TarkistaBT_Click_1);
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaTB.Location = new System.Drawing.Point(251, 183);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(174, 46);
            this.SalasanaTB.TabIndex = 3;
            this.SalasanaTB.TextChanged += new System.EventHandler(this.SalasanaTB_TextChanged);
            // 
            // KayttajatunnusTB
            // 
            this.KayttajatunnusTB.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajatunnusTB.Location = new System.Drawing.Point(251, 135);
            this.KayttajatunnusTB.Name = "KayttajatunnusTB";
            this.KayttajatunnusTB.Size = new System.Drawing.Size(174, 46);
            this.KayttajatunnusTB.TabIndex = 2;
            this.KayttajatunnusTB.TextChanged += new System.EventHandler(this.KayttajatunnusTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // KayttajaNaytaLB
            // 
            this.KayttajaNaytaLB.AutoSize = true;
            this.KayttajaNaytaLB.Font = new System.Drawing.Font("Ravie", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajaNaytaLB.Location = new System.Drawing.Point(458, 146);
            this.KayttajaNaytaLB.Name = "KayttajaNaytaLB";
            this.KayttajaNaytaLB.Size = new System.Drawing.Size(104, 30);
            this.KayttajaNaytaLB.TabIndex = 6;
            this.KayttajaNaytaLB.Text = "label5";
            this.KayttajaNaytaLB.Visible = false;
            // 
            // SalasanaNaytaLB
            // 
            this.SalasanaNaytaLB.AutoSize = true;
            this.SalasanaNaytaLB.Font = new System.Drawing.Font("Ravie", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaNaytaLB.Location = new System.Drawing.Point(458, 190);
            this.SalasanaNaytaLB.Name = "SalasanaNaytaLB";
            this.SalasanaNaytaLB.Size = new System.Drawing.Size(104, 30);
            this.SalasanaNaytaLB.TabIndex = 7;
            this.SalasanaNaytaLB.Text = "label6";
            this.SalasanaNaytaLB.Visible = false;
            // 
            // salasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 441);
            this.Controls.Add(this.salasanaPanel);
            this.Name = "salasanaForm";
            this.Text = "Salasanan tarkistus";
            this.Load += new System.EventHandler(this.salasanaForm_Load);
            this.salasanaPanel.ResumeLayout(false);
            this.salasanaPanel.PerformLayout();
            this.salasanaOikeinPanel.ResumeLayout(false);
            this.salasanaOikeinPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel salasanaPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.TextBox KayttajatunnusTB;
        private System.Windows.Forms.Label VirheviestiLB;
        private System.Windows.Forms.Button TarkistaBT;
        private System.Windows.Forms.Panel salasanaOikeinPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SalasanaNaytaLB;
        private System.Windows.Forms.Label KayttajaNaytaLB;
    }
}

