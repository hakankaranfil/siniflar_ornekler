using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izsu_opp
{
    public class abone
    {
        public string aboneno;
        public string adsoyad;
        public int ilkdurum;
        public int sondurum;
        public string ödemetürü;

        public double odemeyap(double ilk, double son, string abonetürü)
        {
            double result = 0;
            if (abonetürü=="ev")
            {
                result = (son - ilk) * 0.3;
            }
            else
            {
                result = (son - ilk) * 0.5;
            }
            return result;
        }









        public override string ToString()
        {
          return  this.aboneno;
        }
    }
}
