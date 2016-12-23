using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izsu_opp
{
    public class abone
    {
        public int aboneno;
        public string adsoyad;
        public int ilkdurum;
        public int sondurum;
        public string ödemetürü;
        public double güncelborc;

        public double odemeyap(double ilk, double son, string abonetürü)
        {
            double result;
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
            return this.aboneno + " " + this.adsoyad;
        }
    }
}
