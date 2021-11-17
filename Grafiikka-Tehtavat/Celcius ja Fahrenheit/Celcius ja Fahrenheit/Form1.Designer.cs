
namespace Celcius_ja_Fahrenheit
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
            this.AnnettuTB = new System.Windows.Forms.TextBox();
            this.CelciusRBT = new System.Windows.Forms.RadioButton();
            this.FahrenheitRBT = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.MuutosBT = new System.Windows.Forms.Button();
            this.TulosLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna luku jonka haluat muuntaa:";
            // 
            // AnnettuTB
            // 
            this.AnnettuTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnettuTB.Location = new System.Drawing.Point(504, 108);
            this.AnnettuTB.Name = "AnnettuTB";
            this.AnnettuTB.Size = new System.Drawing.Size(87, 22);
            this.AnnettuTB.TabIndex = 1;
            // 
            // CelciusRBT
            // 
            this.CelciusRBT.AutoSize = true;
            this.CelciusRBT.Location = new System.Drawing.Point(504, 173);
            this.CelciusRBT.Name = "CelciusRBT";
            this.CelciusRBT.Size = new System.Drawing.Size(59, 17);
            this.CelciusRBT.TabIndex = 2;
            this.CelciusRBT.TabStop = true;
            this.CelciusRBT.Text = "Celcius";
            this.CelciusRBT.UseVisualStyleBackColor = true;
            // 
            // FahrenheitRBT
            // 
            this.FahrenheitRBT.AutoSize = true;
            this.FahrenheitRBT.Location = new System.Drawing.Point(504, 196);
            this.FahrenheitRBT.Name = "FahrenheitRBT";
            this.FahrenheitRBT.Size = new System.Drawing.Size(75, 17);
            this.FahrenheitRBT.TabIndex = 3;
            this.FahrenheitRBT.TabStop = true;
            this.FahrenheitRBT.Text = "Fahrenheit";
            this.FahrenheitRBT.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kummaksi muutat?";
            // 
            // MuutosBT
            // 
            this.MuutosBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuutosBT.Location = new System.Drawing.Point(504, 219);
            this.MuutosBT.Name = "MuutosBT";
            this.MuutosBT.Size = new System.Drawing.Size(75, 29);
            this.MuutosBT.TabIndex = 5;
            this.MuutosBT.Text = "Muuta";
            this.MuutosBT.UseVisualStyleBackColor = true;
            this.MuutosBT.Click += new System.EventHandler(this.MuutosBT_Click);
            // 
            // TulosLB
            // 
            this.TulosLB.AutoSize = true;
            this.TulosLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TulosLB.Location = new System.Drawing.Point(174, 264);
            this.TulosLB.Name = "TulosLB";
            this.TulosLB.Size = new System.Drawing.Size(65, 25);
            this.TulosLB.TabIndex = 6;
            this.TulosLB.Text = "Tulos";
            this.TulosLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 465);
            this.Controls.Add(this.TulosLB);
            this.Controls.Add(this.MuutosBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FahrenheitRBT);
            this.Controls.Add(this.CelciusRBT);
            this.Controls.Add(this.AnnettuTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AnnettuTB;
        private System.Windows.Forms.RadioButton CelciusRBT;
        private System.Windows.Forms.RadioButton FahrenheitRBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MuutosBT;
        private System.Windows.Forms.Label TulosLB;
    }
}

