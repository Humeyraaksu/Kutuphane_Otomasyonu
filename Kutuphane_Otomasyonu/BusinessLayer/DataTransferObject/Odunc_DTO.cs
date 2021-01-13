using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataTransferObject
{
    public class Odunc_DTO
    {
        public int OduncID { get; set; }
        public int tc_no { get; set; }
        public int id { get; set; }
        public DateTime VerilisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public int Ceza { get; set; }
        public int OduncDurumu { get; set; }
    }
}
