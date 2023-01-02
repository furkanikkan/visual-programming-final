namespace siteYonetimi
{
    partial class odeme
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
            this.buttonAnaMenu = new System.Windows.Forms.Button();
            this.listOdemeler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonAnaMenu
            // 
            this.buttonAnaMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnaMenu.Location = new System.Drawing.Point(12, 177);
            this.buttonAnaMenu.Name = "buttonAnaMenu";
            this.buttonAnaMenu.Size = new System.Drawing.Size(91, 47);
            this.buttonAnaMenu.TabIndex = 2;
            this.buttonAnaMenu.Text = "Ana Menü";
            this.buttonAnaMenu.UseVisualStyleBackColor = true;
            this.buttonAnaMenu.Click += new System.EventHandler(this.button2_Click);
            // 
            // listOdemeler
            // 
            this.listOdemeler.FormattingEnabled = true;
            this.listOdemeler.ItemHeight = 16;
            this.listOdemeler.Location = new System.Drawing.Point(109, 12);
            this.listOdemeler.Name = "listOdemeler";
            this.listOdemeler.Size = new System.Drawing.Size(407, 212);
            this.listOdemeler.TabIndex = 4;
            this.listOdemeler.SelectedIndexChanged += new System.EventHandler(this.listOdemeler_SelectedIndexChanged);
            // 
            // odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAnaMenu;
            this.ClientSize = new System.Drawing.Size(536, 246);
            this.Controls.Add(this.listOdemeler);
            this.Controls.Add(this.buttonAnaMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "odeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aidat Ödeme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.odeme_FormClosing);
            this.Load += new System.EventHandler(this.aidatOdeme_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAnaMenu;
        private System.Windows.Forms.ListBox listOdemeler;
    }
}