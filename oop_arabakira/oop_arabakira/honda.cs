using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_arabakira
{
  public  class honda:arabakira
    {
        public honda()
        {
            marka = "honda";
            model = "civic";
            yakıttüketim = "40 kuruş";
            gunluk = 200;
        }
        public override int hesapla(int gunsayısı)
        {
            ucret = 200 * gunsayısı;
            return ucret;
        }

    }
}
