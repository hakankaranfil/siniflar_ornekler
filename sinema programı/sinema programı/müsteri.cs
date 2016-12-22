using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinema_programı
{
    class müsteri
    {
        public int koltukno;
        public string adsoyad;
        public string durum;
        public int ödeme;



        public int ödemeyap(string durum)

        {
            int miktar = 0;
            if (durum=="ögreci")
            {
                miktar = 10;
            }
            else
            {
                miktar = 20;
            }
            return miktar;
        }
        public override string ToString()
        {
        return "koltuk no:" +   this.koltukno + " " + "Adısoyadı: " + this.adsoyad+" "+"ödenecek tutar "+this.ödeme ;
        }

    }
}
