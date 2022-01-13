
namespace Hastane
{
    partial class FrmOrtopedi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrtopedi));
            this.gbOHastaKayit = new System.Windows.Forms.GroupBox();
            this.btnOHastaKaydet = new System.Windows.Forms.Button();
            this.cmbOrtopediYontemi = new System.Windows.Forms.ComboBox();
            this.cmbOHastalık = new System.Windows.Forms.ComboBox();
            this.txtOHastaSoyad = new System.Windows.Forms.TextBox();
            this.txtOHastaAd = new System.Windows.Forms.TextBox();
            this.txtOHastaTckNo = new System.Windows.Forms.TextBox();
            this.lblOrtopediYontemi = new System.Windows.Forms.Label();
            this.lblOHastalık = new System.Windows.Forms.Label();
            this.lblOHastaSoyad = new System.Windows.Forms.Label();
            this.lblOHastaAd = new System.Windows.Forms.Label();
            this.lblOHastaTckNo = new System.Windows.Forms.Label();
            this.gbOHastaRapor = new System.Windows.Forms.GroupBox();
            this.cmbORaporOnceligi = new System.Windows.Forms.ComboBox();
            this.lblORaporOnceligi = new System.Windows.Forms.Label();
            this.btnOHastaRapor = new System.Windows.Forms.Button();
            this.cmbORaporCesidi = new System.Windows.Forms.ComboBox();
            this.txtOHastaRprTckNo = new System.Windows.Forms.TextBox();
            this.lblORaporCesidi = new System.Windows.Forms.Label();
            this.lblOHastaRprTckNo = new System.Windows.Forms.Label();
            this.lblOTckNo = new System.Windows.Forms.Label();
            this.txtTckNo = new System.Windows.Forms.TextBox();
            this.gbOHastaKayit.SuspendLayout();
            this.gbOHastaRapor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOHastaKayit
            // 
            this.gbOHastaKayit.BackColor = System.Drawing.Color.YellowGreen;
            this.gbOHastaKayit.Controls.Add(this.btnOHastaKaydet);
            this.gbOHastaKayit.Controls.Add(this.cmbOrtopediYontemi);
            this.gbOHastaKayit.Controls.Add(this.cmbOHastalık);
            this.gbOHastaKayit.Controls.Add(this.txtOHastaSoyad);
            this.gbOHastaKayit.Controls.Add(this.txtOHastaAd);
            this.gbOHastaKayit.Controls.Add(this.txtOHastaTckNo);
            this.gbOHastaKayit.Controls.Add(this.lblOrtopediYontemi);
            this.gbOHastaKayit.Controls.Add(this.lblOHastalık);
            this.gbOHastaKayit.Controls.Add(this.lblOHastaSoyad);
            this.gbOHastaKayit.Controls.Add(this.lblOHastaAd);
            this.gbOHastaKayit.Controls.Add(this.lblOHastaTckNo);
            this.gbOHastaKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbOHastaKayit.Location = new System.Drawing.Point(37, 42);
            this.gbOHastaKayit.Name = "gbOHastaKayit";
            this.gbOHastaKayit.Size = new System.Drawing.Size(281, 235);
            this.gbOHastaKayit.TabIndex = 3;
            this.gbOHastaKayit.TabStop = false;
            this.gbOHastaKayit.Text = "Hasta Kayıt";
            // 
            // btnOHastaKaydet
            // 
            this.btnOHastaKaydet.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOHastaKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOHastaKaydet.Location = new System.Drawing.Point(87, 176);
            this.btnOHastaKaydet.Name = "btnOHastaKaydet";
            this.btnOHastaKaydet.Size = new System.Drawing.Size(112, 40);
            this.btnOHastaKaydet.TabIndex = 10;
            this.btnOHastaKaydet.Text = "Hastayı Kaydet";
            this.btnOHastaKaydet.UseVisualStyleBackColor = false;
            this.btnOHastaKaydet.Click += new System.EventHandler(this.btnOHastaKaydet_Click);
            // 
            // cmbOrtopediYontemi
            // 
            this.cmbOrtopediYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOrtopediYontemi.FormattingEnabled = true;
            this.cmbOrtopediYontemi.Items.AddRange(new object[] {
            "Protez",
            "Hareketli Yaşam",
            "Ultrasonik Isıtma"});
            this.cmbOrtopediYontemi.Location = new System.Drawing.Point(150, 146);
            this.cmbOrtopediYontemi.Name = "cmbOrtopediYontemi";
            this.cmbOrtopediYontemi.Size = new System.Drawing.Size(121, 23);
            this.cmbOrtopediYontemi.TabIndex = 9;
            // 
            // cmbOHastalık
            // 
            this.cmbOHastalık.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOHastalık.FormattingEnabled = true;
            this.cmbOHastalık.Items.AddRange(new object[] {
            "Kireçlenme",
            "Çıkık",
            "Fıtık"});
            this.cmbOHastalık.Location = new System.Drawing.Point(150, 114);
            this.cmbOHastalık.Name = "cmbOHastalık";
            this.cmbOHastalık.Size = new System.Drawing.Size(121, 23);
            this.cmbOHastalık.TabIndex = 8;
            // 
            // txtOHastaSoyad
            // 
            this.txtOHastaSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOHastaSoyad.Location = new System.Drawing.Point(150, 82);
            this.txtOHastaSoyad.Name = "txtOHastaSoyad";
            this.txtOHastaSoyad.Size = new System.Drawing.Size(100, 21);
            this.txtOHastaSoyad.TabIndex = 7;
            // 
            // txtOHastaAd
            // 
            this.txtOHastaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOHastaAd.Location = new System.Drawing.Point(150, 51);
            this.txtOHastaAd.Name = "txtOHastaAd";
            this.txtOHastaAd.Size = new System.Drawing.Size(100, 21);
            this.txtOHastaAd.TabIndex = 6;
            // 
            // txtOHastaTckNo
            // 
            this.txtOHastaTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOHastaTckNo.Location = new System.Drawing.Point(150, 20);
            this.txtOHastaTckNo.Name = "txtOHastaTckNo";
            this.txtOHastaTckNo.Size = new System.Drawing.Size(100, 21);
            this.txtOHastaTckNo.TabIndex = 5;
            // 
            // lblOrtopediYontemi
            // 
            this.lblOrtopediYontemi.AutoSize = true;
            this.lblOrtopediYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtopediYontemi.Location = new System.Drawing.Point(22, 149);
            this.lblOrtopediYontemi.Name = "lblOrtopediYontemi";
            this.lblOrtopediYontemi.Size = new System.Drawing.Size(122, 15);
            this.lblOrtopediYontemi.TabIndex = 4;
            this.lblOrtopediYontemi.Text = "Ortopedi Yöntemi:";
            // 
            // lblOHastalık
            // 
            this.lblOHastalık.AutoSize = true;
            this.lblOHastalık.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOHastalık.Location = new System.Drawing.Point(22, 117);
            this.lblOHastalık.Name = "lblOHastalık";
            this.lblOHastalık.Size = new System.Drawing.Size(63, 15);
            this.lblOHastalık.TabIndex = 3;
            this.lblOHastalık.Text = "Hastalık:";
            // 
            // lblOHastaSoyad
            // 
            this.lblOHastaSoyad.AutoSize = true;
            this.lblOHastaSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOHastaSoyad.Location = new System.Drawing.Point(22, 86);
            this.lblOHastaSoyad.Name = "lblOHastaSoyad";
            this.lblOHastaSoyad.Size = new System.Drawing.Size(95, 15);
            this.lblOHastaSoyad.TabIndex = 2;
            this.lblOHastaSoyad.Text = "Hasta Soyadı:";
            // 
            // lblOHastaAd
            // 
            this.lblOHastaAd.AutoSize = true;
            this.lblOHastaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOHastaAd.Location = new System.Drawing.Point(22, 54);
            this.lblOHastaAd.Name = "lblOHastaAd";
            this.lblOHastaAd.Size = new System.Drawing.Size(72, 15);
            this.lblOHastaAd.TabIndex = 1;
            this.lblOHastaAd.Text = "Hasta Adı:";
            // 
            // lblOHastaTckNo
            // 
            this.lblOHastaTckNo.AutoSize = true;
            this.lblOHastaTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOHastaTckNo.Location = new System.Drawing.Point(22, 24);
            this.lblOHastaTckNo.Name = "lblOHastaTckNo";
            this.lblOHastaTckNo.Size = new System.Drawing.Size(102, 15);
            this.lblOHastaTckNo.TabIndex = 0;
            this.lblOHastaTckNo.Text = "Hasta TCKNO :";
            // 
            // gbOHastaRapor
            // 
            this.gbOHastaRapor.BackColor = System.Drawing.Color.YellowGreen;
            this.gbOHastaRapor.Controls.Add(this.cmbORaporOnceligi);
            this.gbOHastaRapor.Controls.Add(this.lblORaporOnceligi);
            this.gbOHastaRapor.Controls.Add(this.btnOHastaRapor);
            this.gbOHastaRapor.Controls.Add(this.cmbORaporCesidi);
            this.gbOHastaRapor.Controls.Add(this.txtOHastaRprTckNo);
            this.gbOHastaRapor.Controls.Add(this.lblORaporCesidi);
            this.gbOHastaRapor.Controls.Add(this.lblOHastaRprTckNo);
            this.gbOHastaRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbOHastaRapor.Location = new System.Drawing.Point(342, 42);
            this.gbOHastaRapor.Name = "gbOHastaRapor";
            this.gbOHastaRapor.Size = new System.Drawing.Size(281, 235);
            this.gbOHastaRapor.TabIndex = 12;
            this.gbOHastaRapor.TabStop = false;
            this.gbOHastaRapor.Text = "Hasta Rapor Al";
            // 
            // cmbORaporOnceligi
            // 
            this.cmbORaporOnceligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbORaporOnceligi.FormattingEnabled = true;
            this.cmbORaporOnceligi.Items.AddRange(new object[] {
            "Kişi Bilgileri Öncelikli",
            "Hastalık Bilgileri Öncelikli"});
            this.cmbORaporOnceligi.Location = new System.Drawing.Point(150, 114);
            this.cmbORaporOnceligi.Name = "cmbORaporOnceligi";
            this.cmbORaporOnceligi.Size = new System.Drawing.Size(121, 23);
            this.cmbORaporOnceligi.TabIndex = 17;
            // 
            // lblORaporOnceligi
            // 
            this.lblORaporOnceligi.AutoSize = true;
            this.lblORaporOnceligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblORaporOnceligi.Location = new System.Drawing.Point(28, 118);
            this.lblORaporOnceligi.Name = "lblORaporOnceligi";
            this.lblORaporOnceligi.Size = new System.Drawing.Size(107, 15);
            this.lblORaporOnceligi.TabIndex = 16;
            this.lblORaporOnceligi.Text = "Rapor Önceliği:";
            // 
            // btnOHastaRapor
            // 
            this.btnOHastaRapor.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOHastaRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOHastaRapor.Location = new System.Drawing.Point(87, 176);
            this.btnOHastaRapor.Name = "btnOHastaRapor";
            this.btnOHastaRapor.Size = new System.Drawing.Size(114, 40);
            this.btnOHastaRapor.TabIndex = 11;
            this.btnOHastaRapor.Text = "Rapor Oluştur";
            this.btnOHastaRapor.UseVisualStyleBackColor = false;
            this.btnOHastaRapor.Click += new System.EventHandler(this.btnOHastaRapor_Click);
            // 
            // cmbORaporCesidi
            // 
            this.cmbORaporCesidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbORaporCesidi.FormattingEnabled = true;
            this.cmbORaporCesidi.Items.AddRange(new object[] {
            "HTML"});
            this.cmbORaporCesidi.Location = new System.Drawing.Point(150, 82);
            this.cmbORaporCesidi.Name = "cmbORaporCesidi";
            this.cmbORaporCesidi.Size = new System.Drawing.Size(121, 23);
            this.cmbORaporCesidi.TabIndex = 7;
            // 
            // txtOHastaRprTckNo
            // 
            this.txtOHastaRprTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOHastaRprTckNo.Location = new System.Drawing.Point(150, 51);
            this.txtOHastaRprTckNo.Name = "txtOHastaRprTckNo";
            this.txtOHastaRprTckNo.Size = new System.Drawing.Size(100, 21);
            this.txtOHastaRprTckNo.TabIndex = 6;
            this.txtOHastaRprTckNo.TextChanged += new System.EventHandler(this.txtOHastaRprTckNo_TextChanged);
            // 
            // lblORaporCesidi
            // 
            this.lblORaporCesidi.AutoSize = true;
            this.lblORaporCesidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblORaporCesidi.Location = new System.Drawing.Point(28, 86);
            this.lblORaporCesidi.Name = "lblORaporCesidi";
            this.lblORaporCesidi.Size = new System.Drawing.Size(94, 15);
            this.lblORaporCesidi.TabIndex = 2;
            this.lblORaporCesidi.Text = "Rapor Çeşidi:";
            // 
            // lblOHastaRprTckNo
            // 
            this.lblOHastaRprTckNo.AutoSize = true;
            this.lblOHastaRprTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOHastaRprTckNo.Location = new System.Drawing.Point(28, 55);
            this.lblOHastaRprTckNo.Name = "lblOHastaRprTckNo";
            this.lblOHastaRprTckNo.Size = new System.Drawing.Size(102, 15);
            this.lblOHastaRprTckNo.TabIndex = 1;
            this.lblOHastaRprTckNo.Text = "Hasta TCKNO :";
            // 
            // lblOTckNo
            // 
            this.lblOTckNo.AutoSize = true;
            this.lblOTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOTckNo.Location = new System.Drawing.Point(34, 15);
            this.lblOTckNo.Name = "lblOTckNo";
            this.lblOTckNo.Size = new System.Drawing.Size(127, 16);
            this.lblOTckNo.TabIndex = 13;
            this.lblOTckNo.Text = "Ortopedi TCKNO:";
            // 
            // txtTckNo
            // 
            this.txtTckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTckNo.Location = new System.Drawing.Point(167, 12);
            this.txtTckNo.Name = "txtTckNo";
            this.txtTckNo.Size = new System.Drawing.Size(100, 22);
            this.txtTckNo.TabIndex = 14;
            // 
            // FrmOrtopedi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(653, 308);
            this.Controls.Add(this.txtTckNo);
            this.Controls.Add(this.lblOTckNo);
            this.Controls.Add(this.gbOHastaRapor);
            this.Controls.Add(this.gbOHastaKayit);
            this.Name = "FrmOrtopedi";
            this.Text = "Ortopedi Hasta İşlemleri";
            this.Load += new System.EventHandler(this.FrmOrtopedi_Load);
            this.gbOHastaKayit.ResumeLayout(false);
            this.gbOHastaKayit.PerformLayout();
            this.gbOHastaRapor.ResumeLayout(false);
            this.gbOHastaRapor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOHastaKayit;
        private System.Windows.Forms.Button btnOHastaKaydet;
        private System.Windows.Forms.ComboBox cmbOrtopediYontemi;
        private System.Windows.Forms.ComboBox cmbOHastalık;
        private System.Windows.Forms.TextBox txtOHastaSoyad;
        private System.Windows.Forms.TextBox txtOHastaAd;
        private System.Windows.Forms.TextBox txtOHastaTckNo;
        private System.Windows.Forms.Label lblOrtopediYontemi;
        private System.Windows.Forms.Label lblOHastalık;
        private System.Windows.Forms.Label lblOHastaSoyad;
        private System.Windows.Forms.Label lblOHastaAd;
        private System.Windows.Forms.Label lblOHastaTckNo;
        private System.Windows.Forms.GroupBox gbOHastaRapor;
        private System.Windows.Forms.Button btnOHastaRapor;
        private System.Windows.Forms.ComboBox cmbORaporCesidi;
        private System.Windows.Forms.TextBox txtOHastaRprTckNo;
        private System.Windows.Forms.Label lblORaporCesidi;
        private System.Windows.Forms.Label lblOHastaRprTckNo;
        private System.Windows.Forms.Label lblOTckNo;
        private System.Windows.Forms.TextBox txtTckNo;
        private System.Windows.Forms.ComboBox cmbORaporOnceligi;
        private System.Windows.Forms.Label lblORaporOnceligi;
    }
}