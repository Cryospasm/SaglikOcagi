namespace Project
{
    partial class KullaniciTanit
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
            this.yeniKulEkleBtn = new System.Windows.Forms.Button();
            this.comboBox1_KullanicilarEkranaBas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yeniKulEkleBtn
            // 
            this.yeniKulEkleBtn.Location = new System.Drawing.Point(72, 85);
            this.yeniKulEkleBtn.Name = "yeniKulEkleBtn";
            this.yeniKulEkleBtn.Size = new System.Drawing.Size(155, 23);
            this.yeniKulEkleBtn.TabIndex = 2;
            this.yeniKulEkleBtn.Text = "Yeni Kullanıcı Ekle";
            this.yeniKulEkleBtn.UseVisualStyleBackColor = true;
            this.yeniKulEkleBtn.Click += new System.EventHandler(this.yeniKulEkleBtn_Click);
            // 
            // comboBox1_KullanicilarEkranaBas
            // 
            this.comboBox1_KullanicilarEkranaBas.FormattingEnabled = true;
            this.comboBox1_KullanicilarEkranaBas.Location = new System.Drawing.Point(143, 42);
            this.comboBox1_KullanicilarEkranaBas.MaximumSize = new System.Drawing.Size(121, 0);
            this.comboBox1_KullanicilarEkranaBas.MinimumSize = new System.Drawing.Size(121, 0);
            this.comboBox1_KullanicilarEkranaBas.Name = "comboBox1_KullanicilarEkranaBas";
            this.comboBox1_KullanicilarEkranaBas.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_KullanicilarEkranaBas.TabIndex = 4;
            this.comboBox1_KullanicilarEkranaBas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_KullanicilarEkranaBas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // KullaniciTanit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 154);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1_KullanicilarEkranaBas);
            this.Controls.Add(this.yeniKulEkleBtn);
            this.Name = "KullaniciTanit";
            this.Text = "KullaniciTanit";
            this.Load += new System.EventHandler(this.KullaniciTanit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button yeniKulEkleBtn;
        private System.Windows.Forms.ComboBox comboBox1_KullanicilarEkranaBas;
        private System.Windows.Forms.Label label1;
    }
}