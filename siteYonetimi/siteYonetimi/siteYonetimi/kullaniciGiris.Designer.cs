namespace siteYonetimi
{
    partial class Form1
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
            this.buttonBaglan = new System.Windows.Forms.Button();
            this.tBkullaniciAdıGiris = new System.Windows.Forms.TextBox();
            this.tBsifreGiris = new System.Windows.Forms.TextBox();
            this.labelKullaniciAdi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBaglan
            // 
            this.buttonBaglan.Location = new System.Drawing.Point(39, 138);
            this.buttonBaglan.Name = "buttonBaglan";
            this.buttonBaglan.Size = new System.Drawing.Size(170, 58);
            this.buttonBaglan.TabIndex = 3;
            this.buttonBaglan.Text = "bağlan";
            this.buttonBaglan.UseVisualStyleBackColor = true;
            this.buttonBaglan.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBkullaniciAdıGiris
            // 
            this.tBkullaniciAdıGiris.Location = new System.Drawing.Point(109, 12);
            this.tBkullaniciAdıGiris.Name = "tBkullaniciAdıGiris";
            this.tBkullaniciAdıGiris.Size = new System.Drawing.Size(100, 22);
            this.tBkullaniciAdıGiris.TabIndex = 1;
            this.tBkullaniciAdıGiris.TextChanged += new System.EventHandler(this.tBkullaniciAdıGiris_TextChanged);
            // 
            // tBsifreGiris
            // 
            this.tBsifreGiris.Location = new System.Drawing.Point(109, 67);
            this.tBsifreGiris.Name = "tBsifreGiris";
            this.tBsifreGiris.Size = new System.Drawing.Size(100, 22);
            this.tBsifreGiris.TabIndex = 2;
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.AutoSize = true;
            this.labelKullaniciAdi.Location = new System.Drawing.Point(11, 12);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(85, 16);
            this.labelKullaniciAdi.TabIndex = 2;
            this.labelKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre :";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(182, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 10);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonBaglan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(236, 219);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelKullaniciAdi);
            this.Controls.Add(this.tBsifreGiris);
            this.Controls.Add(this.tBkullaniciAdıGiris);
            this.Controls.Add(this.buttonBaglan);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBaglan;
        private System.Windows.Forms.TextBox tBkullaniciAdıGiris;
        private System.Windows.Forms.TextBox tBsifreGiris;
        private System.Windows.Forms.Label labelKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

