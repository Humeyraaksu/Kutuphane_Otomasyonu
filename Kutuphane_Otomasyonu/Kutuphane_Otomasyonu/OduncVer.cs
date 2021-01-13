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

namespace Kutuphane_Otomasyonu
{
    public partial class OduncVer : Form
    {
        OduncBL ktp_ogr_dto;
        OgrenciBL ktp_ogr_odto;
        KitapBL ktp_ogr_kdto;
        public OduncVer()
        {
            InitializeComponent();
        }

        OduncKitap odunciade = new OduncKitap();
        public void Odunc_Listele()
        {
            //veritabanından odunc tablosundan verileri çekiyoruz
            ktp_ogr_dto = new OduncBL();
            var sonuc = ktp_ogr_dto.oduncListesi("SELECT * FROM Odunc");
            dataGrid_Kitap.DataSource = sonuc;
        }
        public void ogrenci_listele()
        {
            //veritabanında öğrenci tablosunu çekiyor ve datagrid başlıklarını değiştiriyor
            ktp_ogr_odto = new OgrenciBL();
            var ogrenci = ktp_ogr_odto.ogrenciListesi("SELECT * FROM Ogrencinin");
            dataGrid_Ogrenci.DataSource = ogrenci;
            dataGrid_Ogrenci.Columns["id"].Visible = false;
            dataGrid_Ogrenci.Columns[1].HeaderText = "TC No";
            dataGrid_Ogrenci.Columns[2].HeaderText = "Ad";
            dataGrid_Ogrenci.Columns[3].HeaderText = "Soyad";
            dataGrid_Ogrenci.Columns[4].HeaderText = "Telefon";
            dataGrid_Ogrenci.Columns[5].HeaderText = "E-mail";
        }
        public void kitap_listele()
        {
            //veritabanında kitaplar tablosunu çekiyor ve datagrid başlıklarını değiştiriyor
            ktp_ogr_kdto = new KitapBL();
            var ktp = ktp_ogr_kdto.kitapListesi("SELECT * FROM Kitaplar");
            dataGrid_Kitap.DataSource = ktp;
            dataGrid_Kitap.Columns["id"].Visible = false;
            dataGrid_Kitap.Columns[1].HeaderText = "Kitap Adı";
            dataGrid_Kitap.Columns[2].HeaderText = "Yazar";
            dataGrid_Kitap.Columns[3].HeaderText = "Tür";
            dataGrid_Kitap.Columns[4].HeaderText = "Yayınevi";
            dataGrid_Kitap.Columns[5].HeaderText = "Basım Tarihi";
            dataGrid_Kitap.Columns[6].HeaderText = "Sayfa";
            dataGrid_Kitap.Columns[7].HeaderText = "Barkod";
            dataGrid_Kitap.Columns[7].Width = 56;

        }

        private void btn_oduncver_Click(object sender, EventArgs e)
        {
            //işlemden sonra öğrenci ve kitapları listeliyor ve textboxları temizliyor 
            Odunc_Ver();
            MessageBox.Show("Kitap Ödünç Verildi");
            //Odunc_Listele();
            ogrenci_listele();
            kitap_listele();
            text_kitapid.Clear();
            text_ogrenci.Clear();
        }
        public static int secimid;
        private void dataGrid_Kitap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //kitap formundaki data gridden kitapları çekip listeliyor
            try
            {
                secimid = Convert.ToInt32(dataGrid_Kitap.CurrentRow.Cells[0].Value);
                text_kitapid.Text = dataGrid_Kitap.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Doğru Alan Seçiniz");
            }

        }

        private void OduncVer_Load(object sender, EventArgs e)
        {
            //ödünç işleminden sonra kitapları ve öğrencileri tekrar listeliyor
            kitap_listele();
            ogrenci_listele();
        }

        private void dataGrid_Ogrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //öğrenci formundaki datagriddeki öğrencileri listeliyor
            try
            {
                secimid = Convert.ToInt32(dataGrid_Ogrenci.CurrentRow.Cells[0].Value);
                text_ogrenci.Text = dataGrid_Ogrenci.CurrentRow.Cells[2].Value.ToString() + " " + dataGrid_Ogrenci.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Doğru Alanı Seçiniz");
            }
        }
        void Odunc_Ver()
        {
            //veritabanındaki odunc tablosuna ekleme işlemi yapıyor

            ktp_ogr_dto = new OduncBL();
            ktp_ogr_dto.insert("INSERT INTO Odunc (tc_no,id,VerilisTarihi,OduncDurumu) VALUES('" + Convert.ToInt32(dataGrid_Ogrenci.CurrentRow.Cells[0].Value.ToString()) + "','" + Convert.ToInt32(dataGrid_Kitap.CurrentRow.Cells[0].Value.ToString()) + "','" + String.Format("{0:d}", Convert.ToDateTime(DateTime.Now.ToShortDateString())) + "','" + "0" + "') ");

        }

        private void btn_iade_Click(object sender, EventArgs e)
        {
            odunciade.Show();
            this.Hide();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
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
    }
}
