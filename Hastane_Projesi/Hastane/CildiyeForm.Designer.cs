
namespace Hastane
{
    partial class FrmCildiye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCildiye));
            this.gbCHastaKayit = new System.Windows.Forms.GroupBox();
            this.btnCHastaKaydet = new System.Windows.Forms.Button();
            this.cmbCiltYontemi = new System.Windows.Forms.ComboBox();
            this.cmbCHastalık = new System.Windows.Forms.ComboBox();
            this.txtCHastaSoyad = new System.Windows.Forms.TextBox();
            this.txtCHastaAd = new System.Windows.Forms.TextBox();
            this.txtCHastaTckNo = new System.Windows.Forms.TextBox();
            this.lblCiltYontemi = new System.Windows.Forms.Label();
            this.lblCHastalık = new System.Windows.Forms.Label();
            this.lblCHastaSoyad = new System.Windows.Forms.Label();
            this.lblCHastaAd = new System.Windows.Forms.Label();
            this.lblCHastaTckNo = new System.Windows.Forms.Label();
            this.gbCHastaRapor = new System.Windows.Forms.GroupBox();
            this.cmbCRaporOnceligi = new System.Windows.Forms.ComboBox();
            this.lblCRaporOnceligi = new System.Windows.Forms.Label();
            this.btnCHastaRapor = new System.Windows.Forms.Button();
            this.cmbCRaporCesidi = new System.Windows.Forms.ComboBox();
            this.txtCHastaRprTckNo = new System.Windows.Forms.TextBox();
            this.lblCRaporCesidi = new System.Windows.Forms.Label();
            this.lblCHastaRprTckNo = new System.Windows.Forms.Label();
            this.lblCTckNo = new System.Windows.Forms.Label();
            this.txtTckNo = new System.Windows.Forms.TextBox();
            this.gbCHastaKayit.SuspendLayout();
            this.gbCHastaRapor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCHastaKayit
            // 
            this.gbCHastaKayit.BackColor = System.Drawing.Color.YellowGreen;
            this.gbCHastaKayit.Controls.Add(this.btnCHastaKaydet);
            this.gbCHastaKayit.Controls.Add(this.cmbCiltYontemi);
            this.gbCHastaKayit.Controls.Add(this.cmbCHastalık);
            this.gbCHastaKayit.Controls.Add(this.txtCHastaSoyad);
            this.gbCHastaKayit.Controls.Add(this.txtCHastaAd);
            this.gbCHastaKayit.Controls.Add(this.txtCHastaTckNo);
            this.gbCHastaKayit.Controls.Add(this.lblCiltYontemi);
            this.gbCHastaKayit.Controls.Add(this.lblCHastalık);
            this.gbCHastaKayit.Controls.Add(this.lblCHastaSoyad);
            this.gbCHastaKayit.Controls.Add(this.lblCHastaAd);
            this.gbCHastaKayit.Controls.Add(this.lblCHastaTckNo);
            this.gbCHastaKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbCHastaKayit.Location = new System.Drawing.Point(37, 42);
            this.gbCHastaKayit.Name = "gbCHastaKayit";
            this.gbCHastaKayit.Size = new System.Drawing.Size(281, 235);
            this.gbCHastaKayit.TabIndex = 1;
            this.gbCHastaKayit.TabStop = false;
            this.gbCHastaKayit.Text = "Hasta Kayıt";
            // 
            // btnCHastaKaydet
            // 
            this.btnCHastaKaydet.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCHastaKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCHastaKaydet.Location = new System.Drawing.Point(87, 176);
            this.btnCHastaKaydet.Name = "btnCHastaKaydet";
            this.btnCHastaKaydet.Size = new System.Drawing.Size(112, 40);
            this.btnCHastaKaydet.TabIndex = 10;
            this.btnCHastaKaydet.Text = "Hastayı Kaydet";
            this.btnCHastaKaydet.UseVisualStyleBackColor = false;
            this.btnCHastaKaydet.Click += new System.EventHandler(this.btnCHastaKaydet_Click);
            // 
            // cmbCiltYontemi
            // 
            this.cmbCiltYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCiltYontemi.FormattingEnabled = true;
            this.cmbCiltYontemi.Items.AddRange(new object[] {
            "Leke",
            "Doku",
            "Kristalize Fenol"});
            this.cmbCiltYontemi.Location = new System.Drawing.Point(150, 146);
            this.cmbCiltYontemi.Name = "cmbCiltYontemi";
            this.cmbCiltYontemi.Size = new System.Drawing.Size(121, 23);
            this.cmbCiltYontemi.TabIndex = 9;
            // 
            // cmbCHastalık
            // 
            this.cmbCHastalık.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCHastalık.FormattingEnabled = true;
            this.cmbCHastalık.Items.AddRange(new object[] {
            "Kıl Dönmesi",
            "Yanık",
            "Akne"});
            this.cmbCHastalık.Location = new System.Drawing.Point(150, 114);
            this.cmbCHastalık.Name = "cmbCHastalık";
            this.cmbCHastalık.Size = new System.Drawing.Size(121, 23);
            this.cmbCHastalık.TabIndex = 8;
            // 
            // txtCHastaSoyad
            // 
            this.txtCHastaSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCHastaSoyad.Location = new System.Drawing.Point(150, 82);
            this.txtCHastaSoyad.Name = "txtCHastaSoyad";
            this.txtCHastaSoyad.Size = new System.Drawing.Size(100, 21);
            this.txtCHastaSoyad.TabIndex = 7;
            // 
            // txtCHastaAd
            // 
            this.txtCHastaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCHastaAd.Location = new System.Drawing.Point(150, 51);
            this.txtCHastaAd.Name = "txtCHastaAd";
            this.txtCHastaAd.Size = new System.Drawing.Size(100, 21);
            this.txtCHastaAd.TabIndex = 6;
            // 
            // txtCHastaTckNo
            // 
            this.txtCHastaTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCHastaTckNo.Location = new System.Drawing.Point(150, 20);
            this.txtCHastaTckNo.Name = "txtCHastaTckNo";
            this.txtCHastaTckNo.Size = new System.Drawing.Size(100, 21);
            this.txtCHastaTckNo.TabIndex = 5;
            // 
            // lblCiltYontemi
            // 
            this.lblCiltYontemi.AutoSize = true;
            this.lblCiltYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCiltYontemi.Location = new System.Drawing.Point(22, 149);
            this.lblCiltYontemi.Name = "lblCiltYontemi";
            this.lblCiltYontemi.Size = new System.Drawing.Size(88, 15);
            this.lblCiltYontemi.TabIndex = 4;
            this.lblCiltYontemi.Text = "Cilt Yöntemi:";
            // 
            // lblCHastalık
            // 
            this.lblCHastalık.AutoSize = true;
            this.lblCHastalık.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCHastalık.Location = new System.Drawing.Point(22, 117);
            this.lblCHastalık.Name = "lblCHastalık";
            this.lblCHastalık.Size = new System.Drawing.Size(63, 15);
            this.lblCHastalık.TabIndex = 3;
            this.lblCHastalık.Text = "Hastalık:";
            // 
            // lblCHastaSoyad
            // 
            this.lblCHastaSoyad.AutoSize = true;
            this.lblCHastaSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCHastaSoyad.Location = new System.Drawing.Point(22, 86);
            this.lblCHastaSoyad.Name = "lblCHastaSoyad";
            this.lblCHastaSoyad.Size = new System.Drawing.Size(95, 15);
            this.lblCHastaSoyad.TabIndex = 2;
            this.lblCHastaSoyad.Text = "Hasta Soyadı:";
            // 
            // lblCHastaAd
            // 
            this.lblCHastaAd.AutoSize = true;
            this.lblCHastaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCHastaAd.Location = new System.Drawing.Point(22, 54);
            this.lblCHastaAd.Name = "lblCHastaAd";
            this.lblCHastaAd.Size = new System.Drawing.Size(72, 15);
            this.lblCHastaAd.TabIndex = 1;
            this.lblCHastaAd.Text = "Hasta Adı:";
            // 
            // lblCHastaTckNo
            // 
            this.lblCHastaTckNo.AutoSize = true;
            this.lblCHastaTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCHastaTckNo.Location = new System.Drawing.Point(22, 24);
            this.lblCHastaTckNo.Name = "lblCHastaTckNo";
            this.lblCHastaTckNo.Size = new System.Drawing.Size(102, 15);
            this.lblCHastaTckNo.TabIndex = 0;
            this.lblCHastaTckNo.Text = "Hasta TCKNO :";
            // 
            // gbCHastaRapor
            // 
            this.gbCHastaRapor.BackColor = System.Drawing.Color.YellowGreen;
            this.gbCHastaRapor.Controls.Add(this.cmbCRaporOnceligi);
            this.gbCHastaRapor.Controls.Add(this.lblCRaporOnceligi);
            this.gbCHastaRapor.Controls.Add(this.btnCHastaRapor);
            this.gbCHastaRapor.Controls.Add(this.cmbCRaporCesidi);
            this.gbCHastaRapor.Controls.Add(this.txtCHastaRprTckNo);
            this.gbCHastaRapor.Controls.Add(this.lblCRaporCesidi);
            this.gbCHastaRapor.Controls.Add(this.lblCHastaRprTckNo);
            this.gbCHastaRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbCHastaRapor.Location = new System.Drawing.Point(342, 42);
            this.gbCHastaRapor.Name = "gbCHastaRapor";
            this.gbCHastaRapor.Size = new System.Drawing.Size(281, 235);
            this.gbCHastaRapor.TabIndex = 2;
            this.gbCHastaRapor.TabStop = false;
            this.gbCHastaRapor.Text = "Hasta Rapor Al";
            // 
            // cmbCRaporOnceligi
            // 
            this.cmbCRaporOnceligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCRaporOnceligi.FormattingEnabled = true;
            this.cmbCRaporOnceligi.Items.AddRange(new object[] {
            "Kişi Bilgileri Öncelikli",
            "Hastalık Bilgileri Öncelikli"});
            this.cmbCRaporOnceligi.Location = new System.Drawing.Point(150, 114);
            this.cmbCRaporOnceligi.Name = "cmbCRaporOnceligi";
            this.cmbCRaporOnceligi.Size = new System.Drawing.Size(121, 23);
            this.cmbCRaporOnceligi.TabIndex = 13;
            // 
            // lblCRaporOnceligi
            // 
            this.lblCRaporOnceligi.AutoSize = true;
            this.lblCRaporOnceligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCRaporOnceligi.Location = new System.Drawing.Point(28, 118);
            this.lblCRaporOnceligi.Name = "lblCRaporOnceligi";
            this.lblCRaporOnceligi.Size = new System.Drawing.Size(107, 15);
            this.lblCRaporOnceligi.TabIndex = 12;
            this.lblCRaporOnceligi.Text = "Rapor Önceliği:";
            // 
            // btnCHastaRapor
            // 
            this.btnCHastaRapor.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCHastaRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCHastaRapor.Location = new System.Drawing.Point(87, 176);
            this.btnCHastaRapor.Name = "btnCHastaRapor";
            this.btnCHastaRapor.Size = new System.Drawing.Size(114, 40);
            this.btnCHastaRapor.TabIndex = 11;
            this.btnCHastaRapor.Text = "Rapor Oluştur";
            this.btnCHastaRapor.UseVisualStyleBackColor = false;
            this.btnCHastaRapor.Click += new System.EventHandler(this.btnCHastaRapor_Click);
            // 
            // cmbCRaporCesidi
            // 
            this.cmbCRaporCesidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCRaporCesidi.FormattingEnabled = true;
            this.cmbCRaporCesidi.Items.AddRange(new object[] {
            "HTML"});
            this.cmbCRaporCesidi.Location = new System.Drawing.Point(150, 82);
            this.cmbCRaporCesidi.Name = "cmbCRaporCesidi";
            this.cmbCRaporCesidi.Size = new System.Drawing.Size(121, 23);
            this.cmbCRaporCesidi.TabIndex = 7;
            // 
            // txtCHastaRprTckNo
            // 
            this.txtCHastaRprTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCHastaRprTckNo.Location = new System.Drawing.Point(150, 51);
            this.txtCHastaRprTckNo.Name = "txtCHastaRprTckNo";
            this.txtCHastaRprTckNo.Size = new System.Drawing.Size(100, 21);
            this.txtCHastaRprTckNo.TabIndex = 6;
            this.txtCHastaRprTckNo.TextChanged += new System.EventHandler(this.txtCHastaRprTckNo_TextChanged);
            // 
            // lblCRaporCesidi
            // 
            this.lblCRaporCesidi.AutoSize = true;
            this.lblCRaporCesidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCRaporCesidi.Location = new System.Drawing.Point(28, 86);
            this.lblCRaporCesidi.Name = "lblCRaporCesidi";
            this.lblCRaporCesidi.Size = new System.Drawing.Size(94, 15);
            this.lblCRaporCesidi.TabIndex = 2;
            this.lblCRaporCesidi.Text = "Rapor Çeşidi:";
            // 
            // lblCHastaRprTckNo
            // 
            this.lblCHastaRprTckNo.AutoSize = true;
            this.lblCHastaRprTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCHastaRprTckNo.Location = new System.Drawing.Point(28, 55);
            this.lblCHastaRprTckNo.Name = "lblCHastaRprTckNo";
            this.lblCHastaRprTckNo.Size = new System.Drawing.Size(102, 15);
            this.lblCHastaRprTckNo.TabIndex = 1;
            this.lblCHastaRprTckNo.Text = "Hasta TCKNO :";
            // 
            // lblCTckNo
            // 
            this.lblCTckNo.AutoSize = true;
            this.lblCTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCTckNo.Location = new System.Drawing.Point(34, 15);
            this.lblCTckNo.Name = "lblCTckNo";
            this.lblCTckNo.Size = new System.Drawing.Size(115, 16);
            this.lblCTckNo.TabIndex = 0;
            this.lblCTckNo.Text = "Cildiye TCKNO:";
            // 
            // txtTckNo
            // 
            this.txtTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTckNo.Location = new System.Drawing.Point(155, 12);
            this.txtTckNo.Name = "txtTckNo";
            this.txtTckNo.Size = new System.Drawing.Size(100, 22);
            this.txtTckNo.TabIndex = 3;
            // 
            // FrmCildiye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 308);
            this.Controls.Add(this.txtTckNo);
            this.Controls.Add(this.lblCTckNo);
            this.Controls.Add(this.gbCHastaRapor);
            this.Controls.Add(this.gbCHastaKayit);
            this.Name = "FrmCildiye";
            this.Text = "Cildiye Hasta İşlemleri";
            this.Load += new System.EventHandler(this.FrmCildiye_Load);
            this.gbCHastaKayit.ResumeLayout(false);
            this.gbCHastaKayit.PerformLayout();
            this.gbCHastaRapor.ResumeLayout(false);
            this.gbCHastaRapor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCHastaKayit;
        private System.Windows.Forms.Button btnCHastaKaydet;
        private System.Windows.Forms.ComboBox cmbCiltYontemi;
        private System.Windows.Forms.ComboBox cmbCHastalık;
        private System.Windows.Forms.TextBox txtCHastaSoyad;
        private System.Windows.Forms.TextBox txtCHastaAd;
        private System.Windows.Forms.TextBox txtCHastaTckNo;
        private System.Windows.Forms.Label lblCiltYontemi;
        private System.Windows.Forms.Label lblCHastalık;
        private System.Windows.Forms.Label lblCHastaSoyad;
        private System.Windows.Forms.Label lblCHastaAd;
        private System.Windows.Forms.Label lblCHastaTckNo;
        private System.Windows.Forms.GroupBox gbCHastaRapor;
        private System.Windows.Forms.Button btnCHastaRapor;
        private System.Windows.Forms.ComboBox cmbCRaporCesidi;
        private System.Windows.Forms.TextBox txtCHastaRprTckNo;
        private System.Windows.Forms.Label lblCRaporCesidi;
        private System.Windows.Forms.Label lblCHastaRprTckNo;
        private System.Windows.Forms.Label lblCTckNo;
        private System.Windows.Forms.TextBox txtTckNo;
        private System.Windows.Forms.ComboBox cmbCRaporOnceligi;
        private System.Windows.Forms.Label lblCRaporOnceligi;
    }
}