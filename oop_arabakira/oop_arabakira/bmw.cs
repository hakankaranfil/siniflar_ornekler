using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_arabakira
{
    class bmw:arabakira
    {
       public bmw()
        {
            marka = "bmw";
            model = "m5";
            yakıttüketim = "55kurus";
            gunluk= 400;
        }
        public override int hesapla(int gunsayısı)
        {
            ucret = 400 * gunsayısı;
            return ucret;
        }
    }
}
