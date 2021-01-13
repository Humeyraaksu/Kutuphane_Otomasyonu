using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DataTransferObject;
using DataAccessLayer;

namespace BusinessLayer
{
    public class KitapBL : IKitapBL
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

        public void update(string OleDbCumlesi)
        {
            OleDbCommand command = cmd.command(OleDbCumlesi);
            command.ExecuteNonQuery();
            bag.baglantiKapat();

        }
        public List<KitapDTO> kitapListesi(string OleDbCumlesi)
        {
            OleDbCommand command = cmd.command(OleDbCumlesi);
            OleDbDataReader dr = command.ExecuteReader();
            List<KitapDTO> kdto = new List<KitapDTO>();

            while (dr.Read())
            {
                kdto.Add(new KitapDTO
                {
                    id = Convert.ToInt32(dr["id"].ToString()),
                    kitap_adi = dr["kitap_adi"].ToString(),

                    yazar = dr["yazar"].ToString(),
                    tur = dr["tur"].ToString(),
                    yayin_evi = dr["yayin_evi"].ToString(),
                    basim_tarihi = Convert.ToDateTime(dr["basim_tarihi"].ToString()),
                    sayfa = Convert.ToInt32(dr["sayfa"].ToString()),
                    barkod = Convert.ToInt32(dr["Kitap_Barkod"].ToString())
                });
            }
            bag.baglantiKapat();
            return kdto;
        }

        public List<KitapDTO> kitapListesi(string OleDbCumlesi, string ifade)
        {
            OleDbCommand command = cmd.command(OleDbCumlesi);
            OleDbDataReader dr = command.ExecuteReader();
            List<KitapDTO> kdto = new List<KitapDTO>();

            while (dr.Read())
            {
                kdto.Add(new KitapDTO
                {
                    id = Convert.ToInt32(dr["id"].ToString()),
                    kitap_adi = dr["kitap_adi"].ToString(),

                    yazar = dr["yazar"].ToString(),
                    tur = dr["tur"].ToString(),
                    yayin_evi = dr["yayin_evi"].ToString(),
                    basim_tarihi = Convert.ToDateTime(dr["basim_tarihi"].ToString()),
                    sayfa = Convert.ToInt32(dr["sayfa"].ToString()),
                    barkod = Convert.ToInt32(dr["Kitap_Barkod"].ToString())
                });
            }
            bag.baglantiKapat();
            return kdto;
        }


    }
}
