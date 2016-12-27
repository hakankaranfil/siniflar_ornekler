using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_hesap
{
    class porshe:otomobil
    {
        public porshe()
        {
            seri = "GT";
            model = "911";
            motorgücü = 400;
            motorhacmi = 3000;
        }
        public override string calistir()
        {
            return "var var";
        }
       
    }
}
