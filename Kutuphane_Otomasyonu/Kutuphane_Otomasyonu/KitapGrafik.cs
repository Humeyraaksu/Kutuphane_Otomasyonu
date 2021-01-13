using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using BusinessLayer;

namespace Kutuphane_Otomasyonu
{
    public partial class KitapGrafik : Form
    {
        IKitapBL kitapBL;
        IOduncBL oduncBL;
        public KitapGrafik()
        {
            InitializeComponent();
        }

        public void veri_yenile()
        {
            bool ekle = true;
            kitapBL = new KitapBL();
            oduncBL = new OduncBL();
            dataGVKitap.DataSource = kitapBL.kitapListesi("SELECT * FROM Kitaplar");
            dataGVEmanet.DataSource = oduncBL.oduncListesi("SELECT * FROM Odunc WHERE OduncDurumu=0");

            DataTable dt = new DataTable();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();

            for (int i = 0; i < dataGVKitap.Rows.Count; i++)
            {
                for (int j = 0; j < dataGVEmanet.Rows.Count - 1; j++)
                {
                    if (dataGVKitap.Rows[i].Cells[0].Value.ToString() == dataGVEmanet.Rows[j].Cells[0].Value.ToString())
                    {
                        ekle = false;
                    }
                }
                if (ekle)
                {
                    dt.Rows.Add(dataGVKitap.Rows[i].Cells[0].Value.ToString(),
                        dataGVKitap.Rows[i].Cells[1].Value.ToString(),
                        dataGVKitap.Rows[i].Cells[2].Value.ToString(),
                        dataGVKitap.Rows[i].Cells[3].Value.ToString(),
                        dataGVKitap.Rows[i].Cells[4].Value.ToString(),
                        dataGVKitap.Rows[i].Cells[5].Value.ToString(),
                        dataGVKitap.Rows[i].Cells[6].Value.ToString(),
                        dataGVKitap.Rows[i].Cells[7].Value.ToString()
                        );
                }
                else
                {
                    ekle = true;
                }


            }

            dataGridView.DataSource = dt;

        }

        private void KitapGrafik_Load(object sender, EventArgs e)
        {
            veri_yenile();
            GraphPane pane = zedGraphControl1.GraphPane;
            string[] etiketler = { "Emanettekiler ", "Verilebilir", "Hepsi" };
            double[] y = { dataGVEmanet.Rows.Count + 1, dataGridView.Rows.Count - 1, dataGVKitap.Rows.Count };
            pane.AddPieSlices(y, new[] { "Emanettekiler", "Verilebilir", null });
            pane.Legend.IsVisible = true;
            pane.Title.Text = "KÜTÜPHANE GRAFİK";
            LineItem line = pane.AddCurve(null, null, y, Color.Red);
            line.Line.Fill = new Fill(Color.Aqua, Color.Orange, Color.DarkRed);

            pane.XAxis.Scale.TextLabels = etiketler;
            pane.XAxis.Type = AxisType.Text;

            pane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 90F);
            pane.Fill = new Fill(Color.FromArgb(250, 250, 255));
            zedGraphControl1.AxisChange();

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
