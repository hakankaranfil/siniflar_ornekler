using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml_örnek
{
    public class haber
    {
        public string ad { get; set; }
        public string aciklama{ get; set; }

        public haber(string ad,string aciklama)
        {
            this.ad = ad;
            this.aciklama = aciklama;
        }

    }
}
