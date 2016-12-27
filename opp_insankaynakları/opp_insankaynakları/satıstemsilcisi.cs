using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_insankaynakları
{
    class satıstemsilcisi:calısan
    {
        public int satismiktari { get; set; }

        public override double zamyap(double satis)
        {
            if (satis<=10)
            {
                maas = maas + satis * 10;
            }
            else if (satis<=20)
            {
                maas = maas + satis * 20;
            }
            else
            {
                maas = maas + satis * 30;
            }
            return maas;
        }

    }
    }

