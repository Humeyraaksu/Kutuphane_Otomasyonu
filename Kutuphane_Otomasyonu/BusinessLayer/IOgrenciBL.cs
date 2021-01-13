using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DataTransferObject;

namespace BusinessLayer
{
    public interface IOgrenciBL
    {
        int insert(string OleDbCumlesi);
        void delete(string OleDbCumlesi);
        void update(string OleDbCumlesi);
        List<OgrenciDTO> ogrenciListesi(string OleDbCumlesi);

    }
}
