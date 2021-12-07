
namespace Ajastin
{
    partial class AjastinFORM
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
            this.SekunnitCB = new System.Windows.Forms.ComboBox();
            this.MinuutitCB = new System.Windows.Forms.ComboBox();
            this.MinuutitLB = new System.Windows.Forms.Label();
            this.SekunnitLB = new System.Windows.Forms.Label();
            this.KelloLB = new System.Windows.Forms.Label();
            this.AjastinTM = new System.Windows.Forms.Timer(this.components);
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SekunnitCB
            // 
            this.SekunnitCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SekunnitCB.FormattingEnabled = true;
            this.SekunnitCB.Location = new System.Drawing.Point(159, 51);
            this.SekunnitCB.Name = "SekunnitCB";
            this.SekunnitCB.Size = new System.Drawing.Size(121, 33);
            this.SekunnitCB.TabIndex = 1;
            // 
            // MinuutitCB
            // 
            this.MinuutitCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuutitCB.FormattingEnabled = true;
            this.MinuutitCB.Location = new System.Drawing.Point(13, 51);
            this.MinuutitCB.Name = "MinuutitCB";
            this.MinuutitCB.Size = new System.Drawing.Size(121, 33);
            this.MinuutitCB.TabIndex = 2;
            // 
            // MinuutitLB
            // 
            this.MinuutitLB.AutoSize = true;
            this.MinuutitLB.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuutitLB.Location = new System.Drawing.Point(27, 22);
            this.MinuutitLB.Name = "MinuutitLB";
            this.MinuutitLB.Size = new System.Drawing.Size(80, 29);
            this.MinuutitLB.TabIndex = 3;
            this.MinuutitLB.Text = "Minuutit:";
            // 
            // SekunnitLB
            // 
            this.SekunnitLB.AutoSize = true;
            this.SekunnitLB.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SekunnitLB.Location = new System.Drawing.Point(174, 22);
            this.SekunnitLB.Name = "SekunnitLB";
            this.SekunnitLB.Size = new System.Drawing.Size(78, 29);
            this.SekunnitLB.TabIndex = 4;
            this.SekunnitLB.Text = "Sekunnit:";
            // 
            // KelloLB
            // 
            this.KelloLB.AutoSize = true;
            this.KelloLB.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KelloLB.Location = new System.Drawing.Point(62, 104);
            this.KelloLB.Name = "KelloLB";
            this.KelloLB.Size = new System.Drawing.Size(162, 85);
            this.KelloLB.TabIndex = 5;
            this.KelloLB.Text = "00:00";
            // 
            // AjastinTM
            // 
            this.AjastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick);
            // 
            // StartBT
            // 
            this.StartBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBT.Location = new System.Drawing.Point(13, 192);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(121, 35);
            this.StartBT.TabIndex = 6;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBT.Location = new System.Drawing.Point(159, 192);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(121, 35);
            this.StopBT.TabIndex = 7;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // AjastinFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(295, 247);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.KelloLB);
            this.Controls.Add(this.SekunnitLB);
            this.Controls.Add(this.MinuutitLB);
            this.Controls.Add(this.MinuutitCB);
            this.Controls.Add(this.SekunnitCB);
            this.Name = "AjastinFORM";
            this.Text = "Ajastin";
            this.Load += new System.EventHandler(this.AjastinFORM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SekunnitCB;
        private System.Windows.Forms.ComboBox MinuutitCB;
        private System.Windows.Forms.Label MinuutitLB;
        private System.Windows.Forms.Label SekunnitLB;
        private System.Windows.Forms.Label KelloLB;
        private System.Windows.Forms.Timer AjastinTM;
        private System.Windows.Forms.Button StartBT;
        private System.Windows.Forms.Button StopBT;
    }
}

