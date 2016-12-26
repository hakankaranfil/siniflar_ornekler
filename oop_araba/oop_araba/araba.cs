using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_araba
{
    class araba
    {
        public int yakıtdepokapasite { get; set; }
        public double ortalamatüketim { get; set; }
        public static double yakıtfiyatı { get; set; }




        public double toplamyol
        {
            get
            {
                return (yakıtdepokapasite / ortalamatüketim) * 100;
            }
        }
        public double ücrethesaplama(double km)
        {
            return km * (ortalamatüketim / 100) * yakıtfiyatı;

        }
        public araba(int yakitkapasite, double orttuk)
        {

            this.yakıtdepokapasite = yakitkapasite;
            this.ortalamatüketim = orttuk;


        }
    }
}
