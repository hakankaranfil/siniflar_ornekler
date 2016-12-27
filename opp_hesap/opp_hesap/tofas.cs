using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_hesap
{
    class tofas:otomobil
    {
        public tofas()
        {
            seri = "serce";
            model = "murat";
            motorgücü = 65;
            motorhacmi = 1400;

        }
        public override string calistir()
        {
            return "vın vın";
        }
    }
}
