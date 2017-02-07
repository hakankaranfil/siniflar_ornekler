using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodeFirstSporMerkezi.DbContext
{
  public  class MusBilgi
    {
        public int MusBilgiID { get; set; }
        public string Musadsoyad { get; set; }

        public string Mustel { get; set; }
        public int Mussure { get; set; }
        public int Musucret { get; set; }
        public string Muskayit { get; set; }
        public string MusTC { get; set; }

        public string Musbitis { get; set; }
    }
}
