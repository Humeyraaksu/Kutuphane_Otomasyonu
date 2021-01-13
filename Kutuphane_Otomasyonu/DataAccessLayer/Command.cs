using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DataAccessLayer
{
    public class Command
    {
        Baglanti baglanti = new Baglanti();

        public OleDbCommand command(string OleDbCumlesi)
        {//OleDbCommandkomutu ile tablomuzdaki tüm verileri almak için gerekn sql cümlemizi yazıyoruz. 
            OleDbCommand cmd = new OleDbCommand(OleDbCumlesi, baglanti.baglantiAc());

            return cmd;
        }



    }
}
