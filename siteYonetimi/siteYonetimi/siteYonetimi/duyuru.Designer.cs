namespace siteYonetimi
{
    partial class duyuru
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
            this.buttonDuyuruEkle = new System.Windows.Forms.Button();
            this.labelDuyurularBaslik = new System.Windows.Forms.Label();
            this.buttonAnaMenu = new System.Windows.Forms.Button();
            this.rTBduyuruİcerikEkle = new System.Windows.Forms.RichTextBox();
            this.tBduyuruBaslikEkle = new System.Windows.Forms.TextBox();
            this.gBduyuruBaslik = new System.Windows.Forms.GroupBox();
            this.gBDuyuruİcerik = new System.Windows.Forms.GroupBox();
            this.buttonDuyuruSil = new System.Windows.Forms.Button();
            this.dGWduyurularGoruntule = new System.Windows.Forms.DataGridView();
            this.gBduyuruBaslik.SuspendLayout();
            this.gBDuyuruİcerik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWduyurularGoruntule)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDuyuruEkle
            // 
            this.buttonDuyuruEkle.Location = new System.Drawing.Point(413, 359);
            this.buttonDuyuruEkle.Name = "buttonDuyuruEkle";
            this.buttonDuyuruEkle.Size = new System.Drawing.Size(110, 42);
            this.buttonDuyuruEkle.TabIndex = 0;
            this.buttonDuyuruEkle.Text = "Duyuru Ekle";
            this.buttonDuyuruEkle.UseVisualStyleBackColor = true;
            this.buttonDuyuruEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDuyurularBaslik
            // 
            this.labelDuyurularBaslik.AutoSize = true;
            this.labelDuyurularBaslik.Location = new System.Drawing.Point(12, 9);
            this.labelDuyurularBaslik.Name = "labelDuyurularBaslik";
            this.labelDuyurularBaslik.Size = new System.Drawing.Size(64, 16);
            this.labelDuyurularBaslik.TabIndex = 1;
            this.labelDuyurularBaslik.Text = "Duyurular";
            // 
            // buttonAnaMenu
            // 
            this.buttonAnaMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnaMenu.Location = new System.Drawing.Point(12, 359);
            this.buttonAnaMenu.Name = "buttonAnaMenu";
            this.buttonAnaMenu.Size = new System.Drawing.Size(119, 41);
            this.buttonAnaMenu.TabIndex = 3;
            this.buttonAnaMenu.Text = "Ana Menü";
            this.buttonAnaMenu.UseVisualStyleBackColor = true;
            this.buttonAnaMenu.Click += new System.EventHandler(this.button2_Click);
            // 
            // rTBduyuruİcerikEkle
            // 
            this.rTBduyuruİcerikEkle.Location = new System.Drawing.Point(6, 21);
            this.rTBduyuruİcerikEkle.Name = "rTBduyuruİcerikEkle";
            this.rTBduyuruİcerikEkle.Size = new System.Drawing.Size(272, 258);
            this.rTBduyuruİcerikEkle.TabIndex = 4;
            this.rTBduyuruİcerikEkle.Text = "";
            // 
            // tBduyuruBaslikEkle
            // 
            this.tBduyuruBaslikEkle.Location = new System.Drawing.Point(6, 21);
            this.tBduyuruBaslikEkle.Multiline = true;
            this.tBduyuruBaslikEkle.Name = "tBduyuruBaslikEkle";
            this.tBduyuruBaslikEkle.Size = new System.Drawing.Size(145, 32);
            this.tBduyuruBaslikEkle.TabIndex = 5;
            this.tBduyuruBaslikEkle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gBduyuruBaslik
            // 
            this.gBduyuruBaslik.Controls.Add(this.tBduyuruBaslikEkle);
            this.gBduyuruBaslik.Location = new System.Drawing.Point(474, 15);
            this.gBduyuruBaslik.Name = "gBduyuruBaslik";
            this.gBduyuruBaslik.Size = new System.Drawing.Size(159, 59);
            this.gBduyuruBaslik.TabIndex = 6;
            this.gBduyuruBaslik.TabStop = false;
            this.gBduyuruBaslik.Text = "İçerik Başlık";
            this.gBduyuruBaslik.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gBDuyuruİcerik
            // 
            this.gBDuyuruİcerik.Controls.Add(this.rTBduyuruİcerikEkle);
            this.gBDuyuruİcerik.Location = new System.Drawing.Point(396, 74);
            this.gBDuyuruİcerik.Name = "gBDuyuruİcerik";
            this.gBDuyuruİcerik.Size = new System.Drawing.Size(284, 286);
            this.gBDuyuruİcerik.TabIndex = 7;
            this.gBDuyuruİcerik.TabStop = false;
            this.gBDuyuruİcerik.Text = "Duyuru İçerik";
            // 
            // buttonDuyuruSil
            // 
            this.buttonDuyuruSil.Location = new System.Drawing.Point(549, 359);
            this.buttonDuyuruSil.Name = "buttonDuyuruSil";
            this.buttonDuyuruSil.Size = new System.Drawing.Size(110, 42);
            this.buttonDuyuruSil.TabIndex = 5;
            this.buttonDuyuruSil.Text = "Duyuru Sil";
            this.buttonDuyuruSil.UseVisualStyleBackColor = true;
            this.buttonDuyuruSil.Click += new System.EventHandler(this.button3_Click);
            // 
            // dGWduyurularGoruntule
            // 
            this.dGWduyurularGoruntule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGWduyurularGoruntule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWduyurularGoruntule.Location = new System.Drawing.Point(12, 36);
            this.dGWduyurularGoruntule.Name = "dGWduyurularGoruntule";
            this.dGWduyurularGoruntule.RowHeadersWidth = 51;
            this.dGWduyurularGoruntule.RowTemplate.Height = 24;
            this.dGWduyurularGoruntule.Size = new System.Drawing.Size(359, 317);
            this.dGWduyurularGoruntule.TabIndex = 8;
            this.dGWduyurularGoruntule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dGWduyurularGoruntule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // duyuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAnaMenu;
            this.ClientSize = new System.Drawing.Size(723, 412);
            this.Controls.Add(this.dGWduyurularGoruntule);
            this.Controls.Add(this.buttonDuyuruSil);
            this.Controls.Add(this.gBDuyuruİcerik);
            this.Controls.Add(this.gBduyuruBaslik);
            this.Controls.Add(this.buttonAnaMenu);
            this.Controls.Add(this.labelDuyurularBaslik);
            this.Controls.Add(this.buttonDuyuruEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "duyuru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "duyuru";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.duyuru_FormClosing);
            this.Load += new System.EventHandler(this.duyuruYonetici_Load);
            this.gBduyuruBaslik.ResumeLayout(false);
            this.gBduyuruBaslik.PerformLayout();
            this.gBDuyuruİcerik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGWduyurularGoruntule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDuyuruEkle;
        private System.Windows.Forms.Label labelDuyurularBaslik;
        private System.Windows.Forms.Button buttonAnaMenu;
        private System.Windows.Forms.RichTextBox rTBduyuruİcerikEkle;
        private System.Windows.Forms.TextBox tBduyuruBaslikEkle;
        private System.Windows.Forms.GroupBox gBduyuruBaslik;
        private System.Windows.Forms.GroupBox gBDuyuruİcerik;
        private System.Windows.Forms.Button buttonDuyuruSil;
        private System.Windows.Forms.DataGridView dGWduyurularGoruntule;
    }
}