using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spor_salonu
{
   public class musteri
    {
        public string adsoyad { get; set; }
        public int kayıtno { get; set; }
        public string telno { get; set; }
        public string tckimlik { get; set; }
        public string sure { get; set; }
        public int ucret { get; set; }
        public override string ToString()
        {
            return "kayıt no=" + this.kayıtno + " " + "Adsoyad=" + this.adsoyad;
        }

    }
}
