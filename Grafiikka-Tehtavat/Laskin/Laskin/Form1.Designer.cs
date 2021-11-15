namespace Laskin
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
            this.LukuyksiTB = new System.Windows.Forms.TextBox();
            this.LaskutoimitusCB = new System.Windows.Forms.ComboBox();
            this.LukukaksiTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LukuyksiTB
            // 
            this.LukuyksiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LukuyksiTB.Location = new System.Drawing.Point(29, 21);
            this.LukuyksiTB.Name = "LukuyksiTB";
            this.LukuyksiTB.Size = new System.Drawing.Size(60, 31);
            this.LukuyksiTB.TabIndex = 0;
            // 
            // LaskutoimitusCB
            // 
            this.LaskutoimitusCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaskutoimitusCB.FormattingEnabled = true;
            this.LaskutoimitusCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.LaskutoimitusCB.Location = new System.Drawing.Point(95, 20);
            this.LaskutoimitusCB.Name = "LaskutoimitusCB";
            this.LaskutoimitusCB.Size = new System.Drawing.Size(33, 33);
            this.LaskutoimitusCB.TabIndex = 1;
            // 
            // LukukaksiTB
            // 
            this.LukukaksiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LukukaksiTB.Location = new System.Drawing.Point(134, 20);
            this.LukukaksiTB.Name = "LukukaksiTB";
            this.LukukaksiTB.Size = new System.Drawing.Size(60, 31);
            this.LukukaksiTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(230, 24);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(26, 25);
            this.VastausLB.TabIndex = 4;
            this.VastausLB.Text = "X";
            this.VastausLB.Visible = false;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaskeBT.Location = new System.Drawing.Point(29, 72);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(78, 32);
            this.LaskeBT.TabIndex = 5;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 244);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LukukaksiTB);
            this.Controls.Add(this.LaskutoimitusCB);
            this.Controls.Add(this.LukuyksiTB);
            this.Name = "Form1";
            this.Text = "yksinkertainen nelilaskin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LukuyksiTB;
        private System.Windows.Forms.ComboBox LaskutoimitusCB;
        private System.Windows.Forms.TextBox LukukaksiTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Button LaskeBT;
    }
}

