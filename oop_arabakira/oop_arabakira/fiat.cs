using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_arabakira
{
  public  class fiat:arabakira
    {
        public fiat()
        {
            marka = "fiat";
            model = "albea";
            yakıttüketim = "30 kuruş";
            gunluk = 100;

            

            
        }
        public override int hesapla(int gunsayısı)
        {
            ucret = 100 * gunsayısı;
            return ucret;
        }
    }
}
