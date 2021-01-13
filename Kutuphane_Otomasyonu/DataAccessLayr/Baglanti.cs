using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DataAccessLayer
{
    public class Baglanti
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=KutuphaneData1.accdb");

        public OleDbConnection baglantiAc()
        {
            conn.Open();
            return conn;
        }

        public OleDbConnection baglantiKapat()
        {
            conn.Close();
            return conn;

        }
    }
}
