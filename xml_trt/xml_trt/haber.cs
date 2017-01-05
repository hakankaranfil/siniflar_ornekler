using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml_trt
{
   public class haber
    {
        public  string ad { get; set; }
         public  string aciklama { get; set; }
        public DateTime tarih { get; set; }
        public haber(string ad,string aciklama)
        {
            this.ad = ad;
            this.aciklama = aciklama;
       
        }
        public override string ToString()
        {
            return this.ad + "\t" + this.aciklama;
        }
    }
}
