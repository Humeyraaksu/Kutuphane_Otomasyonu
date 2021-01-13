
namespace Kutuphane_Otomasyonu
{
    partial class Kitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitaplar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_kitapbarkod = new System.Windows.Forms.TextBox();
            this.kitapbarkod = new System.Windows.Forms.Label();
            this.textBox_SayfaSayisi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Tur = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_YayinEvi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_KitapKayit = new System.Windows.Forms.DateTimePicker();
            this.textBox_Yazar = new System.Windows.Forms.TextBox();
            this.textBox_kitapAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_KitapListe = new System.Windows.Forms.DataGridView();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Kaydet = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KitapListe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_min);
            this.panel1.Controls.Add(this.btn_max);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 37);
            this.panel1.TabIndex = 2;
            this.panel1.UseWaitCursor = true;
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.AutoEllipsis = true;
            this.btn_min.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.Location = new System.Drawing.Point(906, 3);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(24, 24);
            this.btn_min.TabIndex = 3;
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.UseWaitCursor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.AutoEllipsis = true;
            this.btn_max.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Image = ((System.Drawing.Image)(resources.GetObject("btn_max.Image")));
            this.btn_max.Location = new System.Drawing.Point(951, 3);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(24, 24);
            this.btn_max.TabIndex = 2;
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.UseWaitCursor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.AutoEllipsis = true;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(990, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(24, 24);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.UseWaitCursor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "KÜTÜPHANE | Kitap Listesi";
            this.label1.UseWaitCursor = true;
            // 
            // textBox1_kitapbarkod
            // 
            this.textBox1_kitapbarkod.Location = new System.Drawing.Point(181, 90);
            this.textBox1_kitapbarkod.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1_kitapbarkod.Name = "textBox1_kitapbarkod";
            this.textBox1_kitapbarkod.Size = new System.Drawing.Size(261, 28);
            this.textBox1_kitapbarkod.TabIndex = 30;
            // 
            // kitapbarkod
            // 
            this.kitapbarkod.AutoSize = true;
            this.kitapbarkod.Location = new System.Drawing.Point(26, 93);
            this.kitapbarkod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kitapbarkod.Name = "kitapbarkod";
            this.kitapbarkod.Size = new System.Drawing.Size(123, 21);
            this.kitapbarkod.TabIndex = 29;
            this.kitapbarkod.Text = "Kitap Barkod:";
            // 
            // textBox_SayfaSayisi
            // 
            this.textBox_SayfaSayisi.Location = new System.Drawing.Point(606, 140);
            this.textBox_SayfaSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SayfaSayisi.Name = "textBox_SayfaSayisi";
            this.textBox_SayfaSayisi.Size = new System.Drawing.Size(92, 28);
            this.textBox_SayfaSayisi.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Sayfa Sayısı:";
            // 
            // comboBox_Tur
            // 
            this.comboBox_Tur.FormattingEnabled = true;
            this.comboBox_Tur.Items.AddRange(new object[] {
            "Bilim Kurgu Klasikleri",
            "Modern Klasikler ",
            "Gerilim Romanları",
            "Tarihi Romanlar",
            "Kişisel Gelişim "});
            this.comboBox_Tur.Location = new System.Drawing.Point(181, 176);
            this.comboBox_Tur.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Tur.Name = "comboBox_Tur";
            this.comboBox_Tur.Size = new System.Drawing.Size(261, 29);
            this.comboBox_Tur.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tür:";
            // 
            // textBox_YayinEvi
            // 
            this.textBox_YayinEvi.Location = new System.Drawing.Point(606, 48);
            this.textBox_YayinEvi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_YayinEvi.Name = "textBox_YayinEvi";
            this.textBox_YayinEvi.Size = new System.Drawing.Size(261, 28);
            this.textBox_YayinEvi.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Yayın Evi:";
            // 
            // dtp_KitapKayit
            // 
            this.dtp_KitapKayit.Location = new System.Drawing.Point(606, 93);
            this.dtp_KitapKayit.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_KitapKayit.Name = "dtp_KitapKayit";
            this.dtp_KitapKayit.Size = new System.Drawing.Size(261, 28);
            this.dtp_KitapKayit.TabIndex = 24;
            // 
            // textBox_Yazar
            // 
            this.textBox_Yazar.Location = new System.Drawing.Point(181, 133);
            this.textBox_Yazar.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Yazar.Name = "textBox_Yazar";
            this.textBox_Yazar.Size = new System.Drawing.Size(261, 28);
            this.textBox_Yazar.TabIndex = 21;
            // 
            // textBox_kitapAdi
            // 
            this.textBox_kitapAdi.Location = new System.Drawing.Point(181, 48);
            this.textBox_kitapAdi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_kitapAdi.Name = "textBox_kitapAdi";
            this.textBox_kitapAdi.Size = new System.Drawing.Size(261, 28);
            this.textBox_kitapAdi.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Basım Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Yazar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Kitap Adı:";
            // 
            // dgv_KitapListe
            // 
            this.dgv_KitapListe.AllowUserToAddRows = false;
            this.dgv_KitapListe.AllowUserToDeleteRows = false;
            this.dgv_KitapListe.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgv_KitapListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KitapListe.Location = new System.Drawing.Point(25, 303);
            this.dgv_KitapListe.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_KitapListe.Name = "dgv_KitapListe";
            this.dgv_KitapListe.ReadOnly = true;
            this.dgv_KitapListe.RowHeadersWidth = 51;
            this.dgv_KitapListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KitapListe.Size = new System.Drawing.Size(947, 275);
            this.dgv_KitapListe.TabIndex = 31;
            this.dgv_KitapListe.SelectionChanged += new System.EventHandler(this.dgv_KitapListe_SelectionChanged);
            // 
            // button_Guncelle
            // 
            this.button_Guncelle.BackColor = System.Drawing.Color.MediumPurple;
            this.button_Guncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(128)))));
            this.button_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Guncelle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Guncelle.Location = new System.Drawing.Point(154, 237);
            this.button_Guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.button_Guncelle.Name = "button_Guncelle";
            this.button_Guncelle.Size = new System.Drawing.Size(120, 58);
            this.button_Guncelle.TabIndex = 33;
            this.button_Guncelle.Text = "Güncelle";
            this.button_Guncelle.UseVisualStyleBackColor = false;
            this.button_Guncelle.Click += new System.EventHandler(this.button_Guncelle_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.BackColor = System.Drawing.Color.MediumOrchid;
            this.button_Sil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(128)))));
            this.button_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sil.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Sil.Location = new System.Drawing.Point(282, 237);
            this.button_Sil.Margin = new System.Windows.Forms.Padding(4);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(120, 58);
            this.button_Sil.TabIndex = 34;
            this.button_Sil.Text = "Sil";
            this.button_Sil.UseVisualStyleBackColor = false;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // button_Kaydet
            // 
            this.button_Kaydet.BackColor = System.Drawing.Color.BlueViolet;
            this.button_Kaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(128)))));
            this.button_Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Kaydet.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Kaydet.Location = new System.Drawing.Point(26, 237);
            this.button_Kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.button_Kaydet.Name = "button_Kaydet";
            this.button_Kaydet.Size = new System.Drawing.Size(120, 58);
            this.button_Kaydet.TabIndex = 32;
            this.button_Kaydet.Text = "Ekle";
            this.button_Kaydet.UseVisualStyleBackColor = false;
            this.button_Kaydet.Click += new System.EventHandler(this.button_Kaydet_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_geri.BackgroundImage")));
            this.btn_geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(128)))));
            this.btn_geri.Location = new System.Drawing.Point(982, 575);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(35, 29);
            this.btn_geri.TabIndex = 35;
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.UseWaitCursor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Kitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1017, 606);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.button_Guncelle);
            this.Controls.Add(this.button_Sil);
            this.Controls.Add(this.button_Kaydet);
            this.Controls.Add(this.dgv_KitapListe);
            this.Controls.Add(this.textBox1_kitapbarkod);
            this.Controls.Add(this.kitapbarkod);
            this.Controls.Add(this.textBox_SayfaSayisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_Tur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_YayinEvi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_KitapKayit);
            this.Controls.Add(this.textBox_Yazar);
            this.Controls.Add(this.textBox_kitapAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Kitaplar";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Kitaplar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KitapListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_kitapbarkod;
        private System.Windows.Forms.Label kitapbarkod;
        private System.Windows.Forms.TextBox textBox_SayfaSayisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Tur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_YayinEvi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_KitapKayit;
        private System.Windows.Forms.TextBox textBox_Yazar;
        private System.Windows.Forms.TextBox textBox_kitapAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_KitapListe;
        private System.Windows.Forms.Button button_Guncelle;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Kaydet;
        private System.Windows.Forms.Button btn_geri;
    }
}