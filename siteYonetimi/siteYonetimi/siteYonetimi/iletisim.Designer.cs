namespace siteYonetimi
{
    partial class iletisim
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
            this.buttonAnamenu = new System.Windows.Forms.Button();
            this.gBiletisimForm = new System.Windows.Forms.GroupBox();
            this.buttonGonder = new System.Windows.Forms.Button();
            this.rTBiletisimForm = new System.Windows.Forms.RichTextBox();
            this.cBitelisimNedeni = new System.Windows.Forms.ComboBox();
            this.labelFormIletisimNedeni = new System.Windows.Forms.Label();
            this.listIletisim = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gBiletisimForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAnamenu
            // 
            this.buttonAnamenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnamenu.Location = new System.Drawing.Point(12, 397);
            this.buttonAnamenu.Name = "buttonAnamenu";
            this.buttonAnamenu.Size = new System.Drawing.Size(99, 41);
            this.buttonAnamenu.TabIndex = 0;
            this.buttonAnamenu.Text = "Ana Menü";
            this.buttonAnamenu.UseVisualStyleBackColor = true;
            this.buttonAnamenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // gBiletisimForm
            // 
            this.gBiletisimForm.Controls.Add(this.buttonGonder);
            this.gBiletisimForm.Controls.Add(this.rTBiletisimForm);
            this.gBiletisimForm.Controls.Add(this.cBitelisimNedeni);
            this.gBiletisimForm.Controls.Add(this.labelFormIletisimNedeni);
            this.gBiletisimForm.Location = new System.Drawing.Point(12, 12);
            this.gBiletisimForm.Name = "gBiletisimForm";
            this.gBiletisimForm.Size = new System.Drawing.Size(379, 357);
            this.gBiletisimForm.TabIndex = 1;
            this.gBiletisimForm.TabStop = false;
            this.gBiletisimForm.Text = "İletişim Form";
            // 
            // buttonGonder
            // 
            this.buttonGonder.Location = new System.Drawing.Point(131, 318);
            this.buttonGonder.Name = "buttonGonder";
            this.buttonGonder.Size = new System.Drawing.Size(112, 33);
            this.buttonGonder.TabIndex = 3;
            this.buttonGonder.Text = "Gönder";
            this.buttonGonder.UseVisualStyleBackColor = true;
            this.buttonGonder.Click += new System.EventHandler(this.buttonGonder_Click);
            // 
            // rTBiletisimForm
            // 
            this.rTBiletisimForm.Location = new System.Drawing.Point(38, 71);
            this.rTBiletisimForm.Name = "rTBiletisimForm";
            this.rTBiletisimForm.Size = new System.Drawing.Size(289, 241);
            this.rTBiletisimForm.TabIndex = 2;
            this.rTBiletisimForm.Text = "";
            // 
            // cBitelisimNedeni
            // 
            this.cBitelisimNedeni.FormattingEnabled = true;
            this.cBitelisimNedeni.Location = new System.Drawing.Point(152, 30);
            this.cBitelisimNedeni.Name = "cBitelisimNedeni";
            this.cBitelisimNedeni.Size = new System.Drawing.Size(175, 24);
            this.cBitelisimNedeni.TabIndex = 1;
            // 
            // labelFormIletisimNedeni
            // 
            this.labelFormIletisimNedeni.AutoSize = true;
            this.labelFormIletisimNedeni.Location = new System.Drawing.Point(35, 38);
            this.labelFormIletisimNedeni.Name = "labelFormIletisimNedeni";
            this.labelFormIletisimNedeni.Size = new System.Drawing.Size(101, 16);
            this.labelFormIletisimNedeni.TabIndex = 0;
            this.labelFormIletisimNedeni.Text = "İletişim Nedeni :";
            // 
            // listIletisim
            // 
            this.listIletisim.FormattingEnabled = true;
            this.listIletisim.ItemHeight = 16;
            this.listIletisim.Location = new System.Drawing.Point(6, 23);
            this.listIletisim.Name = "listIletisim";
            this.listIletisim.Size = new System.Drawing.Size(370, 324);
            this.listIletisim.TabIndex = 3;
            this.listIletisim.SelectedIndexChanged += new System.EventHandler(this.listIletisim_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listIletisim);
            this.groupBox1.Location = new System.Drawing.Point(407, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 357);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yöneticiye Gelen Mesajlar";
            // 
            // iletisim
            // 
            this.AcceptButton = this.buttonGonder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAnamenu;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBiletisimForm);
            this.Controls.Add(this.buttonAnamenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "iletisim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İletişim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.iletisim_FormClosing);
            this.Load += new System.EventHandler(this.iletisim_Load);
            this.gBiletisimForm.ResumeLayout(false);
            this.gBiletisimForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAnamenu;
        private System.Windows.Forms.GroupBox gBiletisimForm;
        private System.Windows.Forms.ComboBox cBitelisimNedeni;
        private System.Windows.Forms.Label labelFormIletisimNedeni;
        private System.Windows.Forms.Button buttonGonder;
        private System.Windows.Forms.RichTextBox rTBiletisimForm;
        private System.Windows.Forms.ListBox listIletisim;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}