
namespace _10_Kysymystä
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
            this.KysymysLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VastausDRBT = new System.Windows.Forms.RadioButton();
            this.VastausCRBT = new System.Windows.Forms.RadioButton();
            this.VastausBRBT = new System.Windows.Forms.RadioButton();
            this.VastausARBT = new System.Windows.Forms.RadioButton();
            this.TurhaRBT = new System.Windows.Forms.RadioButton();
            this.VastausLB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KysymysLB.Location = new System.Drawing.Point(18, 33);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(175, 24);
            this.KysymysLB.TabIndex = 0;
            this.KysymysLB.Text = "Vastaus 1. kysymykseen:";
            this.KysymysLB.Click += new System.EventHandler(this.KysymysLB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VastausDRBT);
            this.groupBox1.Controls.Add(this.VastausCRBT);
            this.groupBox1.Controls.Add(this.VastausBRBT);
            this.groupBox1.Controls.Add(this.VastausARBT);
            this.groupBox1.Controls.Add(this.TurhaRBT);
            this.groupBox1.Location = new System.Drawing.Point(221, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // VastausDRBT
            // 
            this.VastausDRBT.AutoCheck = false;
            this.VastausDRBT.AutoSize = true;
            this.VastausDRBT.Location = new System.Drawing.Point(6, 89);
            this.VastausDRBT.Name = "VastausDRBT";
            this.VastausDRBT.Size = new System.Drawing.Size(33, 17);
            this.VastausDRBT.TabIndex = 4;
            this.VastausDRBT.TabStop = true;
            this.VastausDRBT.Text = "D";
            this.VastausDRBT.UseVisualStyleBackColor = true;
            this.VastausDRBT.CheckedChanged += new System.EventHandler(this.VastausDRBT_CheckedChanged);
            // 
            // VastausCRBT
            // 
            this.VastausCRBT.AutoCheck = false;
            this.VastausCRBT.AutoSize = true;
            this.VastausCRBT.Location = new System.Drawing.Point(6, 66);
            this.VastausCRBT.Name = "VastausCRBT";
            this.VastausCRBT.Size = new System.Drawing.Size(32, 17);
            this.VastausCRBT.TabIndex = 3;
            this.VastausCRBT.TabStop = true;
            this.VastausCRBT.Text = "C";
            this.VastausCRBT.UseVisualStyleBackColor = true;
            this.VastausCRBT.CheckedChanged += new System.EventHandler(this.VastausCRBT_CheckedChanged);
            // 
            // VastausBRBT
            // 
            this.VastausBRBT.AutoCheck = false;
            this.VastausBRBT.AutoSize = true;
            this.VastausBRBT.Location = new System.Drawing.Point(6, 43);
            this.VastausBRBT.Name = "VastausBRBT";
            this.VastausBRBT.Size = new System.Drawing.Size(32, 17);
            this.VastausBRBT.TabIndex = 2;
            this.VastausBRBT.TabStop = true;
            this.VastausBRBT.Text = "B";
            this.VastausBRBT.UseVisualStyleBackColor = true;
            this.VastausBRBT.CheckedChanged += new System.EventHandler(this.VastausBRBT_CheckedChanged);
            // 
            // VastausARBT
            // 
            this.VastausARBT.AutoCheck = false;
            this.VastausARBT.AutoSize = true;
            this.VastausARBT.Location = new System.Drawing.Point(6, 20);
            this.VastausARBT.Name = "VastausARBT";
            this.VastausARBT.Size = new System.Drawing.Size(32, 17);
            this.VastausARBT.TabIndex = 1;
            this.VastausARBT.TabStop = true;
            this.VastausARBT.Text = "A";
            this.VastausARBT.UseVisualStyleBackColor = true;
            this.VastausARBT.CheckedChanged += new System.EventHandler(this.VastausARBT_CheckedChanged);
            // 
            // TurhaRBT
            // 
            this.TurhaRBT.AutoCheck = false;
            this.TurhaRBT.AutoSize = true;
            this.TurhaRBT.Location = new System.Drawing.Point(7, 20);
            this.TurhaRBT.Name = "TurhaRBT";
            this.TurhaRBT.Size = new System.Drawing.Size(32, 17);
            this.TurhaRBT.TabIndex = 0;
            this.TurhaRBT.TabStop = true;
            this.TurhaRBT.Text = "E";
            this.TurhaRBT.UseVisualStyleBackColor = true;
            this.TurhaRBT.Visible = false;
            this.TurhaRBT.CheckedChanged += new System.EventHandler(this.TurhaRBT_CheckedChanged);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("ROG Fonts v1.6", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(17, 184);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(95, 25);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 235);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.KysymysLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KysymysLB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton VastausDRBT;
        private System.Windows.Forms.RadioButton VastausCRBT;
        private System.Windows.Forms.RadioButton VastausBRBT;
        private System.Windows.Forms.RadioButton VastausARBT;
        private System.Windows.Forms.RadioButton TurhaRBT;
        private System.Windows.Forms.Label VastausLB;
    }
}

