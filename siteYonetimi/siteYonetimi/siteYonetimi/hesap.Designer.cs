namespace siteYonetimi
{
    partial class hesap
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
            this.labelAd = new System.Windows.Forms.Label();
            this.pBresim = new System.Windows.Forms.PictureBox();
            this.labelKullaniciAdi = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.gBduzenle = new System.Windows.Forms.GroupBox();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.buttonDuzenle = new System.Windows.Forms.Button();
            this.labelSoyadGelen = new System.Windows.Forms.Label();
            this.labelAdGelen = new System.Windows.Forms.Label();
            this.labelTelefonNoGelen = new System.Windows.Forms.Label();
            this.labelAracPlakaGelen = new System.Windows.Forms.Label();
            this.labelTelefonNo = new System.Windows.Forms.Label();
            this.labelSifreGelen = new System.Windows.Forms.Label();
            this.labelAracPlaka = new System.Windows.Forms.Label();
            this.tBtelefonNoDuzenle = new System.Windows.Forms.TextBox();
            this.tBaracPlakaDuzenle = new System.Windows.Forms.TextBox();
            this.tBsifreDuzenle = new System.Windows.Forms.TextBox();
            this.tBkullaniciAdiDuzenle = new System.Windows.Forms.TextBox();
            this.tBsoyadDuzenle = new System.Windows.Forms.TextBox();
            this.tBadDuzenle = new System.Windows.Forms.TextBox();
            this.labelKullaniciAdiGelen = new System.Windows.Forms.Label();
            this.buttonAnaMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBresim)).BeginInit();
            this.gBduzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelAd.Location = new System.Drawing.Point(30, 36);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(30, 16);
            this.labelAd.TabIndex = 0;
            this.labelAd.Text = "Ad :";
            this.labelAd.Click += new System.EventHandler(this.label1_Click);
            // 
            // pBresim
            // 
            this.pBresim.Image = global::siteYonetimi.Properties.Resources.user__1_;
            this.pBresim.Location = new System.Drawing.Point(12, 14);
            this.pBresim.Name = "pBresim";
            this.pBresim.Size = new System.Drawing.Size(138, 156);
            this.pBresim.TabIndex = 1;
            this.pBresim.TabStop = false;
            this.pBresim.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.AutoSize = true;
            this.labelKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelKullaniciAdi.Location = new System.Drawing.Point(30, 96);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(82, 16);
            this.labelKullaniciAdi.TabIndex = 0;
            this.labelKullaniciAdi.Text = "KullanıcıAdı :";
            this.labelKullaniciAdi.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelSifre.Location = new System.Drawing.Point(30, 124);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(40, 16);
            this.labelSifre.TabIndex = 0;
            this.labelSifre.Text = "Şifre :";
            this.labelSifre.Click += new System.EventHandler(this.label2_Click);
            // 
            // gBduzenle
            // 
            this.gBduzenle.Controls.Add(this.labelSoyad);
            this.gBduzenle.Controls.Add(this.labelAd);
            this.gBduzenle.Controls.Add(this.buttonDuzenle);
            this.gBduzenle.Controls.Add(this.labelSoyadGelen);
            this.gBduzenle.Controls.Add(this.labelAdGelen);
            this.gBduzenle.Controls.Add(this.labelKullaniciAdi);
            this.gBduzenle.Controls.Add(this.labelTelefonNoGelen);
            this.gBduzenle.Controls.Add(this.labelAracPlakaGelen);
            this.gBduzenle.Controls.Add(this.labelTelefonNo);
            this.gBduzenle.Controls.Add(this.labelSifreGelen);
            this.gBduzenle.Controls.Add(this.labelAracPlaka);
            this.gBduzenle.Controls.Add(this.tBtelefonNoDuzenle);
            this.gBduzenle.Controls.Add(this.tBaracPlakaDuzenle);
            this.gBduzenle.Controls.Add(this.tBsifreDuzenle);
            this.gBduzenle.Controls.Add(this.tBkullaniciAdiDuzenle);
            this.gBduzenle.Controls.Add(this.tBsoyadDuzenle);
            this.gBduzenle.Controls.Add(this.tBadDuzenle);
            this.gBduzenle.Controls.Add(this.labelSifre);
            this.gBduzenle.Controls.Add(this.labelKullaniciAdiGelen);
            this.gBduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBduzenle.Location = new System.Drawing.Point(169, 14);
            this.gBduzenle.Name = "gBduzenle";
            this.gBduzenle.Size = new System.Drawing.Size(385, 302);
            this.gBduzenle.TabIndex = 4;
            this.gBduzenle.TabStop = false;
            this.gBduzenle.Text = "Düzenle";
            this.gBduzenle.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelSoyad.Location = new System.Drawing.Point(30, 66);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(53, 16);
            this.labelSoyad.TabIndex = 0;
            this.labelSoyad.Text = "Soyad :";
            this.labelSoyad.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonDuzenle
            // 
            this.buttonDuzenle.Location = new System.Drawing.Point(244, 208);
            this.buttonDuzenle.Name = "buttonDuzenle";
            this.buttonDuzenle.Size = new System.Drawing.Size(123, 43);
            this.buttonDuzenle.TabIndex = 2;
            this.buttonDuzenle.Text = "Düzenle";
            this.buttonDuzenle.UseVisualStyleBackColor = true;
            this.buttonDuzenle.Click += new System.EventHandler(this.button8_Click);
            // 
            // labelSoyadGelen
            // 
            this.labelSoyadGelen.AutoSize = true;
            this.labelSoyadGelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelSoyadGelen.Location = new System.Drawing.Point(135, 66);
            this.labelSoyadGelen.Name = "labelSoyadGelen";
            this.labelSoyadGelen.Size = new System.Drawing.Size(47, 16);
            this.labelSoyadGelen.TabIndex = 0;
            this.labelSoyadGelen.Text = "Soyad";
            this.labelSoyadGelen.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAdGelen
            // 
            this.labelAdGelen.AutoSize = true;
            this.labelAdGelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelAdGelen.Location = new System.Drawing.Point(135, 36);
            this.labelAdGelen.Name = "labelAdGelen";
            this.labelAdGelen.Size = new System.Drawing.Size(24, 16);
            this.labelAdGelen.TabIndex = 0;
            this.labelAdGelen.Text = "Ad";
            this.labelAdGelen.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTelefonNoGelen
            // 
            this.labelTelefonNoGelen.AutoSize = true;
            this.labelTelefonNoGelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelTelefonNoGelen.Location = new System.Drawing.Point(135, 186);
            this.labelTelefonNoGelen.Name = "labelTelefonNoGelen";
            this.labelTelefonNoGelen.Size = new System.Drawing.Size(74, 16);
            this.labelTelefonNoGelen.TabIndex = 0;
            this.labelTelefonNoGelen.Text = "Telefon No";
            this.labelTelefonNoGelen.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelAracPlakaGelen
            // 
            this.labelAracPlakaGelen.AutoSize = true;
            this.labelAracPlakaGelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelAracPlakaGelen.Location = new System.Drawing.Point(135, 152);
            this.labelAracPlakaGelen.Name = "labelAracPlakaGelen";
            this.labelAracPlakaGelen.Size = new System.Drawing.Size(73, 16);
            this.labelAracPlakaGelen.TabIndex = 0;
            this.labelAracPlakaGelen.Text = "Araç Plaka";
            this.labelAracPlakaGelen.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelTelefonNo
            // 
            this.labelTelefonNo.AutoSize = true;
            this.labelTelefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelTelefonNo.Location = new System.Drawing.Point(30, 186);
            this.labelTelefonNo.Name = "labelTelefonNo";
            this.labelTelefonNo.Size = new System.Drawing.Size(80, 16);
            this.labelTelefonNo.TabIndex = 0;
            this.labelTelefonNo.Text = "Telefon No :";
            this.labelTelefonNo.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelSifreGelen
            // 
            this.labelSifreGelen.AutoSize = true;
            this.labelSifreGelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelSifreGelen.Location = new System.Drawing.Point(135, 124);
            this.labelSifreGelen.Name = "labelSifreGelen";
            this.labelSifreGelen.Size = new System.Drawing.Size(34, 16);
            this.labelSifreGelen.TabIndex = 0;
            this.labelSifreGelen.Text = "Şifre";
            this.labelSifreGelen.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelAracPlaka
            // 
            this.labelAracPlaka.AutoSize = true;
            this.labelAracPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelAracPlaka.Location = new System.Drawing.Point(30, 152);
            this.labelAracPlaka.Name = "labelAracPlaka";
            this.labelAracPlaka.Size = new System.Drawing.Size(79, 16);
            this.labelAracPlaka.TabIndex = 0;
            this.labelAracPlaka.Text = "Araç Plaka :";
            this.labelAracPlaka.Click += new System.EventHandler(this.label2_Click);
            // 
            // tBtelefonNoDuzenle
            // 
            this.tBtelefonNoDuzenle.Location = new System.Drawing.Point(256, 178);
            this.tBtelefonNoDuzenle.Name = "tBtelefonNoDuzenle";
            this.tBtelefonNoDuzenle.Size = new System.Drawing.Size(100, 24);
            this.tBtelefonNoDuzenle.TabIndex = 2;
            // 
            // tBaracPlakaDuzenle
            // 
            this.tBaracPlakaDuzenle.Location = new System.Drawing.Point(256, 147);
            this.tBaracPlakaDuzenle.Name = "tBaracPlakaDuzenle";
            this.tBaracPlakaDuzenle.Size = new System.Drawing.Size(100, 24);
            this.tBaracPlakaDuzenle.TabIndex = 2;
            // 
            // tBsifreDuzenle
            // 
            this.tBsifreDuzenle.Location = new System.Drawing.Point(256, 117);
            this.tBsifreDuzenle.Name = "tBsifreDuzenle";
            this.tBsifreDuzenle.Size = new System.Drawing.Size(100, 24);
            this.tBsifreDuzenle.TabIndex = 2;
            // 
            // tBkullaniciAdiDuzenle
            // 
            this.tBkullaniciAdiDuzenle.Location = new System.Drawing.Point(256, 88);
            this.tBkullaniciAdiDuzenle.Name = "tBkullaniciAdiDuzenle";
            this.tBkullaniciAdiDuzenle.Size = new System.Drawing.Size(100, 24);
            this.tBkullaniciAdiDuzenle.TabIndex = 2;
            // 
            // tBsoyadDuzenle
            // 
            this.tBsoyadDuzenle.Location = new System.Drawing.Point(256, 58);
            this.tBsoyadDuzenle.Name = "tBsoyadDuzenle";
            this.tBsoyadDuzenle.Size = new System.Drawing.Size(100, 24);
            this.tBsoyadDuzenle.TabIndex = 2;
            // 
            // tBadDuzenle
            // 
            this.tBadDuzenle.Location = new System.Drawing.Point(256, 28);
            this.tBadDuzenle.Name = "tBadDuzenle";
            this.tBadDuzenle.Size = new System.Drawing.Size(100, 24);
            this.tBadDuzenle.TabIndex = 2;
            // 
            // labelKullaniciAdiGelen
            // 
            this.labelKullaniciAdiGelen.AutoSize = true;
            this.labelKullaniciAdiGelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelKullaniciAdiGelen.Location = new System.Drawing.Point(135, 96);
            this.labelKullaniciAdiGelen.Name = "labelKullaniciAdiGelen";
            this.labelKullaniciAdiGelen.Size = new System.Drawing.Size(76, 16);
            this.labelKullaniciAdiGelen.TabIndex = 0;
            this.labelKullaniciAdiGelen.Text = "KullanıcıAdı";
            this.labelKullaniciAdiGelen.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonAnaMenu
            // 
            this.buttonAnaMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnaMenu.Location = new System.Drawing.Point(24, 280);
            this.buttonAnaMenu.Name = "buttonAnaMenu";
            this.buttonAnaMenu.Size = new System.Drawing.Size(109, 36);
            this.buttonAnaMenu.TabIndex = 5;
            this.buttonAnaMenu.Text = "Ana Menü";
            this.buttonAnaMenu.UseVisualStyleBackColor = true;
            this.buttonAnaMenu.Click += new System.EventHandler(this.button2_Click);
            // 
            // hesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAnaMenu;
            this.ClientSize = new System.Drawing.Size(563, 353);
            this.Controls.Add(this.buttonAnaMenu);
            this.Controls.Add(this.gBduzenle);
            this.Controls.Add(this.pBresim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "hesap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesabım";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.hesap_FormClosing);
            this.Load += new System.EventHandler(this.hesap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBresim)).EndInit();
            this.gBduzenle.ResumeLayout(false);
            this.gBduzenle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.PictureBox pBresim;
        private System.Windows.Forms.Label labelKullaniciAdi;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.GroupBox gBduzenle;
        private System.Windows.Forms.Button buttonDuzenle;
        private System.Windows.Forms.Label labelTelefonNo;
        private System.Windows.Forms.Label labelAracPlaka;
        private System.Windows.Forms.Label labelAdGelen;
        private System.Windows.Forms.Label labelTelefonNoGelen;
        private System.Windows.Forms.Label labelAracPlakaGelen;
        private System.Windows.Forms.Label labelSifreGelen;
        private System.Windows.Forms.Label labelKullaniciAdiGelen;
        private System.Windows.Forms.TextBox tBtelefonNoDuzenle;
        private System.Windows.Forms.TextBox tBaracPlakaDuzenle;
        private System.Windows.Forms.TextBox tBsifreDuzenle;
        private System.Windows.Forms.TextBox tBkullaniciAdiDuzenle;
        private System.Windows.Forms.TextBox tBadDuzenle;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.Label labelSoyadGelen;
        private System.Windows.Forms.TextBox tBsoyadDuzenle;
        private System.Windows.Forms.Button buttonAnaMenu;
    }
}