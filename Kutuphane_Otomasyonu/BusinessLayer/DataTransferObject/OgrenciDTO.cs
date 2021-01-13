using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataTransferObject
{
    public class OgrenciDTO
    {
        public int id { get; set; }
        public string tc_no { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string telefon { get; set; }
        public string e_mail { get; set; }

    }
}
