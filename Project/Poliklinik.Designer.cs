namespace Project
{
    partial class Poliklinik
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
            this.button_PoliklinikCikisYap = new System.Windows.Forms.Button();
            this.button_PoliklinikSil = new System.Windows.Forms.Button();
            this.button1_PoliklinikGuncelle = new System.Windows.Forms.Button();
            this.textBox_PoliklinikAciklama = new System.Windows.Forms.TextBox();
            this.textBox1_poliklinikPoliklinikAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_poliklinikGecerliMi = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_PoliklinikCikisYap
            // 
            this.button_PoliklinikCikisYap.Location = new System.Drawing.Point(211, 204);
            this.button_PoliklinikCikisYap.Name = "button_PoliklinikCikisYap";
            this.button_PoliklinikCikisYap.Size = new System.Drawing.Size(72, 54);
            this.button_PoliklinikCikisYap.TabIndex = 18;
            this.button_PoliklinikCikisYap.Text = "Kapat";
            this.button_PoliklinikCikisYap.UseVisualStyleBackColor = true;
            // 
            // button_PoliklinikSil
            // 
            this.button_PoliklinikSil.Location = new System.Drawing.Point(107, 204);
            this.button_PoliklinikSil.Name = "button_PoliklinikSil";
            this.button_PoliklinikSil.Size = new System.Drawing.Size(72, 54);
            this.button_PoliklinikSil.TabIndex = 19;
            this.button_PoliklinikSil.Text = "Sil";
            this.button_PoliklinikSil.UseVisualStyleBackColor = true;
            // 
            // button1_PoliklinikGuncelle
            // 
            this.button1_PoliklinikGuncelle.Location = new System.Drawing.Point(29, 204);
            this.button1_PoliklinikGuncelle.Name = "button1_PoliklinikGuncelle";
            this.button1_PoliklinikGuncelle.Size = new System.Drawing.Size(72, 54);
            this.button1_PoliklinikGuncelle.TabIndex = 20;
            this.button1_PoliklinikGuncelle.Text = "Güncelle";
            this.button1_PoliklinikGuncelle.UseVisualStyleBackColor = true;
            // 
            // textBox_PoliklinikAciklama
            // 
            this.textBox_PoliklinikAciklama.Location = new System.Drawing.Point(29, 101);
            this.textBox_PoliklinikAciklama.MaxLength = 250;
            this.textBox_PoliklinikAciklama.Multiline = true;
            this.textBox_PoliklinikAciklama.Name = "textBox_PoliklinikAciklama";
            this.textBox_PoliklinikAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_PoliklinikAciklama.Size = new System.Drawing.Size(254, 97);
            this.textBox_PoliklinikAciklama.TabIndex = 17;
            // 
            // textBox1_poliklinikPoliklinikAd
            // 
            this.textBox1_poliklinikPoliklinikAd.Enabled = false;
            this.textBox1_poliklinikPoliklinikAd.Location = new System.Drawing.Point(96, 25);
            this.textBox1_poliklinikPoliklinikAd.Name = "textBox1_poliklinikPoliklinikAd";
            this.textBox1_poliklinikPoliklinikAd.Size = new System.Drawing.Size(187, 20);
            this.textBox1_poliklinikPoliklinikAd.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Poliklinik Ad";
            // 
            // checkBox_poliklinikGecerliMi
            // 
            this.checkBox_poliklinikGecerliMi.AutoSize = true;
            this.checkBox_poliklinikGecerliMi.Location = new System.Drawing.Point(96, 51);
            this.checkBox_poliklinikGecerliMi.Name = "checkBox_poliklinikGecerliMi";
            this.checkBox_poliklinikGecerliMi.Size = new System.Drawing.Size(111, 17);
            this.checkBox_poliklinikGecerliMi.TabIndex = 13;
            this.checkBox_poliklinikGecerliMi.Text = "Geçerli / Geçersiz";
            this.checkBox_poliklinikGecerliMi.UseVisualStyleBackColor = true;
            // 
            // Poliklinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 284);
            this.Controls.Add(this.button_PoliklinikCikisYap);
            this.Controls.Add(this.button_PoliklinikSil);
            this.Controls.Add(this.button1_PoliklinikGuncelle);
            this.Controls.Add(this.textBox_PoliklinikAciklama);
            this.Controls.Add(this.textBox1_poliklinikPoliklinikAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_poliklinikGecerliMi);
            this.Name = "Poliklinik";
            this.Text = "Poliklinik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_PoliklinikCikisYap;
        private System.Windows.Forms.Button button_PoliklinikSil;
        private System.Windows.Forms.Button button1_PoliklinikGuncelle;
        private System.Windows.Forms.TextBox textBox_PoliklinikAciklama;
        private System.Windows.Forms.TextBox textBox1_poliklinikPoliklinikAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_poliklinikGecerliMi;
    }
}