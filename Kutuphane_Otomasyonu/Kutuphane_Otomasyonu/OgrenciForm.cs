using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.DataTransferObject;

namespace Kutuphane_Otomasyonu
{
    
    public partial class OgrenciForm : Form
    {
        IOgrenciBL ogrenciBL;
        IOduncBL oduncBL;
        public OgrenciForm()
        {
            InitializeComponent();
        }
        void ogrenciliste()
        {
            //veritanındaki öğrenci tablosundaki tüm verileri getiriyor
            ogrenciBL = new OgrenciBL();
            var sonuc = ogrenciBL.ogrenciListesi("SELECT * FROM Ogrencinin");
            dgv_ogrenci.DataSource = sonuc;
            dgv_ogrenci.Columns["id"].Visible = false;
            dgv_ogrenci.Columns[1].HeaderText = "TC No";
            dgv_ogrenci.Columns[2].HeaderText = "Ad";
            dgv_ogrenci.Columns[3].HeaderText = "Soyad";
            dgv_ogrenci.Columns[4].HeaderText = "Telefon";
            dgv_ogrenci.Columns[5].HeaderText = "E-mail";
        }
        void kitaplarinilistele(int ogr_id)
        {
            //öğrencinin kitaplarını listeliyor

            oduncBL = new OduncBL();
            //var sonuckitap = oduncBL.oduncListesi("select * from Odunc where tc_no = " + ogr_id + "");
            var sonuckitap = oduncBL.oduncListesi("SELECT * FROM Odunc WHERE tc_no = " + ogr_id + " ");
            dgv_Kitaplari.DataSource = sonuckitap;
            dgv_Kitaplari.Columns["tc_no"].Visible = false;
            dgv_Kitaplari.Columns[0].HeaderText = "Emanet No";
            dgv_Kitaplari.Columns[2].HeaderText = "Kitap ID";
            dgv_Kitaplari.Columns[3].HeaderText = "Veriliş Tarihi";
            dgv_Kitaplari.Columns[4].HeaderText = "Teslim Tarihi";
            dgv_Kitaplari.Columns[5].HeaderText = "Ceza";
            dgv_Kitaplari.Columns[6].HeaderText = "Emanet Durumu";


            foreach (DataGridViewRow satir_numarasi in dgv_Kitaplari.Rows)
            {//kayıtlı öğrencilerin odunc aldığı kitapları datagridde listeliyor
                if (Convert.ToInt32(satir_numarasi.Cells[6].Value.ToString()) == 1)
                {
                    satir_numarasi.DefaultCellStyle.BackColor = Color.Green;
                }
                else if (Convert.ToInt32(satir_numarasi.Cells[6].Value.ToString()) == 0 && (Convert.ToDateTime(satir_numarasi.Cells[3].Value.ToString()).AddDays(+7).AddDays(-1) == Convert.ToDateTime(DateTime.Now.ToShortDateString()) || Convert.ToDateTime(satir_numarasi.Cells[3].Value.ToString()).AddDays(+7).AddDays(-1) == Convert.ToDateTime(DateTime.Now.ToShortDateString()) || Convert.ToDateTime(satir_numarasi.Cells[3].Value.ToString()).AddDays(+7).AddDays(0) == Convert.ToDateTime(DateTime.Now.ToShortDateString())))
                {
                    satir_numarasi.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (Convert.ToInt32(satir_numarasi.Cells[6].Value.ToString()) == 0 && Convert.ToDateTime(satir_numarasi.Cells[3].Value.ToString()).AddDays(+7) < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                {
                    satir_numarasi.DefaultCellStyle.BackColor = Color.Tomato;
                }
            }

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            //veritabanında öğrenci tablosuna ekleme yapıyor
            ogrenciBL = new OgrenciBL();
            ogrenciBL.insert("insert into Ogrencinin (tc_no,ad,soyad,telefon,e_mail) values ('" + txt_TcKimlik.Text + "','" + txt_Adi.Text + "','" + txt_Soyadi.Text + "','" + mastxt_telefon.Text + "','" + txt_email.Text + "')");

            MessageBox.Show("Öğrenci kayıt başarı ile tamamlandı");
            ogrenciliste();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            //veritabanındaki öğrenci tablosunda seçili öğrenciyi siliyor
            var Silinecek_kişi = (OgrenciDTO)dgv_ogrenci.SelectedRows[0].DataBoundItem;
            ogrenciBL = new OgrenciBL();
            ogrenciBL.delete("delete from Ogrencinin where id =" + Silinecek_kişi.id + "");

            MessageBox.Show("Silme işlemi gerçekleşti");
            ogrenciliste();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            //veritabanındaki öğrenci tablosunda seçili öğrenciyi güncelliyor
            var Guncellenecek_kitap = (OgrenciDTO)dgv_ogrenci.SelectedRows[0].DataBoundItem;
            ogrenciBL = new OgrenciBL();
            ogrenciBL.update("update Ogrencinin set tc_no='" + txt_TcKimlik.Text + "', ad = '" + txt_Adi.Text + "', soyad = '" + txt_Soyadi.Text + "', telefon = '" + mastxt_telefon.Text + "', e_mail = '" + txt_email.Text + "' where id=" + Guncellenecek_kitap.id + "");

            MessageBox.Show("Güncelleme işlemi gerçekleşmiştir");
            ogrenciliste();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgv_ogrenci_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgv_ogrenci.Rows.Count != 0)
            {

                if (dgv_ogrenci.SelectedRows.Count != 0)
                {
                    var Guncellenecek_kisi = (OgrenciDTO)dgv_ogrenci.SelectedRows[0].DataBoundItem;
                    txt_TcKimlik.Text = Guncellenecek_kisi.tc_no;
                    txt_Adi.Text = Guncellenecek_kisi.ad;
                    txt_Soyadi.Text = Guncellenecek_kisi.soyad;
                    mastxt_telefon.Text = Guncellenecek_kisi.telefon;
                    txt_email.Text = Guncellenecek_kisi.e_mail;

                    kitaplarinilistele(Guncellenecek_kisi.id);
                }

            }
        }

        private void dgv_ogrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programı kapatmak istiyor musunuz ? ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                this.Close();
            }
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void OgrenciForm_Load(object sender, EventArgs e)
        {
            ogrenciliste();
        }
    }
}
