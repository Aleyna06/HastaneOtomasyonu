
namespace Hastane
{
    partial class FrmGoz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGoz));
            this.gbGHastaKayit = new System.Windows.Forms.GroupBox();
            this.btnGHastaKaydet = new System.Windows.Forms.Button();
            this.cmbGozYontemi = new System.Windows.Forms.ComboBox();
            this.cmbGHastalık = new System.Windows.Forms.ComboBox();
            this.txtGHastaSoyad = new System.Windows.Forms.TextBox();
            this.txtGHastaAd = new System.Windows.Forms.TextBox();
            this.txtGHastaTckNo = new System.Windows.Forms.TextBox();
            this.lblGozYontemi = new System.Windows.Forms.Label();
            this.lblGHastalık = new System.Windows.Forms.Label();
            this.lblGHastaSoyad = new System.Windows.Forms.Label();
            this.lblGHastaAd = new System.Windows.Forms.Label();
            this.lblGHastaTckNo = new System.Windows.Forms.Label();
            this.gbGHastaRapor = new System.Windows.Forms.GroupBox();
            this.cmbGRaporOnceligi = new System.Windows.Forms.ComboBox();
            this.lblGRaporOnceligi = new System.Windows.Forms.Label();
            this.btnGHastaRapor = new System.Windows.Forms.Button();
            this.cmbGRaporCesidi = new System.Windows.Forms.ComboBox();
            this.txtGHastaRprTckNo = new System.Windows.Forms.TextBox();
            this.lblGRaporCesidi = new System.Windows.Forms.Label();
            this.lblGHastaRprTckNo = new System.Windows.Forms.Label();
            this.lblGTckNo = new System.Windows.Forms.Label();
            this.txtTckNo = new System.Windows.Forms.TextBox();
            this.gbGHastaKayit.SuspendLayout();
            this.gbGHastaRapor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGHastaKayit
            // 
            this.gbGHastaKayit.BackColor = System.Drawing.Color.YellowGreen;
            this.gbGHastaKayit.Controls.Add(this.btnGHastaKaydet);
            this.gbGHastaKayit.Controls.Add(this.cmbGozYontemi);
            this.gbGHastaKayit.Controls.Add(this.cmbGHastalık);
            this.gbGHastaKayit.Controls.Add(this.txtGHastaSoyad);
            this.gbGHastaKayit.Controls.Add(this.txtGHastaAd);
            this.gbGHastaKayit.Controls.Add(this.txtGHastaTckNo);
            this.gbGHastaKayit.Controls.Add(this.lblGozYontemi);
            this.gbGHastaKayit.Controls.Add(this.lblGHastalık);
            this.gbGHastaKayit.Controls.Add(this.lblGHastaSoyad);
            this.gbGHastaKayit.Controls.Add(this.lblGHastaAd);
            this.gbGHastaKayit.Controls.Add(this.lblGHastaTckNo);
            this.gbGHastaKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbGHastaKayit.Location = new System.Drawing.Point(37, 42);
            this.gbGHastaKayit.Name = "gbGHastaKayit";
            this.gbGHastaKayit.Size = new System.Drawing.Size(281, 235);
            this.gbGHastaKayit.TabIndex = 2;
            this.gbGHastaKayit.TabStop = false;
            this.gbGHastaKayit.Text = "Hasta Kayıt";
            // 
            // btnGHastaKaydet
            // 
            this.btnGHastaKaydet.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGHastaKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGHastaKaydet.Location = new System.Drawing.Point(87, 176);
            this.btnGHastaKaydet.Name = "btnGHastaKaydet";
            this.btnGHastaKaydet.Size = new System.Drawing.Size(112, 40);
            this.btnGHastaKaydet.TabIndex = 10;
            this.btnGHastaKaydet.Text = "Hastayı Kaydet";
            this.btnGHastaKaydet.UseVisualStyleBackColor = false;
            this.btnGHastaKaydet.Click += new System.EventHandler(this.btnGHastaKaydet_Click);
            // 
            // cmbGozYontemi
            // 
            this.cmbGozYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGozYontemi.FormattingEnabled = true;
            this.cmbGozYontemi.Items.AddRange(new object[] {
            "Lazer",
            "Fako",
            "Lasik"});
            this.cmbGozYontemi.Location = new System.Drawing.Point(150, 146);
            this.cmbGozYontemi.Name = "cmbGozYontemi";
            this.cmbGozYontemi.Size = new System.Drawing.Size(121, 23);
            this.cmbGozYontemi.TabIndex = 9;
            // 
            // cmbGHastalık
            // 
            this.cmbGHastalık.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGHastalık.FormattingEnabled = true;
            this.cmbGHastalık.Items.AddRange(new object[] {
            "Miyop",
            "Hipermetrop",
            "Astigmat"});
            this.cmbGHastalık.Location = new System.Drawing.Point(150, 114);
            this.cmbGHastalık.Name = "cmbGHastalık";
            this.cmbGHastalık.Size = new System.Drawing.Size(121, 23);
            this.cmbGHastalık.TabIndex = 8;
            // 
            // txtGHastaSoyad
            // 
            this.txtGHastaSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGHastaSoyad.Location = new System.Drawing.Point(150, 82);
            this.txtGHastaSoyad.Name = "txtGHastaSoyad";
            this.txtGHastaSoyad.Size = new System.Drawing.Size(100, 21);
            this.txtGHastaSoyad.TabIndex = 7;
            // 
            // txtGHastaAd
            // 
            this.txtGHastaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGHastaAd.Location = new System.Drawing.Point(150, 51);
            this.txtGHastaAd.Name = "txtGHastaAd";
            this.txtGHastaAd.Size = new System.Drawing.Size(100, 21);
            this.txtGHastaAd.TabIndex = 6;
            // 
            // txtGHastaTckNo
            // 
            this.txtGHastaTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGHastaTckNo.Location = new System.Drawing.Point(150, 20);
            this.txtGHastaTckNo.Name = "txtGHastaTckNo";
            this.txtGHastaTckNo.Size = new System.Drawing.Size(100, 21);
            this.txtGHastaTckNo.TabIndex = 5;
            // 
            // lblGozYontemi
            // 
            this.lblGozYontemi.AutoSize = true;
            this.lblGozYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGozYontemi.Location = new System.Drawing.Point(22, 149);
            this.lblGozYontemi.Name = "lblGozYontemi";
            this.lblGozYontemi.Size = new System.Drawing.Size(92, 15);
            this.lblGozYontemi.TabIndex = 4;
            this.lblGozYontemi.Text = "Göz Yöntemi:";
            // 
            // lblGHastalık
            // 
            this.lblGHastalık.AutoSize = true;
            this.lblGHastalık.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGHastalık.Location = new System.Drawing.Point(22, 117);
            this.lblGHastalık.Name = "lblGHastalık";
            this.lblGHastalık.Size = new System.Drawing.Size(63, 15);
            this.lblGHastalık.TabIndex = 3;
            this.lblGHastalık.Text = "Hastalık:";
            // 
            // lblGHastaSoyad
            // 
            this.lblGHastaSoyad.AutoSize = true;
            this.lblGHastaSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGHastaSoyad.Location = new System.Drawing.Point(22, 86);
            this.lblGHastaSoyad.Name = "lblGHastaSoyad";
            this.lblGHastaSoyad.Size = new System.Drawing.Size(95, 15);
            this.lblGHastaSoyad.TabIndex = 2;
            this.lblGHastaSoyad.Text = "Hasta Soyadı:";
            // 
            // lblGHastaAd
            // 
            this.lblGHastaAd.AutoSize = true;
            this.lblGHastaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGHastaAd.Location = new System.Drawing.Point(22, 54);
            this.lblGHastaAd.Name = "lblGHastaAd";
            this.lblGHastaAd.Size = new System.Drawing.Size(72, 15);
            this.lblGHastaAd.TabIndex = 1;
            this.lblGHastaAd.Text = "Hasta Adı:";
            // 
            // lblGHastaTckNo
            // 
            this.lblGHastaTckNo.AutoSize = true;
            this.lblGHastaTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGHastaTckNo.Location = new System.Drawing.Point(22, 24);
            this.lblGHastaTckNo.Name = "lblGHastaTckNo";
            this.lblGHastaTckNo.Size = new System.Drawing.Size(102, 15);
            this.lblGHastaTckNo.TabIndex = 0;
            this.lblGHastaTckNo.Text = "Hasta TCKNO :";
            // 
            // gbGHastaRapor
            // 
            this.gbGHastaRapor.BackColor = System.Drawing.Color.YellowGreen;
            this.gbGHastaRapor.Controls.Add(this.cmbGRaporOnceligi);
            this.gbGHastaRapor.Controls.Add(this.lblGRaporOnceligi);
            this.gbGHastaRapor.Controls.Add(this.btnGHastaRapor);
            this.gbGHastaRapor.Controls.Add(this.cmbGRaporCesidi);
            this.gbGHastaRapor.Controls.Add(this.txtGHastaRprTckNo);
            this.gbGHastaRapor.Controls.Add(this.lblGRaporCesidi);
            this.gbGHastaRapor.Controls.Add(this.lblGHastaRprTckNo);
            this.gbGHastaRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbGHastaRapor.Location = new System.Drawing.Point(342, 42);
            this.gbGHastaRapor.Name = "gbGHastaRapor";
            this.gbGHastaRapor.Size = new System.Drawing.Size(281, 235);
            this.gbGHastaRapor.TabIndex = 11;
            this.gbGHastaRapor.TabStop = false;
            this.gbGHastaRapor.Text = "Hasta Rapor Al";
            // 
            // cmbGRaporOnceligi
            // 
            this.cmbGRaporOnceligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGRaporOnceligi.FormattingEnabled = true;
            this.cmbGRaporOnceligi.Items.AddRange(new object[] {
            "Kişi Bilgileri Öncelikli",
            "Hastalık Bilgileri Öncelikli"});
            this.cmbGRaporOnceligi.Location = new System.Drawing.Point(150, 114);
            this.cmbGRaporOnceligi.Name = "cmbGRaporOnceligi";
            this.cmbGRaporOnceligi.Size = new System.Drawing.Size(121, 23);
            this.cmbGRaporOnceligi.TabIndex = 15;
            // 
            // lblGRaporOnceligi
            // 
            this.lblGRaporOnceligi.AutoSize = true;
            this.lblGRaporOnceligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGRaporOnceligi.Location = new System.Drawing.Point(28, 118);
            this.lblGRaporOnceligi.Name = "lblGRaporOnceligi";
            this.lblGRaporOnceligi.Size = new System.Drawing.Size(107, 15);
            this.lblGRaporOnceligi.TabIndex = 14;
            this.lblGRaporOnceligi.Text = "Rapor Önceliği:";
            // 
            // btnGHastaRapor
            // 
            this.btnGHastaRapor.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGHastaRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGHastaRapor.Location = new System.Drawing.Point(87, 176);
            this.btnGHastaRapor.Name = "btnGHastaRapor";
            this.btnGHastaRapor.Size = new System.Drawing.Size(114, 40);
            this.btnGHastaRapor.TabIndex = 11;
            this.btnGHastaRapor.Text = "Rapor Oluştur";
            this.btnGHastaRapor.UseVisualStyleBackColor = false;
            this.btnGHastaRapor.Click += new System.EventHandler(this.btnGHastaRapor_Click);
            // 
            // cmbGRaporCesidi
            // 
            this.cmbGRaporCesidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGRaporCesidi.FormattingEnabled = true;
            this.cmbGRaporCesidi.Items.AddRange(new object[] {
            "HTML"});
            this.cmbGRaporCesidi.Location = new System.Drawing.Point(150, 82);
            this.cmbGRaporCesidi.Name = "cmbGRaporCesidi";
            this.cmbGRaporCesidi.Size = new System.Drawing.Size(121, 23);
            this.cmbGRaporCesidi.TabIndex = 7;
            // 
            // txtGHastaRprTckNo
            // 
            this.txtGHastaRprTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGHastaRprTckNo.Location = new System.Drawing.Point(150, 51);
            this.txtGHastaRprTckNo.Name = "txtGHastaRprTckNo";
            this.txtGHastaRprTckNo.Size = new System.Drawing.Size(100, 21);
            this.txtGHastaRprTckNo.TabIndex = 6;
            this.txtGHastaRprTckNo.TextChanged += new System.EventHandler(this.txtGHastaRprTckNo_TextChanged);
            // 
            // lblGRaporCesidi
            // 
            this.lblGRaporCesidi.AutoSize = true;
            this.lblGRaporCesidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGRaporCesidi.Location = new System.Drawing.Point(28, 86);
            this.lblGRaporCesidi.Name = "lblGRaporCesidi";
            this.lblGRaporCesidi.Size = new System.Drawing.Size(94, 15);
            this.lblGRaporCesidi.TabIndex = 2;
            this.lblGRaporCesidi.Text = "Rapor Çeşidi:";
            // 
            // lblGHastaRprTckNo
            // 
            this.lblGHastaRprTckNo.AutoSize = true;
            this.lblGHastaRprTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGHastaRprTckNo.Location = new System.Drawing.Point(28, 55);
            this.lblGHastaRprTckNo.Name = "lblGHastaRprTckNo";
            this.lblGHastaRprTckNo.Size = new System.Drawing.Size(102, 15);
            this.lblGHastaRprTckNo.TabIndex = 1;
            this.lblGHastaRprTckNo.Text = "Hasta TCKNO :";
            // 
            // lblGTckNo
            // 
            this.lblGTckNo.AutoSize = true;
            this.lblGTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGTckNo.Location = new System.Drawing.Point(34, 15);
            this.lblGTckNo.Name = "lblGTckNo";
            this.lblGTckNo.Size = new System.Drawing.Size(94, 16);
            this.lblGTckNo.TabIndex = 12;
            this.lblGTckNo.Text = "Göz TCKNO:";
            // 
            // txtTckNo
            // 
            this.txtTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTckNo.Location = new System.Drawing.Point(136, 12);
            this.txtTckNo.Name = "txtTckNo";
            this.txtTckNo.Size = new System.Drawing.Size(100, 22);
            this.txtTckNo.TabIndex = 13;
            // 
            // FrmGoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(653, 310);
            this.Controls.Add(this.txtTckNo);
            this.Controls.Add(this.lblGTckNo);
            this.Controls.Add(this.gbGHastaRapor);
            this.Controls.Add(this.gbGHastaKayit);
            this.Name = "FrmGoz";
            this.Text = "Göz Hasta İşlemleri";
            this.Load += new System.EventHandler(this.FrmGoz_Load);
            this.gbGHastaKayit.ResumeLayout(false);
            this.gbGHastaKayit.PerformLayout();
            this.gbGHastaRapor.ResumeLayout(false);
            this.gbGHastaRapor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGHastaKayit;
        private System.Windows.Forms.Button btnGHastaKaydet;
        private System.Windows.Forms.ComboBox cmbGozYontemi;
        private System.Windows.Forms.ComboBox cmbGHastalık;
        private System.Windows.Forms.TextBox txtGHastaSoyad;
        private System.Windows.Forms.TextBox txtGHastaAd;
        private System.Windows.Forms.TextBox txtGHastaTckNo;
        private System.Windows.Forms.Label lblGozYontemi;
        private System.Windows.Forms.Label lblGHastalık;
        private System.Windows.Forms.Label lblGHastaSoyad;
        private System.Windows.Forms.Label lblGHastaAd;
        private System.Windows.Forms.Label lblGHastaTckNo;
        private System.Windows.Forms.GroupBox gbGHastaRapor;
        private System.Windows.Forms.Button btnGHastaRapor;
        private System.Windows.Forms.ComboBox cmbGRaporCesidi;
        private System.Windows.Forms.TextBox txtGHastaRprTckNo;
        private System.Windows.Forms.Label lblGRaporCesidi;
        private System.Windows.Forms.Label lblGHastaRprTckNo;
        private System.Windows.Forms.Label lblGTckNo;
        private System.Windows.Forms.TextBox txtTckNo;
        private System.Windows.Forms.ComboBox cmbGRaporOnceligi;
        private System.Windows.Forms.Label lblGRaporOnceligi;
    }
}