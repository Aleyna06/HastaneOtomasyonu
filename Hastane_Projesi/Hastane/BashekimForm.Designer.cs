
namespace Hastane
{
    partial class FrmBashekim
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
            this.btnDoktorKaydet = new System.Windows.Forms.Button();
            this.txtDoktorSifre = new System.Windows.Forms.TextBox();
            this.txtDoktorTckNo = new System.Windows.Forms.TextBox();
            this.txtDoktorSoyad = new System.Windows.Forms.TextBox();
            this.txtDoktorAd = new System.Windows.Forms.TextBox();
            this.lblDoktorBolum = new System.Windows.Forms.Label();
            this.lblDoktorSifre = new System.Windows.Forms.Label();
            this.lblDoktorTckNo = new System.Windows.Forms.Label();
            this.lblDoktorSoyad = new System.Windows.Forms.Label();
            this.lblDoktorAd = new System.Windows.Forms.Label();
            this.cmbDoktorBolum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDoktorKaydet
            // 
            this.btnDoktorKaydet.BackColor = System.Drawing.Color.Lime;
            this.btnDoktorKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorKaydet.Location = new System.Drawing.Point(117, 210);
            this.btnDoktorKaydet.Name = "btnDoktorKaydet";
            this.btnDoktorKaydet.Size = new System.Drawing.Size(103, 29);
            this.btnDoktorKaydet.TabIndex = 21;
            this.btnDoktorKaydet.Text = "Kaydet";
            this.btnDoktorKaydet.UseVisualStyleBackColor = false;
            this.btnDoktorKaydet.Click += new System.EventHandler(this.btnDoktorKaydet_Click);
            // 
            // txtDoktorSifre
            // 
            this.txtDoktorSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoktorSifre.Location = new System.Drawing.Point(177, 138);
            this.txtDoktorSifre.Name = "txtDoktorSifre";
            this.txtDoktorSifre.PasswordChar = '●';
            this.txtDoktorSifre.Size = new System.Drawing.Size(103, 21);
            this.txtDoktorSifre.TabIndex = 19;
            // 
            // txtDoktorTckNo
            // 
            this.txtDoktorTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoktorTckNo.Location = new System.Drawing.Point(177, 102);
            this.txtDoktorTckNo.Name = "txtDoktorTckNo";
            this.txtDoktorTckNo.Size = new System.Drawing.Size(103, 21);
            this.txtDoktorTckNo.TabIndex = 18;
            // 
            // txtDoktorSoyad
            // 
            this.txtDoktorSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoktorSoyad.Location = new System.Drawing.Point(177, 66);
            this.txtDoktorSoyad.Name = "txtDoktorSoyad";
            this.txtDoktorSoyad.Size = new System.Drawing.Size(103, 21);
            this.txtDoktorSoyad.TabIndex = 17;
            // 
            // txtDoktorAd
            // 
            this.txtDoktorAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoktorAd.Location = new System.Drawing.Point(177, 30);
            this.txtDoktorAd.Name = "txtDoktorAd";
            this.txtDoktorAd.Size = new System.Drawing.Size(103, 21);
            this.txtDoktorAd.TabIndex = 16;
            // 
            // lblDoktorBolum
            // 
            this.lblDoktorBolum.AutoSize = true;
            this.lblDoktorBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorBolum.Location = new System.Drawing.Point(34, 173);
            this.lblDoktorBolum.Name = "lblDoktorBolum";
            this.lblDoktorBolum.Size = new System.Drawing.Size(127, 18);
            this.lblDoktorBolum.TabIndex = 15;
            this.lblDoktorBolum.Text = "Doktor Bölümü:";
            // 
            // lblDoktorSifre
            // 
            this.lblDoktorSifre.AutoSize = true;
            this.lblDoktorSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorSifre.Location = new System.Drawing.Point(34, 137);
            this.lblDoktorSifre.Name = "lblDoktorSifre";
            this.lblDoktorSifre.Size = new System.Drawing.Size(118, 18);
            this.lblDoktorSifre.TabIndex = 14;
            this.lblDoktorSifre.Text = "Doktor Şifresi:";
            // 
            // lblDoktorTckNo
            // 
            this.lblDoktorTckNo.AutoSize = true;
            this.lblDoktorTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorTckNo.Location = new System.Drawing.Point(34, 101);
            this.lblDoktorTckNo.Name = "lblDoktorTckNo";
            this.lblDoktorTckNo.Size = new System.Drawing.Size(128, 18);
            this.lblDoktorTckNo.TabIndex = 13;
            this.lblDoktorTckNo.Text = "Doktor TCKNO:";
            // 
            // lblDoktorSoyad
            // 
            this.lblDoktorSoyad.AutoSize = true;
            this.lblDoktorSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorSoyad.Location = new System.Drawing.Point(34, 65);
            this.lblDoktorSoyad.Name = "lblDoktorSoyad";
            this.lblDoktorSoyad.Size = new System.Drawing.Size(121, 18);
            this.lblDoktorSoyad.TabIndex = 12;
            this.lblDoktorSoyad.Text = "Doktor Soyadı:";
            // 
            // lblDoktorAd
            // 
            this.lblDoktorAd.AutoSize = true;
            this.lblDoktorAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorAd.Location = new System.Drawing.Point(34, 29);
            this.lblDoktorAd.Name = "lblDoktorAd";
            this.lblDoktorAd.Size = new System.Drawing.Size(93, 18);
            this.lblDoktorAd.TabIndex = 11;
            this.lblDoktorAd.Text = "Doktor Adı:";
            // 
            // cmbDoktorBolum
            // 
            this.cmbDoktorBolum.FormattingEnabled = true;
            this.cmbDoktorBolum.Items.AddRange(new object[] {
            "Diyetisyen",
            "Goz",
            "Cildiye",
            "Ortopedi"});
            this.cmbDoktorBolum.Location = new System.Drawing.Point(177, 174);
            this.cmbDoktorBolum.Name = "cmbDoktorBolum";
            this.cmbDoktorBolum.Size = new System.Drawing.Size(103, 21);
            this.cmbDoktorBolum.TabIndex = 22;
            // 
            // FrmBashekim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(322, 257);
            this.Controls.Add(this.cmbDoktorBolum);
            this.Controls.Add(this.btnDoktorKaydet);
            this.Controls.Add(this.txtDoktorSifre);
            this.Controls.Add(this.txtDoktorTckNo);
            this.Controls.Add(this.txtDoktorSoyad);
            this.Controls.Add(this.txtDoktorAd);
            this.Controls.Add(this.lblDoktorBolum);
            this.Controls.Add(this.lblDoktorSifre);
            this.Controls.Add(this.lblDoktorTckNo);
            this.Controls.Add(this.lblDoktorSoyad);
            this.Controls.Add(this.lblDoktorAd);
            this.Name = "FrmBashekim";
            this.Text = "Başhekim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoktorKaydet;
        private System.Windows.Forms.TextBox txtDoktorSifre;
        private System.Windows.Forms.TextBox txtDoktorTckNo;
        private System.Windows.Forms.TextBox txtDoktorSoyad;
        private System.Windows.Forms.TextBox txtDoktorAd;
        private System.Windows.Forms.Label lblDoktorBolum;
        private System.Windows.Forms.Label lblDoktorSifre;
        private System.Windows.Forms.Label lblDoktorTckNo;
        private System.Windows.Forms.Label lblDoktorSoyad;
        private System.Windows.Forms.Label lblDoktorAd;
        private System.Windows.Forms.ComboBox cmbDoktorBolum;
    }
}