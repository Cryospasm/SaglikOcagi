namespace Project
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.referanslarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikTanıtmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıTanıtmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKabulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programdanÇıkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referanslarToolStripMenuItem,
            this.hastaKabulToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.kullaniciİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1195, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // referanslarToolStripMenuItem
            // 
            this.referanslarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poliklinikTanıtmaToolStripMenuItem,
            this.kullanıcıTanıtmaToolStripMenuItem});
            this.referanslarToolStripMenuItem.Name = "referanslarToolStripMenuItem";
            this.referanslarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.referanslarToolStripMenuItem.Text = "Referanslar";
            // 
            // poliklinikTanıtmaToolStripMenuItem
            // 
            this.poliklinikTanıtmaToolStripMenuItem.Name = "poliklinikTanıtmaToolStripMenuItem";
            this.poliklinikTanıtmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poliklinikTanıtmaToolStripMenuItem.Text = "Poliklinik Tanıtma";
            this.poliklinikTanıtmaToolStripMenuItem.Click += new System.EventHandler(this.poliklinikTanıtmaToolStripMenuItem_Click);
            // 
            // kullanıcıTanıtmaToolStripMenuItem
            // 
            this.kullanıcıTanıtmaToolStripMenuItem.Name = "kullanıcıTanıtmaToolStripMenuItem";
            this.kullanıcıTanıtmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kullanıcıTanıtmaToolStripMenuItem.Text = "Kullanıcı Tanıtma";
            // 
            // hastaKabulToolStripMenuItem
            // 
            this.hastaKabulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaİşlemleriToolStripMenuItem});
            this.hastaKabulToolStripMenuItem.Name = "hastaKabulToolStripMenuItem";
            this.hastaKabulToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.hastaKabulToolStripMenuItem.Text = "Hasta Kabul";
            // 
            // hastaİşlemleriToolStripMenuItem
            // 
            this.hastaİşlemleriToolStripMenuItem.Name = "hastaİşlemleriToolStripMenuItem";
            this.hastaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.hastaİşlemleriToolStripMenuItem.Text = "Hasta İşlemleri      F2";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // kullaniciİşlemleriToolStripMenuItem
            // 
            this.kullaniciİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışYapToolStripMenuItem1,
            this.programdanÇıkToolStripMenuItem1});
            this.kullaniciİşlemleriToolStripMenuItem.Name = "kullaniciİşlemleriToolStripMenuItem";
            this.kullaniciİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.kullaniciİşlemleriToolStripMenuItem.Text = "Kullanici İşlemleri";
            // 
            // programdanÇıkToolStripMenuItem1
            // 
            this.programdanÇıkToolStripMenuItem1.Name = "programdanÇıkToolStripMenuItem1";
            this.programdanÇıkToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.programdanÇıkToolStripMenuItem1.Text = "Programdan Çık";
            // 
            // çıkışYapToolStripMenuItem1
            // 
            this.çıkışYapToolStripMenuItem1.Name = "çıkışYapToolStripMenuItem1";
            this.çıkışYapToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.çıkışYapToolStripMenuItem1.Text = "Çıkış Yap / Log Out";
            this.çıkışYapToolStripMenuItem1.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 634);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem referanslarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikTanıtmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıTanıtmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKabulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programdanÇıkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem1;
    }
}

