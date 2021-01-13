using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DataTransferObject;

namespace BusinessLayer
{
    public interface IOduncBL
    {
        int insert(string OleDbCumlesi);
        void delete(string OleDbCumlesi);
        void update(string OleDbCumlesi);

        List<Odunc_DTO> oduncListesi(string OleDbCumlesi);
        List<Odunc_DTO> oduncListeleme(int id);

    }
}
