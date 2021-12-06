
namespace Hotelli__Oma_
{
    partial class VARAUKSET
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VarausTB = new System.Windows.Forms.TextBox();
            this.VarauksetDG = new System.Windows.Forms.DataGridView();
            this.YksiöCB = new System.Windows.Forms.ComboBox();
            this.SisaanDTP = new System.Windows.Forms.DateTimePicker();
            this.UlosDTP = new System.Windows.Forms.DateTimePicker();
            this.AddBT = new System.Windows.Forms.Button();
            this.DeleteBT = new System.Windows.Forms.Button();
            this.UpdateBT = new System.Windows.Forms.Button();
            this.EraseBT = new System.Windows.Forms.Button();
            this.KaksioCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SviittiCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PerheCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.VarausnTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VarauksetDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sisään";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ulos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Varaus nro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Huoneentyypit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yksiöt";
            // 
            // VarausTB
            // 
            this.VarausTB.Enabled = false;
            this.VarausTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarausTB.Location = new System.Drawing.Point(196, 53);
            this.VarausTB.Name = "VarausTB";
            this.VarausTB.Size = new System.Drawing.Size(177, 22);
            this.VarausTB.TabIndex = 6;
            // 
            // VarauksetDG
            // 
            this.VarauksetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VarauksetDG.Location = new System.Drawing.Point(421, 12);
            this.VarauksetDG.Name = "VarauksetDG";
            this.VarauksetDG.Size = new System.Drawing.Size(640, 426);
            this.VarauksetDG.TabIndex = 7;
            this.VarauksetDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VarauksetDG_CellContentClick);
            // 
            // YksiöCB
            // 
            this.YksiöCB.FormattingEnabled = true;
            this.YksiöCB.Items.AddRange(new object[] {
            "100",
            "101",
            "102",
            "103",
            "104"});
            this.YksiöCB.Location = new System.Drawing.Point(196, 125);
            this.YksiöCB.Name = "YksiöCB";
            this.YksiöCB.Size = new System.Drawing.Size(177, 21);
            this.YksiöCB.TabIndex = 10;
            this.YksiöCB.SelectedIndexChanged += new System.EventHandler(this.HuonenroCB_SelectedIndexChanged);
            // 
            // SisaanDTP
            // 
            this.SisaanDTP.Location = new System.Drawing.Point(196, 322);
            this.SisaanDTP.Name = "SisaanDTP";
            this.SisaanDTP.Size = new System.Drawing.Size(177, 20);
            this.SisaanDTP.TabIndex = 11;
            // 
            // UlosDTP
            // 
            this.UlosDTP.Location = new System.Drawing.Point(196, 356);
            this.UlosDTP.Name = "UlosDTP";
            this.UlosDTP.Size = new System.Drawing.Size(177, 20);
            this.UlosDTP.TabIndex = 12;
            // 
            // AddBT
            // 
            this.AddBT.Location = new System.Drawing.Point(136, 390);
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(75, 23);
            this.AddBT.TabIndex = 14;
            this.AddBT.Text = "Lisää varaus";
            this.AddBT.UseVisualStyleBackColor = true;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Location = new System.Drawing.Point(298, 390);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(75, 23);
            this.DeleteBT.TabIndex = 15;
            this.DeleteBT.Text = "Poista";
            this.DeleteBT.UseVisualStyleBackColor = true;
            // 
            // UpdateBT
            // 
            this.UpdateBT.Location = new System.Drawing.Point(217, 390);
            this.UpdateBT.Name = "UpdateBT";
            this.UpdateBT.Size = new System.Drawing.Size(75, 23);
            this.UpdateBT.TabIndex = 16;
            this.UpdateBT.Text = "Päivitä";
            this.UpdateBT.UseVisualStyleBackColor = true;
            // 
            // EraseBT
            // 
            this.EraseBT.Location = new System.Drawing.Point(136, 419);
            this.EraseBT.Name = "EraseBT";
            this.EraseBT.Size = new System.Drawing.Size(237, 23);
            this.EraseBT.TabIndex = 17;
            this.EraseBT.Text = "Tyhjää (resetoi comboboksit)";
            this.EraseBT.UseVisualStyleBackColor = true;
            this.EraseBT.Click += new System.EventHandler(this.EraseBT_Click);
            // 
            // KaksioCB
            // 
            this.KaksioCB.FormattingEnabled = true;
            this.KaksioCB.Items.AddRange(new object[] {
            "110",
            "111",
            "112",
            "113",
            "114"});
            this.KaksioCB.Location = new System.Drawing.Point(196, 162);
            this.KaksioCB.Name = "KaksioCB";
            this.KaksioCB.Size = new System.Drawing.Size(177, 21);
            this.KaksioCB.TabIndex = 19;
            this.KaksioCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Kaksiot";
            // 
            // SviittiCB
            // 
            this.SviittiCB.FormattingEnabled = true;
            this.SviittiCB.Items.AddRange(new object[] {
            "130",
            "131",
            "132",
            "133",
            "134"});
            this.SviittiCB.Location = new System.Drawing.Point(196, 236);
            this.SviittiCB.Name = "SviittiCB";
            this.SviittiCB.Size = new System.Drawing.Size(177, 21);
            this.SviittiCB.TabIndex = 23;
            this.SviittiCB.SelectedIndexChanged += new System.EventHandler(this.SviittiCB_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sviitit";
            // 
            // PerheCB
            // 
            this.PerheCB.FormattingEnabled = true;
            this.PerheCB.Items.AddRange(new object[] {
            "120",
            "121",
            "122",
            "123",
            "124"});
            this.PerheCB.Location = new System.Drawing.Point(196, 199);
            this.PerheCB.Name = "PerheCB";
            this.PerheCB.Size = new System.Drawing.Size(177, 21);
            this.PerheCB.TabIndex = 21;
            this.PerheCB.SelectedIndexChanged += new System.EventHandler(this.PerheCB_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Perheelle";
            // 
            // VarausnTB
            // 
            this.VarausnTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarausnTB.Location = new System.Drawing.Point(196, 279);
            this.VarausnTB.Name = "VarausnTB";
            this.VarausnTB.Size = new System.Drawing.Size(177, 22);
            this.VarausnTB.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Varauksen nimi";
            // 
            // VARAUKSET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1088, 450);
            this.Controls.Add(this.VarausnTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SviittiCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PerheCB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.KaksioCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EraseBT);
            this.Controls.Add(this.UpdateBT);
            this.Controls.Add(this.DeleteBT);
            this.Controls.Add(this.AddBT);
            this.Controls.Add(this.UlosDTP);
            this.Controls.Add(this.SisaanDTP);
            this.Controls.Add(this.YksiöCB);
            this.Controls.Add(this.VarauksetDG);
            this.Controls.Add(this.VarausTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VARAUKSET";
            this.Text = "VARAUKSET";
            this.Load += new System.EventHandler(this.VARAUKSET_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VarauksetDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox VarausTB;
        private System.Windows.Forms.DataGridView VarauksetDG;
        private System.Windows.Forms.ComboBox YksiöCB;
        private System.Windows.Forms.DateTimePicker SisaanDTP;
        private System.Windows.Forms.DateTimePicker UlosDTP;
        private System.Windows.Forms.Button AddBT;
        private System.Windows.Forms.Button DeleteBT;
        private System.Windows.Forms.Button UpdateBT;
        private System.Windows.Forms.Button EraseBT;
        private System.Windows.Forms.ComboBox KaksioCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SviittiCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox PerheCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox VarausnTB;
        private System.Windows.Forms.Label label9;
    }
}