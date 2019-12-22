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
            this.denemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikTanıtmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıTanıtmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.aaaaaaaa = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.denemeToolStripMenuItem,
            this.raporlamaToolStripMenuItem,
            this.raporlamaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1195, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // denemeToolStripMenuItem
            // 
            this.denemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poliklinikTanıtmaToolStripMenuItem,
            this.kullanıcıTanıtmaToolStripMenuItem,
            this.çıkışToolStripMenuItem,
            this.çıkışToolStripMenuItem1});
            this.denemeToolStripMenuItem.Name = "denemeToolStripMenuItem";
            this.denemeToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.denemeToolStripMenuItem.Text = "Referanslar";
            // 
            // poliklinikTanıtmaToolStripMenuItem
            // 
            this.poliklinikTanıtmaToolStripMenuItem.Name = "poliklinikTanıtmaToolStripMenuItem";
            this.poliklinikTanıtmaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.poliklinikTanıtmaToolStripMenuItem.Text = "Poliklinik tanıtma";
            this.poliklinikTanıtmaToolStripMenuItem.Click += new System.EventHandler(this.poliklinikTanıtmaToolStripMenuItem_Click);
            // 
            // kullanıcıTanıtmaToolStripMenuItem
            // 
            this.kullanıcıTanıtmaToolStripMenuItem.Name = "kullanıcıTanıtmaToolStripMenuItem";
            this.kullanıcıTanıtmaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.kullanıcıTanıtmaToolStripMenuItem.Text = "Kullanıcı Tanıtma";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.çıkışToolStripMenuItem.Text = "Oturumu Kapat";
            // 
            // çıkışToolStripMenuItem1
            // 
            this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
            this.çıkışToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.çıkışToolStripMenuItem1.Text = "Çıkış";
            this.çıkışToolStripMenuItem1.Click += new System.EventHandler(this.çıkışToolStripMenuItem1_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaİşlemleriToolStripMenuItem});
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.raporlamaToolStripMenuItem.Text = "Hasta Kabul";
            // 
            // hastaİşlemleriToolStripMenuItem
            // 
            this.hastaİşlemleriToolStripMenuItem.Name = "hastaİşlemleriToolStripMenuItem";
            this.hastaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.hastaİşlemleriToolStripMenuItem.Text = "Hasta İşlemleri";
            // 
            // raporlamaToolStripMenuItem1
            // 
            this.raporlamaToolStripMenuItem1.Name = "raporlamaToolStripMenuItem1";
            this.raporlamaToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.raporlamaToolStripMenuItem1.Text = "Raporlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1083, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // aaaaaaaa
            // 
            this.aaaaaaaa.Location = new System.Drawing.Point(1086, 129);
            this.aaaaaaaa.Name = "aaaaaaaa";
            this.aaaaaaaa.Size = new System.Drawing.Size(100, 20);
            this.aaaaaaaa.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 634);
            this.Controls.Add(this.aaaaaaaa);
            this.Controls.Add(this.label2);
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem denemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikTanıtmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıTanıtmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hastaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aaaaaaaa;
    }
}

