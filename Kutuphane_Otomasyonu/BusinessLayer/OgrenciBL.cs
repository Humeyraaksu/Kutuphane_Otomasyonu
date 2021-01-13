using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DataTransferObject;
using DataAccessLayer;
using System.Data.OleDb;


namespace BusinessLayer
{
    public class OgrenciBL : IOgrenciBL
    {
        Baglanti bag = new Baglanti();
        Command cmd = new Command();
        public void delete(string OleDbCumlesi)
        {
            OleDbCommand command = cmd.command(OleDbCumlesi);
            command.ExecuteNonQuery();
            bag.baglantiKapat();
        }

        public int insert(string OleDbCumlesi)
        {
            OleDbCommand command = cmd.command(OleDbCumlesi);
            command.ExecuteNonQuery();
            bag.baglantiKapat();
            return 0;
        }

        public List<OgrenciDTO> ogrenciListesi(string OleDbCumlesi)
        {

            OleDbCommand command = cmd.command(OleDbCumlesi);
            OleDbDataReader dr = command.ExecuteReader();
            List<OgrenciDTO> odto = new List<OgrenciDTO>();

            while (dr.Read())
            {
                odto.Add(new OgrenciDTO
                {
                    id = Convert.ToInt32(dr["id"].ToString()),
                    tc_no = dr["tc_no"].ToString(),
                    ad = dr["ad"].ToString(),
                    soyad = dr["soyad"].ToString(),
                    telefon = dr["telefon"].ToString(),
                    e_mail = dr["e_mail"].ToString()

                });
            }
            bag.baglantiKapat();
            return odto;
        }

        public void update(string OleDbCumlesi)
        {
            OleDbCommand command = cmd.command(OleDbCumlesi);
            command.ExecuteNonQuery();
            bag.baglantiKapat();
        }
    }
}
