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
    public partial class OduncKitap : Form
    {
        IOduncBL emanetBL;
        public OduncKitap()
        {
            InitializeComponent();
        }
        void Odunc_Listele()
        {//oduncver formundaki odunc verdiğimiz kitapları çekip  datafrid de listeliyor ve datagrid başlıklarını değiştirmek için gereken kodlar var
            emanetBL = new OduncBL();
            var sonuc = emanetBL.oduncListesi("SELECT * FROM Odunc");
            dataGrid_Kitap.DataSource = sonuc;
            dataGrid_Kitap.Columns[0].HeaderText = "Emanet No";
            dataGrid_Kitap.Columns[1].HeaderText = "Öğrenci ID";
            dataGrid_Kitap.Columns[2].HeaderText = "Kitap ID";
            dataGrid_Kitap.Columns[3].HeaderText = "Veriliş Tarihi";
            dataGrid_Kitap.Columns[4].HeaderText = "Teslim Tarihi";
            dataGrid_Kitap.Columns[5].HeaderText = "Ceza";
            dataGrid_Kitap.Columns[6].HeaderText = "Emanet Durumu";


            foreach (DataGridViewRow satir_numarasi in dataGrid_Kitap.Rows)
            {
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
        void Odunc_Teslim()
        {//veritabanındaki odunc tablosunda teslim ettikten sonra güncelleme yapıyor
            emanetBL = new OduncBL();
            emanetBL.update("UPDATE Odunc SET TeslimTarihi='" + String.Format("{0:d}", Convert.ToDateTime(DateTime.Now.ToShortDateString())) + "', OduncDurumu=" + 1 + " Where OduncID= " + Convert.ToInt32(label7.Text) + "");
        }

        private void OduncKitap_Load(object sender, EventArgs e)
        {
            Odunc_Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //İade işlemleri
            Odunc_Teslim();
            MessageBox.Show("İade İşlemi Yapılmıştır.");
            Odunc_Listele();
        }
        public static int secim;
        private void dataGrid_Kitap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                secim = Convert.ToInt32(dataGrid_Kitap.CurrentRow.Cells[0].Value.ToString());
                label7.Text = dataGrid_Kitap.CurrentRow.Cells[0].Value.ToString();
                label8.Text = dataGrid_Kitap.CurrentRow.Cells[1].Value.ToString();
                label9.Text = dataGrid_Kitap.CurrentRow.Cells[2].Value.ToString();
                label10.Text = dataGrid_Kitap.CurrentRow.Cells[3].Value.ToString();
                label11.Text = dataGrid_Kitap.CurrentRow.Cells[4].Value.ToString();
                label12.Text = dataGrid_Kitap.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Doğru Alanı Seçiniz.");
            }
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
