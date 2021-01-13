
namespace Kutuphane_Otomasyonu
{
    partial class OgrenciForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mastxt_telefon = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_Soyadi = new System.Windows.Forms.TextBox();
            this.txt_Adi = new System.Windows.Forms.TextBox();
            this.txt_TcKimlik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_ogrenci = new System.Windows.Forms.DataGridView();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.dgv_Kitaplari = new System.Windows.Forms.DataGridView();
            this.btn_geri = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ogrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kitaplari)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1194, 37);
            this.panel1.TabIndex = 3;
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
            this.btn_min.Location = new System.Drawing.Point(1083, 3);
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
            this.btn_max.Location = new System.Drawing.Point(1128, 3);
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
            this.btn_exit.Location = new System.Drawing.Point(1167, 3);
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
            this.label1.Size = new System.Drawing.Size(247, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "KÜTÜPHANE | Öğrenci Listesi";
            this.label1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Thistle;
            this.groupBox1.Controls.Add(this.mastxt_telefon);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_Soyadi);
            this.groupBox1.Controls.Add(this.txt_Adi);
            this.groupBox1.Controls.Add(this.txt_TcKimlik);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(13, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(385, 245);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrencinin";
            // 
            // mastxt_telefon
            // 
            this.mastxt_telefon.Location = new System.Drawing.Point(137, 144);
            this.mastxt_telefon.Margin = new System.Windows.Forms.Padding(4);
            this.mastxt_telefon.Mask = "(999) 000-0000";
            this.mastxt_telefon.Name = "mastxt_telefon";
            this.mastxt_telefon.Size = new System.Drawing.Size(203, 28);
            this.mastxt_telefon.TabIndex = 4;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(137, 185);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(203, 28);
            this.txt_email.TabIndex = 5;
            // 
            // txt_Soyadi
            // 
            this.txt_Soyadi.Location = new System.Drawing.Point(137, 111);
            this.txt_Soyadi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Soyadi.Name = "txt_Soyadi";
            this.txt_Soyadi.Size = new System.Drawing.Size(203, 28);
            this.txt_Soyadi.TabIndex = 3;
            // 
            // txt_Adi
            // 
            this.txt_Adi.Location = new System.Drawing.Point(137, 78);
            this.txt_Adi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Adi.Name = "txt_Adi";
            this.txt_Adi.Size = new System.Drawing.Size(203, 28);
            this.txt_Adi.TabIndex = 2;
            // 
            // txt_TcKimlik
            // 
            this.txt_TcKimlik.Location = new System.Drawing.Point(137, 44);
            this.txt_TcKimlik.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TcKimlik.Name = "txt_TcKimlik";
            this.txt_TcKimlik.Size = new System.Drawing.Size(203, 28);
            this.txt_TcKimlik.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "T.C Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adı :";
            // 
            // dgv_ogrenci
            // 
            this.dgv_ogrenci.AllowUserToAddRows = false;
            this.dgv_ogrenci.AllowUserToDeleteRows = false;
            this.dgv_ogrenci.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgv_ogrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ogrenci.GridColor = System.Drawing.SystemColors.Menu;
            this.dgv_ogrenci.Location = new System.Drawing.Point(406, 60);
            this.dgv_ogrenci.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ogrenci.Name = "dgv_ogrenci";
            this.dgv_ogrenci.ReadOnly = true;
            this.dgv_ogrenci.RowHeadersWidth = 51;
            this.dgv_ogrenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ogrenci.Size = new System.Drawing.Size(743, 245);
            this.dgv_ogrenci.TabIndex = 10;
            this.dgv_ogrenci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ogrenci_CellContentClick);
            this.dgv_ogrenci.CurrentCellChanged += new System.EventHandler(this.dgv_ogrenci_CurrentCellChanged);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Guncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(128)))));
            this.btn_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guncelle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(139, 322);
            this.btn_Guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(120, 58);
            this.btn_Guncelle.TabIndex = 37;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.MediumOrchid;
            this.btn_Sil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(128)))));
            this.btn_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sil.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(267, 322);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(120, 58);
            this.btn_Sil.TabIndex = 38;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Ekle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(128)))));
            this.btn_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ekle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(11, 322);
            this.btn_Ekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(120, 58);
            this.btn_Ekle.TabIndex = 36;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // dgv_Kitaplari
            // 
            this.dgv_Kitaplari.AllowUserToAddRows = false;
            this.dgv_Kitaplari.AllowUserToDeleteRows = false;
            this.dgv_Kitaplari.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgv_Kitaplari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Kitaplari.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Kitaplari.Location = new System.Drawing.Point(7, 388);
            this.dgv_Kitaplari.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Kitaplari.Name = "dgv_Kitaplari";
            this.dgv_Kitaplari.ReadOnly = true;
            this.dgv_Kitaplari.RowHeadersWidth = 51;
            this.dgv_Kitaplari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Kitaplari.Size = new System.Drawing.Size(1142, 200);
            this.dgv_Kitaplari.TabIndex = 35;
            // 
            // btn_geri
            // 
            this.btn_geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_geri.BackgroundImage")));
            this.btn_geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(128)))));
            this.btn_geri.Location = new System.Drawing.Point(1156, 557);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(38, 31);
            this.btn_geri.TabIndex = 39;
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.UseWaitCursor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(125)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1194, 599);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.dgv_Kitaplari);
            this.Controls.Add(this.dgv_ogrenci);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OgrenciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciForm";
            this.Load += new System.EventHandler(this.OgrenciForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ogrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kitaplari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mastxt_telefon;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_Soyadi;
        private System.Windows.Forms.TextBox txt_Adi;
        private System.Windows.Forms.TextBox txt_TcKimlik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_ogrenci;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.DataGridView dgv_Kitaplari;
        private System.Windows.Forms.Button btn_geri;
    }
}