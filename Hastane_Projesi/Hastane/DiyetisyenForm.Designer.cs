
namespace Hastane
{
    partial class FrmDiyetisyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiyetisyen));
            this.gbDHastaKayit = new System.Windows.Forms.GroupBox();
            this.btnDHastaKaydet = new System.Windows.Forms.Button();
            this.cmbDiyetYontemi = new System.Windows.Forms.ComboBox();
            this.cmbDHastalık = new System.Windows.Forms.ComboBox();
            this.txtDHastaSoyad = new System.Windows.Forms.TextBox();
            this.txtDHastaAd = new System.Windows.Forms.TextBox();
            this.txtDHastaTckNo = new System.Windows.Forms.TextBox();
            this.lblDiyetYontemi = new System.Windows.Forms.Label();
            this.lblDHastalık = new System.Windows.Forms.Label();
            this.lblDHastaSoyad = new System.Windows.Forms.Label();
            this.lblDHastaAd = new System.Windows.Forms.Label();
            this.lblDHastaTckNo = new System.Windows.Forms.Label();
            this.gbDHastaRapor = new System.Windows.Forms.GroupBox();
            this.btnDHastaRapor = new System.Windows.Forms.Button();
            this.cmbDRaporCesidi = new System.Windows.Forms.ComboBox();
            this.txtDHastaRprTckNo = new System.Windows.Forms.TextBox();
            this.lblDRaporCesidi = new System.Windows.Forms.Label();
            this.lblDHastaRprTckNo = new System.Windows.Forms.Label();
            this.lblDTckNo = new System.Windows.Forms.Label();
            this.txtTckNo = new System.Windows.Forms.TextBox();
            this.cmbDRaporOnceligi = new System.Windows.Forms.ComboBox();
            this.lblDRaporOnceligi = new System.Windows.Forms.Label();
            this.gbDHastaKayit.SuspendLayout();
            this.gbDHastaRapor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDHastaKayit
            // 
            this.gbDHastaKayit.BackColor = System.Drawing.Color.YellowGreen;
            this.gbDHastaKayit.Controls.Add(this.btnDHastaKaydet);
            this.gbDHastaKayit.Controls.Add(this.cmbDiyetYontemi);
            this.gbDHastaKayit.Controls.Add(this.cmbDHastalık);
            this.gbDHastaKayit.Controls.Add(this.txtDHastaSoyad);
            this.gbDHastaKayit.Controls.Add(this.txtDHastaAd);
            this.gbDHastaKayit.Controls.Add(this.txtDHastaTckNo);
            this.gbDHastaKayit.Controls.Add(this.lblDiyetYontemi);
            this.gbDHastaKayit.Controls.Add(this.lblDHastalık);
            this.gbDHastaKayit.Controls.Add(this.lblDHastaSoyad);
            this.gbDHastaKayit.Controls.Add(this.lblDHastaAd);
            this.gbDHastaKayit.Controls.Add(this.lblDHastaTckNo);
            this.gbDHastaKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbDHastaKayit.Location = new System.Drawing.Point(37, 42);
            this.gbDHastaKayit.Name = "gbDHastaKayit";
            this.gbDHastaKayit.Size = new System.Drawing.Size(281, 235);
            this.gbDHastaKayit.TabIndex = 0;
            this.gbDHastaKayit.TabStop = false;
            this.gbDHastaKayit.Text = "Hasta Kayıt";
            // 
            // btnDHastaKaydet
            // 
            this.btnDHastaKaydet.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDHastaKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDHastaKaydet.Location = new System.Drawing.Point(87, 176);
            this.btnDHastaKaydet.Name = "btnDHastaKaydet";
            this.btnDHastaKaydet.Size = new System.Drawing.Size(112, 40);
            this.btnDHastaKaydet.TabIndex = 10;
            this.btnDHastaKaydet.Text = "Hastayı Kaydet";
            this.btnDHastaKaydet.UseVisualStyleBackColor = false;
            this.btnDHastaKaydet.Click += new System.EventHandler(this.btnDHastaKaydet_Click);
            // 
            // cmbDiyetYontemi
            // 
            this.cmbDiyetYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDiyetYontemi.FormattingEnabled = true;
            this.cmbDiyetYontemi.Items.AddRange(new object[] {
            "Akdeniz",
            "Gluten Free",
            "Deniz Urunleri",
            "Yesillikler Dunyasi"});
            this.cmbDiyetYontemi.Location = new System.Drawing.Point(150, 146);
            this.cmbDiyetYontemi.Name = "cmbDiyetYontemi";
            this.cmbDiyetYontemi.Size = new System.Drawing.Size(121, 23);
            this.cmbDiyetYontemi.TabIndex = 9;
            // 
            // cmbDHastalık
            // 
            this.cmbDHastalık.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDHastalık.FormattingEnabled = true;
            this.cmbDHastalık.Items.AddRange(new object[] {
            "Obez",
            "Seker",
            "Colyak"});
            this.cmbDHastalık.Location = new System.Drawing.Point(150, 114);
            this.cmbDHastalık.Name = "cmbDHastalık";
            this.cmbDHastalık.Size = new System.Drawing.Size(121, 23);
            this.cmbDHastalık.TabIndex = 8;
            // 
            // txtDHastaSoyad
            // 
            this.txtDHastaSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDHastaSoyad.Location = new System.Drawing.Point(150, 82);
            this.txtDHastaSoyad.Name = "txtDHastaSoyad";
            this.txtDHastaSoyad.Size = new System.Drawing.Size(100, 21);
            this.txtDHastaSoyad.TabIndex = 7;
            // 
            // txtDHastaAd
            // 
            this.txtDHastaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDHastaAd.Location = new System.Drawing.Point(150, 51);
            this.txtDHastaAd.Name = "txtDHastaAd";
            this.txtDHastaAd.Size = new System.Drawing.Size(100, 21);
            this.txtDHastaAd.TabIndex = 6;
            // 
            // txtDHastaTckNo
            // 
            this.txtDHastaTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDHastaTckNo.Location = new System.Drawing.Point(150, 20);
            this.txtDHastaTckNo.Name = "txtDHastaTckNo";
            this.txtDHastaTckNo.Size = new System.Drawing.Size(100, 21);
            this.txtDHastaTckNo.TabIndex = 5;
            // 
            // lblDiyetYontemi
            // 
            this.lblDiyetYontemi.AutoSize = true;
            this.lblDiyetYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDiyetYontemi.Location = new System.Drawing.Point(22, 149);
            this.lblDiyetYontemi.Name = "lblDiyetYontemi";
            this.lblDiyetYontemi.Size = new System.Drawing.Size(99, 15);
            this.lblDiyetYontemi.TabIndex = 4;
            this.lblDiyetYontemi.Text = "Diyet Yöntemi:";
            // 
            // lblDHastalık
            // 
            this.lblDHastalık.AutoSize = true;
            this.lblDHastalık.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDHastalık.Location = new System.Drawing.Point(22, 117);
            this.lblDHastalık.Name = "lblDHastalık";
            this.lblDHastalık.Size = new System.Drawing.Size(63, 15);
            this.lblDHastalık.TabIndex = 3;
            this.lblDHastalık.Text = "Hastalık:";
            // 
            // lblDHastaSoyad
            // 
            this.lblDHastaSoyad.AutoSize = true;
            this.lblDHastaSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDHastaSoyad.Location = new System.Drawing.Point(22, 86);
            this.lblDHastaSoyad.Name = "lblDHastaSoyad";
            this.lblDHastaSoyad.Size = new System.Drawing.Size(95, 15);
            this.lblDHastaSoyad.TabIndex = 2;
            this.lblDHastaSoyad.Text = "Hasta Soyadı:";
            // 
            // lblDHastaAd
            // 
            this.lblDHastaAd.AutoSize = true;
            this.lblDHastaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDHastaAd.Location = new System.Drawing.Point(22, 54);
            this.lblDHastaAd.Name = "lblDHastaAd";
            this.lblDHastaAd.Size = new System.Drawing.Size(72, 15);
            this.lblDHastaAd.TabIndex = 1;
            this.lblDHastaAd.Text = "Hasta Adı:";
            // 
            // lblDHastaTckNo
            // 
            this.lblDHastaTckNo.AutoSize = true;
            this.lblDHastaTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDHastaTckNo.Location = new System.Drawing.Point(22, 24);
            this.lblDHastaTckNo.Name = "lblDHastaTckNo";
            this.lblDHastaTckNo.Size = new System.Drawing.Size(102, 15);
            this.lblDHastaTckNo.TabIndex = 0;
            this.lblDHastaTckNo.Text = "Hasta TCKNO :";
            // 
            // gbDHastaRapor
            // 
            this.gbDHastaRapor.BackColor = System.Drawing.Color.YellowGreen;
            this.gbDHastaRapor.Controls.Add(this.btnDHastaRapor);
            this.gbDHastaRapor.Controls.Add(this.cmbDRaporOnceligi);
            this.gbDHastaRapor.Controls.Add(this.cmbDRaporCesidi);
            this.gbDHastaRapor.Controls.Add(this.txtDHastaRprTckNo);
            this.gbDHastaRapor.Controls.Add(this.lblDRaporOnceligi);
            this.gbDHastaRapor.Controls.Add(this.lblDRaporCesidi);
            this.gbDHastaRapor.Controls.Add(this.lblDHastaRprTckNo);
            this.gbDHastaRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbDHastaRapor.Location = new System.Drawing.Point(342, 42);
            this.gbDHastaRapor.Name = "gbDHastaRapor";
            this.gbDHastaRapor.Size = new System.Drawing.Size(281, 235);
            this.gbDHastaRapor.TabIndex = 1;
            this.gbDHastaRapor.TabStop = false;
            this.gbDHastaRapor.Text = "Hasta Rapor Al";
            // 
            // btnDHastaRapor
            // 
            this.btnDHastaRapor.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDHastaRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDHastaRapor.Location = new System.Drawing.Point(87, 176);
            this.btnDHastaRapor.Name = "btnDHastaRapor";
            this.btnDHastaRapor.Size = new System.Drawing.Size(114, 40);
            this.btnDHastaRapor.TabIndex = 11;
            this.btnDHastaRapor.Text = "Rapor Oluştur";
            this.btnDHastaRapor.UseVisualStyleBackColor = false;
            this.btnDHastaRapor.Click += new System.EventHandler(this.btnDHastaRapor_Click_1);
            // 
            // cmbDRaporCesidi
            // 
            this.cmbDRaporCesidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDRaporCesidi.FormattingEnabled = true;
            this.cmbDRaporCesidi.Items.AddRange(new object[] {
            "HTML"});
            this.cmbDRaporCesidi.Location = new System.Drawing.Point(150, 82);
            this.cmbDRaporCesidi.Name = "cmbDRaporCesidi";
            this.cmbDRaporCesidi.Size = new System.Drawing.Size(121, 23);
            this.cmbDRaporCesidi.TabIndex = 7;
            // 
            // txtDHastaRprTckNo
            // 
            this.txtDHastaRprTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDHastaRprTckNo.Location = new System.Drawing.Point(150, 51);
            this.txtDHastaRprTckNo.Name = "txtDHastaRprTckNo";
            this.txtDHastaRprTckNo.Size = new System.Drawing.Size(100, 21);
            this.txtDHastaRprTckNo.TabIndex = 6;
            this.txtDHastaRprTckNo.TextChanged += new System.EventHandler(this.txtDHastaRprTckNo_TextChanged_1);
            // 
            // lblDRaporCesidi
            // 
            this.lblDRaporCesidi.AutoSize = true;
            this.lblDRaporCesidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDRaporCesidi.Location = new System.Drawing.Point(28, 86);
            this.lblDRaporCesidi.Name = "lblDRaporCesidi";
            this.lblDRaporCesidi.Size = new System.Drawing.Size(94, 15);
            this.lblDRaporCesidi.TabIndex = 2;
            this.lblDRaporCesidi.Text = "Rapor Çeşidi:";
            // 
            // lblDHastaRprTckNo
            // 
            this.lblDHastaRprTckNo.AutoSize = true;
            this.lblDHastaRprTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDHastaRprTckNo.Location = new System.Drawing.Point(28, 55);
            this.lblDHastaRprTckNo.Name = "lblDHastaRprTckNo";
            this.lblDHastaRprTckNo.Size = new System.Drawing.Size(102, 15);
            this.lblDHastaRprTckNo.TabIndex = 1;
            this.lblDHastaRprTckNo.Text = "Hasta TCKNO :";
            // 
            // lblDTckNo
            // 
            this.lblDTckNo.AutoSize = true;
            this.lblDTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDTckNo.Location = new System.Drawing.Point(34, 15);
            this.lblDTckNo.Name = "lblDTckNo";
            this.lblDTckNo.Size = new System.Drawing.Size(140, 16);
            this.lblDTckNo.TabIndex = 2;
            this.lblDTckNo.Text = "Diyetisyen TCKNO:";
            // 
            // txtTckNo
            // 
            this.txtTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTckNo.Location = new System.Drawing.Point(187, 12);
            this.txtTckNo.Name = "txtTckNo";
            this.txtTckNo.Size = new System.Drawing.Size(100, 22);
            this.txtTckNo.TabIndex = 3;
            // 
            // cmbDRaporOnceligi
            // 
            this.cmbDRaporOnceligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDRaporOnceligi.FormattingEnabled = true;
            this.cmbDRaporOnceligi.Items.AddRange(new object[] {
            "Kişi Bilgileri Öncelikli",
            "Hastalık Bilgileri Öncelikli"});
            this.cmbDRaporOnceligi.Location = new System.Drawing.Point(150, 114);
            this.cmbDRaporOnceligi.Name = "cmbDRaporOnceligi";
            this.cmbDRaporOnceligi.Size = new System.Drawing.Size(121, 23);
            this.cmbDRaporOnceligi.TabIndex = 8;
            // 
            // lblDRaporOnceligi
            // 
            this.lblDRaporOnceligi.AutoSize = true;
            this.lblDRaporOnceligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDRaporOnceligi.Location = new System.Drawing.Point(28, 118);
            this.lblDRaporOnceligi.Name = "lblDRaporOnceligi";
            this.lblDRaporOnceligi.Size = new System.Drawing.Size(107, 15);
            this.lblDRaporOnceligi.TabIndex = 3;
            this.lblDRaporOnceligi.Text = "Rapor Önceliği:";
            // 
            // FrmDiyetisyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 308);
            this.Controls.Add(this.txtTckNo);
            this.Controls.Add(this.lblDTckNo);
            this.Controls.Add(this.gbDHastaRapor);
            this.Controls.Add(this.gbDHastaKayit);
            this.Name = "FrmDiyetisyen";
            this.Text = "Diyetisyen Hasta İşlemleri";
            this.Load += new System.EventHandler(this.FrmDiyetisyen_Load);
            this.gbDHastaKayit.ResumeLayout(false);
            this.gbDHastaKayit.PerformLayout();
            this.gbDHastaRapor.ResumeLayout(false);
            this.gbDHastaRapor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDHastaKayit;
        private System.Windows.Forms.GroupBox gbDHastaRapor;
        private System.Windows.Forms.Label lblDHastalık;
        private System.Windows.Forms.Label lblDHastaSoyad;
        private System.Windows.Forms.Label lblDHastaAd;
        private System.Windows.Forms.Label lblDHastaTckNo;
        private System.Windows.Forms.TextBox txtDHastaSoyad;
        private System.Windows.Forms.TextBox txtDHastaAd;
        private System.Windows.Forms.TextBox txtDHastaTckNo;
        private System.Windows.Forms.Label lblDiyetYontemi;
        private System.Windows.Forms.Button btnDHastaKaydet;
        private System.Windows.Forms.ComboBox cmbDiyetYontemi;
        private System.Windows.Forms.ComboBox cmbDHastalık;
        private System.Windows.Forms.Button btnDHastaRapor;
        private System.Windows.Forms.ComboBox cmbDRaporCesidi;
        private System.Windows.Forms.TextBox txtDHastaRprTckNo;
        private System.Windows.Forms.Label lblDRaporCesidi;
        private System.Windows.Forms.Label lblDHastaRprTckNo;
        private System.Windows.Forms.Label lblDTckNo;
        private System.Windows.Forms.TextBox txtTckNo;
        private System.Windows.Forms.ComboBox cmbDRaporOnceligi;
        private System.Windows.Forms.Label lblDRaporOnceligi;
    }
}