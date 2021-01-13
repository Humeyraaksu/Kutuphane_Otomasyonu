using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataTransferObject
{
    public class KitapDTO
    {
        public int id { get; set; }
        public string kitap_adi { get; set; }
        public string yazar { get; set; }
        public string tur { get; set; }
        public string yayin_evi { get; set; }
        public DateTime basim_tarihi { get; set; }
        public int sayfa { get; set; }
        public int barkod { get; set; }
    }
}
