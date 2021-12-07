
namespace Sekuntikello
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
            this.components = new System.ComponentModel.Container();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Ajastin = new System.Windows.Forms.Timer(this.components);
            this.KelloLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartBT
            // 
            this.StartBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBT.Location = new System.Drawing.Point(57, 125);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(159, 36);
            this.StartBT.TabIndex = 0;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBT.Location = new System.Drawing.Point(322, 125);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(159, 36);
            this.StopBT.TabIndex = 1;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(579, 125);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(159, 36);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Ajastin
            // 
            this.Ajastin.Enabled = true;
            this.Ajastin.Tick += new System.EventHandler(this.Ajastin_Tick);
            // 
            // KelloLB
            // 
            this.KelloLB.AutoSize = true;
            this.KelloLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KelloLB.Location = new System.Drawing.Point(240, 37);
            this.KelloLB.Name = "KelloLB";
            this.KelloLB.Size = new System.Drawing.Size(306, 55);
            this.KelloLB.TabIndex = 3;
            this.KelloLB.Text = "00:00:00:000";
            this.KelloLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 196);
            this.Controls.Add(this.KelloLB);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBT;
        private System.Windows.Forms.Button StopBT;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Timer Ajastin;
        private System.Windows.Forms.Label KelloLB;
    }
}

