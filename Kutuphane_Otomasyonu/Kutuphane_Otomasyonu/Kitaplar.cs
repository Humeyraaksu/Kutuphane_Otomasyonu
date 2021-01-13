using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.DataTransferObject;
using BusinessLayer;

namespace Kutuphane_Otomasyonu
{
    public partial class Kitaplar : Form
    {
        IKitapBL kitapBL;
        bool guncelle = false;
        public Kitaplar()
        {
            InitializeComponent();
        }

        private void Kitaplar_Load(object sender, EventArgs e)
        {
            kitapliste();
        }
        void kitapliste()
        {//veritanında kitaplar tablosundan verileri çekiyor
            kitapBL = new KitapBL();
            var sonuc = kitapBL.kitapListesi("SELECT * FROM Kitaplar");
            dgv_KitapListe.DataSource = sonuc;
            dgv_KitapListe.Columns["Id"].Visible = false;
            dgv_KitapListe.Columns[1].HeaderText = "Kitap Adı";
            dgv_KitapListe.Columns[2].HeaderText = "Yazar";
            dgv_KitapListe.Columns[3].HeaderText = "Tür";
            dgv_KitapListe.Columns[4].HeaderText = "Yayınevi";
            dgv_KitapListe.Columns[5].HeaderText = "Basım Tarihi";
            dgv_KitapListe.Columns[6].HeaderText = "Sayfa";
            dgv_KitapListe.Columns[7].HeaderText = "Barkod";
            dgv_KitapListe.Columns[7].Width = 56;
        }

        private void button_Kaydet_Click(object sender, EventArgs e)
        {
            //kitap ekleme işlemi yapıyor
            kitapBL = new KitapBL();
            kitapBL.insert("insert into Kitaplar(kitap_adi,yazar,tur,yayin_evi,basim_tarihi,sayfa) values ('" + textBox_kitapAdi.Text + "','" + textBox_Yazar.Text + "','" + comboBox_Tur.SelectedItem + "','" + textBox_YayinEvi.Text + "','" + Convert.ToDateTime(dtp_KitapKayit.Text) + "','" + textBox_SayfaSayisi.Text + "')");

            MessageBox.Show("Ekleme işlemi başarı ile tamamlandı");
            kitapliste();

        }
        void kitap_guncelle()
        {//kayıtlı olan kitapların bilgisini güncelleme işlemi yapıyor
            try
            {
                var Guncellenecek_kitap = (KitapDTO)dgv_KitapListe.SelectedRows[0].DataBoundItem;
                kitapBL = new KitapBL();
                kitapBL.update("update Kitaplar set kitap_adi='" + textBox_kitapAdi.Text + "', yazar = '" + textBox_Yazar.Text + "', tur = '" + comboBox_Tur.SelectedItem + "', yayin_evi = '" + textBox_YayinEvi.Text + "', basim_tarihi = '" + dtp_KitapKayit.Value + "', sayfa= " + Convert.ToInt32(textBox_SayfaSayisi.Text) + ", Kitap_Barkod = " + Convert.ToInt32(textBox1_kitapbarkod.Text) + " where id=" + Convert.ToInt32(dgv_KitapListe.CurrentRow.Cells[0].Value.ToString()) + "");

                MessageBox.Show("Güncelleme işlemi gerçekleşmiştir");
            }
            catch (Exception)
            {
                MessageBox.Show("Boş bırakılan yerleri doldurunuz.");

            }
        }
        private void button_Guncelle_Click(object sender, EventArgs e)
        {

            //var Guncellenecek_kitap = (KitapDTO)dgv_KitapListe.SelectedRows[0].DataBoundItem;
            //kitapBL = new KitapBL();
            //kitapBL.update("update Kitaplar set kitap_adi='" + textBox_kitapAdi.Text + "', yazar = '" + textBox_Yazar.Text + "', tur = '" + comboBox_Tur.SelectedItem + "', yayin_evi = '" + textBox_YayinEvi.Text + "', basim_tarihi = '" + dtp_KitapKayit.Value +  "', sayfa= " + Convert.ToInt32(textBox_SayfaSayisi.Text) + ", Kitap_Barkod = "+ Convert.ToInt32(textBox1_kitapbarkod.Text)+" where id=" + Convert.ToInt32(dgv_KitapListe.CurrentRow.Cells[0].Value.ToString()) +"");

            //MessageBox.Show("Güncelleme işlemi gerçekleşmiştir");

            kitap_guncelle();
            kitapliste();


            //kitapliste();

        }

        private void dgv_KitapListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_KitapListe.SelectedRows.Count != 0)
            {
                var Guncellenecek_kitap = (KitapDTO)dgv_KitapListe.SelectedRows[0].DataBoundItem;
                textBox_kitapAdi.Text = Guncellenecek_kitap.kitap_adi;
                textBox_Yazar.Text = Guncellenecek_kitap.yazar;
                comboBox_Tur.SelectedItem = Guncellenecek_kitap.tur;
                textBox_YayinEvi.Text = Guncellenecek_kitap.yayin_evi;
                dtp_KitapKayit.Value = Guncellenecek_kitap.basim_tarihi;
                textBox_SayfaSayisi.Text = Guncellenecek_kitap.sayfa.ToString();

            }

        }

        private void button_Sil_Click(object sender, EventArgs e)
        {
            //kayıtlı verileri siliyor

            var Silinecek_kitap = Convert.ToInt32(dgv_KitapListe.CurrentRow.Cells[0].Value.ToString());
            kitapBL = new KitapBL();
            kitapBL.delete("delete from Kitaplar where id =" + Silinecek_kitap + "");

            MessageBox.Show("Silme işlemi gerçekleşti");
            kitapliste();


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
