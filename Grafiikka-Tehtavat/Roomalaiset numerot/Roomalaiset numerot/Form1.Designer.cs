
namespace Roomalaiset_numerot
{
    partial class RoomalaisetForm
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
            this.AnnettuLukuTB = new System.Windows.Forms.TextBox();
            this.MuutaBT = new System.Windows.Forms.Button();
            this.MuutettuLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna luku väliltä 1-3999 josta tulee roomalainen numero";
            // 
            // AnnettuLukuTB
            // 
            this.AnnettuLukuTB.Location = new System.Drawing.Point(653, 135);
            this.AnnettuLukuTB.Name = "AnnettuLukuTB";
            this.AnnettuLukuTB.Size = new System.Drawing.Size(100, 20);
            this.AnnettuLukuTB.TabIndex = 1;
            // 
            // MuutaBT
            // 
            this.MuutaBT.Location = new System.Drawing.Point(653, 161);
            this.MuutaBT.Name = "MuutaBT";
            this.MuutaBT.Size = new System.Drawing.Size(100, 23);
            this.MuutaBT.TabIndex = 2;
            this.MuutaBT.Text = "Muuta luku";
            this.MuutaBT.UseVisualStyleBackColor = true;
            this.MuutaBT.Click += new System.EventHandler(this.MuutaBT_Click);
            // 
            // MuutettuLB
            // 
            this.MuutettuLB.AutoSize = true;
            this.MuutettuLB.Location = new System.Drawing.Point(152, 227);
            this.MuutettuLB.Name = "MuutettuLB";
            this.MuutettuLB.Size = new System.Drawing.Size(35, 13);
            this.MuutettuLB.TabIndex = 3;
            this.MuutettuLB.Text = "label2";
            this.MuutettuLB.Visible = false;
            // 
            // RoomalaisetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(990, 548);
            this.Controls.Add(this.MuutettuLB);
            this.Controls.Add(this.MuutaBT);
            this.Controls.Add(this.AnnettuLukuTB);
            this.Controls.Add(this.label1);
            this.Name = "RoomalaisetForm";
            this.Text = "Numeroiden muuttaminen";
            this.Load += new System.EventHandler(this.RoomalaisetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AnnettuLukuTB;
        private System.Windows.Forms.Button MuutaBT;
        private System.Windows.Forms.Label MuutettuLB;
    }
}

