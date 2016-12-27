using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_hesap
{
    class otomobil
    {
        public string seri { get; set; }
        public string model { get; set; }
        public int motorgücü { get; set; }
        public int motorhacmi { get; set; }

        public string yazdir()
        {
            return string.Format("marka:{0} model:{1} motorgücü:{2} motorhacmi{3}", seri, model, motorgücü, motorhacmi);
        }

        public virtual string calistir()
        {
            return "otomobil çalıştı";
        }
    }
}
