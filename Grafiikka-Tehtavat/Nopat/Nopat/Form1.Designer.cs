
namespace Nopat
{
    partial class Nopat
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
            this.Noppa02PB = new System.Windows.Forms.PictureBox();
            this.Noppa01PB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HeittoBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Noppa02PB
            // 
            this.Noppa02PB.Image = global::Nopat.Properties.Resources.dice01;
            this.Noppa02PB.Location = new System.Drawing.Point(201, 75);
            this.Noppa02PB.Name = "Noppa02PB";
            this.Noppa02PB.Size = new System.Drawing.Size(88, 86);
            this.Noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa02PB.TabIndex = 0;
            this.Noppa02PB.TabStop = false;
            // 
            // Noppa01PB
            // 
            this.Noppa01PB.Image = global::Nopat.Properties.Resources.dice01;
            this.Noppa01PB.Location = new System.Drawing.Point(85, 75);
            this.Noppa01PB.Name = "Noppa01PB";
            this.Noppa01PB.Size = new System.Drawing.Size(86, 86);
            this.Noppa01PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa01PB.TabIndex = 1;
            this.Noppa01PB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nopan Heitto";
            // 
            // HeittoBT
            // 
            this.HeittoBT.Location = new System.Drawing.Point(86, 185);
            this.HeittoBT.Name = "HeittoBT";
            this.HeittoBT.Size = new System.Drawing.Size(203, 23);
            this.HeittoBT.TabIndex = 3;
            this.HeittoBT.Text = "Paina heittääksesi noppaa";
            this.HeittoBT.UseVisualStyleBackColor = true;
            this.HeittoBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nopat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 219);
            this.Controls.Add(this.HeittoBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Noppa01PB);
            this.Controls.Add(this.Noppa02PB);
            this.Name = "Nopat";
            this.Text = "Heitä nopat";
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Noppa02PB;
        private System.Windows.Forms.PictureBox Noppa01PB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HeittoBT;
    }
}

