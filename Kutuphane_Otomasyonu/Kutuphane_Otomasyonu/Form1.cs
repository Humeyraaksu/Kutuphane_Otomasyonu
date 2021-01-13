using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu
{
    public partial class AnaForm : Form
    {
        KitapAra KitapAra = new KitapAra();
        Kitaplar Kitaplar = new Kitaplar();
        OduncKitap OduncKitap = new OduncKitap();
        OduncVer OduncVer = new OduncVer();
        OgrenciForm OgrenciForm = new OgrenciForm();
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btn_kitap_Click(object sender, EventArgs e)
        {
            Kitaplar.Show();
        }

        private void btn_ogrenci_Click(object sender, EventArgs e)
        {
            OgrenciForm.Show();
        }

        private void btn_oduncVer_Click(object sender, EventArgs e)
        {
            OduncVer.Show();
        }

        private void btn_oduncte_Click(object sender, EventArgs e)
        {
            OduncKitap.Show();
        }

        private void btn_arama_Click(object sender, EventArgs e)
        {
            KitapAra.Show();
        }

        private void btn_grafik_Click(object sender, EventArgs e)
        {
            KitapGrafik kitapGrafik = new KitapGrafik();
            kitapGrafik.Show();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
           
            DialogResult cıkıs = new DialogResult();
            cıkıs = MessageBox.Show("Programı kapatma istediğinize emin misiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo);
            if (cıkıs == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Çıkış yapılmadı");
            }
            Application.Exit();
        }
    }

}
