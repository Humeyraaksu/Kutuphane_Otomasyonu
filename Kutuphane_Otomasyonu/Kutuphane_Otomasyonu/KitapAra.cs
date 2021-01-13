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
    public partial class KitapAra : Form
    {
        IKitapBL kitapBL;
        IOduncBL oduncBL;
        public KitapAra()
        {
            InitializeComponent();
        }

        void KitapTakip_Listele()
        {
            //textboxa kitap adı veya barkoduyla arama yaparak kitap bilgilerini listeliyor
            string ifade = "";
            ifade = text_arama.Text;

            kitapBL = new KitapBL();
            var kitaptakip = kitapBL.kitapListesi("select * from Kitaplar where kitap_adi like '%" + ifade + "%' OR Kitap_Barkod like '%" + ifade + "%'", ifade);

            try
            {
                l_adi.Text = kitaptakip.First().kitap_adi;
                l_yazar.Text = kitaptakip.First().yazar;
                l_yayinevi.Text = kitaptakip.First().yayin_evi;
                l_tur.Text = kitaptakip.First().tur;
                l_tarih.Text = kitaptakip.First().basim_tarihi.ToShortDateString();
                l_sayfa.Text = kitaptakip.First().sayfa.ToString();
                l_barkod.Text = kitaptakip.First().barkod.ToString();


                oduncBL = new OduncBL();
                var alan_kisiler = oduncBL.oduncListeleme(kitaptakip.First().id);
                dataGV_aldiklari.DataSource = alan_kisiler;
                dataGV_aldiklari.Columns[0].HeaderText = "Emanet No";
                dataGV_aldiklari.Columns[1].HeaderText = "Öğrenci ID";
                dataGV_aldiklari.Columns[2].HeaderText = "Kitap ID";
                dataGV_aldiklari.Columns[3].HeaderText = "Veriliş Tarihi";
                dataGV_aldiklari.Columns[4].HeaderText = "Teslim Tarihi";
                dataGV_aldiklari.Columns[5].HeaderText = "Ceza";
                dataGV_aldiklari.Columns[6].HeaderText = "Emanet Durumu";
                foreach (DataGridViewRow satir_numarasi in dataGV_aldiklari.Rows)
                {
                    //teslim edilmiş ve alınmış kitapları listeliyor
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
            catch (Exception)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitapTakip_Listele();
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
