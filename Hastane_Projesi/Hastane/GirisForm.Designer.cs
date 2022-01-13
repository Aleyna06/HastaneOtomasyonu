
namespace Hastane
{
    partial class FrmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.lblGirisTckNo = new System.Windows.Forms.Label();
            this.lblGirisSifre = new System.Windows.Forms.Label();
            this.txtGirisTckNo = new System.Windows.Forms.TextBox();
            this.txtGirisSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.pbGiris = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGiris)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGirisTckNo
            // 
            this.lblGirisTckNo.AutoSize = true;
            this.lblGirisTckNo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisTckNo.Location = new System.Drawing.Point(9, 131);
            this.lblGirisTckNo.Name = "lblGirisTckNo";
            this.lblGirisTckNo.Size = new System.Drawing.Size(65, 16);
            this.lblGirisTckNo.TabIndex = 0;
            this.lblGirisTckNo.Text = "TCKNO:";
            // 
            // lblGirisSifre
            // 
            this.lblGirisSifre.AutoSize = true;
            this.lblGirisSifre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisSifre.Location = new System.Drawing.Point(9, 167);
            this.lblGirisSifre.Name = "lblGirisSifre";
            this.lblGirisSifre.Size = new System.Drawing.Size(58, 16);
            this.lblGirisSifre.TabIndex = 1;
            this.lblGirisSifre.Text = "ŞİFRE:";
            // 
            // txtGirisTckNo
            // 
            this.txtGirisTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirisTckNo.Location = new System.Drawing.Point(80, 131);
            this.txtGirisTckNo.Name = "txtGirisTckNo";
            this.txtGirisTckNo.Size = new System.Drawing.Size(108, 21);
            this.txtGirisTckNo.TabIndex = 2;
            // 
            // txtGirisSifre
            // 
            this.txtGirisSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirisSifre.Location = new System.Drawing.Point(80, 163);
            this.txtGirisSifre.Name = "txtGirisSifre";
            this.txtGirisSifre.PasswordChar = '●';
            this.txtGirisSifre.Size = new System.Drawing.Size(108, 21);
            this.txtGirisSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGiris.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(43, 195);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(85, 30);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pbGiris
            // 
            this.pbGiris.BackColor = System.Drawing.Color.DarkCyan;
            this.pbGiris.Image = ((System.Drawing.Image)(resources.GetObject("pbGiris.Image")));
            this.pbGiris.Location = new System.Drawing.Point(12, 12);
            this.pbGiris.Name = "pbGiris";
            this.pbGiris.Size = new System.Drawing.Size(176, 102);
            this.pbGiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGiris.TabIndex = 5;
            this.pbGiris.TabStop = false;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(204, 235);
            this.Controls.Add(this.pbGiris);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtGirisSifre);
            this.Controls.Add(this.txtGirisTckNo);
            this.Controls.Add(this.lblGirisSifre);
            this.Controls.Add(this.lblGirisTckNo);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "FrmGiris";
            this.Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pbGiris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGirisTckNo;
        private System.Windows.Forms.Label lblGirisSifre;
        private System.Windows.Forms.TextBox txtGirisTckNo;
        private System.Windows.Forms.TextBox txtGirisSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.PictureBox pbGiris;
    }
}

