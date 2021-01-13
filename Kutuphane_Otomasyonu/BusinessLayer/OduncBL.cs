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
    public class OduncBL : IOduncBL
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

        public List<Odunc_DTO> oduncListeleme(int id)
        {
            OleDbCommand command = cmd.command("SELECT * FROM Odunc WHERE id = " + id + "");
            OleDbDataReader dr = command.ExecuteReader();
            List<Odunc_DTO> dto = new List<Odunc_DTO>();



            try
            {
                while (dr.Read())
                {
                    // DateTime d;
                    // DateTime.TryParse(dr["TeslimTarihi"].ToString(), out d);
                    dto.Add(new Odunc_DTO
                    {
                        OduncID = Convert.ToInt32(dr["OduncID"].ToString()),
                        tc_no = Convert.ToInt32(dr["tc_no"].ToString()),
                        id = Convert.ToInt32(dr["id"].ToString()),
                        VerilisTarihi = Convert.ToDateTime(dr["VerilisTarihi"].ToString()),
                        TeslimTarihi = Convert.ToDateTime(dr["TeslimTarihi"].ToString()),
                        Ceza = Convert.ToInt32(dr["Ceza"].ToString()),
                        OduncDurumu = Convert.ToInt32(dr["OduncDurumu"].ToString()),
                    });
                }
            }
            catch
            {
                while (dr.Read())
                {
                    // DateTime d;
                    // DateTime.TryParse(dr["TeslimTarihi"].ToString(), out d);
                    dto.Add(new Odunc_DTO
                    {
                        OduncID = Convert.ToInt32(dr["OduncID"].ToString()),
                        tc_no = Convert.ToInt32(dr["tc_no"].ToString()),
                        id = Convert.ToInt32(dr["id"].ToString()),
                        VerilisTarihi = Convert.ToDateTime(dr["VerilisTarihi"].ToString()),
                        Ceza = Convert.ToInt32(dr["Ceza"].ToString()),
                        OduncDurumu = Convert.ToInt32(dr["OduncDurumu"].ToString()),
                    });
                }
            }

            bag.baglantiKapat();
            return dto;
        }

        public List<Odunc_DTO> oduncListesi(string OleDbCumlesi)
        {
            OleDbCommand command = cmd.command(OleDbCumlesi);
            OleDbDataReader dr = command.ExecuteReader();
            List<Odunc_DTO> dto = new List<Odunc_DTO>();
            try
            {
                while(dr.Read())
                {
                    // DateTime d;
                    // DateTime.TryParse(dr["TeslimTarihi"].ToString(), out d);
                    dto.Add(new Odunc_DTO
                    {
                        OduncID = Convert.ToInt32(dr["OduncID"].ToString()),
                        tc_no = Convert.ToInt32(dr["tc_no"].ToString()),
                        id = Convert.ToInt32(dr["id"].ToString()),
                        VerilisTarihi = Convert.ToDateTime(dr["VerilisTarihi"].ToString()),
                        TeslimTarihi = Convert.ToDateTime(dr["TeslimTarihi"].ToString()),
                        Ceza = Convert.ToInt32(dr["Ceza"].ToString()),
                        OduncDurumu = Convert.ToInt32(dr["OduncDurumu"].ToString()),

                    }) ;
                }

            }
            catch
            {
                while (dr.Read())
                {
                    // DateTime d;
                    // DateTime.TryParse(dr["TeslimTarihi"].ToString(), out d);
                    dto.Add(new Odunc_DTO
                    {
                        OduncID = Convert.ToInt32(dr["OduncID"].ToString()),
                        tc_no = Convert.ToInt32(dr["tc_no"].ToString()),
                        id = Convert.ToInt32(dr["id"].ToString()),
                        VerilisTarihi = Convert.ToDateTime(dr["VerilisTarihi"].ToString()),
                        Ceza = Convert.ToInt32(dr["Ceza"].ToString()),
                        OduncDurumu = Convert.ToInt32(dr["OduncDurumu"].ToString()),
                    });
                }

            }
            bag.baglantiKapat();
            return dto;
        }

        public void update(string OleDbCumlesi)
        {
            OleDbCommand command = cmd.command(OleDbCumlesi);
            command.ExecuteNonQuery();
            bag.baglantiKapat();
        }
    }
}
