using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_arabakira
{
 public   class mercedes:arabakira
    {
        public mercedes()
        {
            marka = "mercedes";
            model = "cl180";
            yakıttüketim = "50 kuruş";
            gunluk = 300;

            



        }
        public override int hesapla(int gunsayısı)
        {
            ucret = 300 * gunsayısı;
            return ucret;
        }
    }
}
