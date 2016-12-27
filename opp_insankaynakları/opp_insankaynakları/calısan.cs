using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_insankaynakları
{
    class calısan
    {
        public int sskno { get; set; }
        public static double maas { get; set; }
        public string elementürü { get; set; }
        public override string ToString()
        {
            return string.Format("ssk no:{0} maas:{1} ", sskno, maas);
        }
        public virtual double zamyap(double satis)
        {
            //double ekMaas = satis * 10;
            //return maas + ekMaas;
            return Convert.ToDouble("a ");


        }
    }
}
