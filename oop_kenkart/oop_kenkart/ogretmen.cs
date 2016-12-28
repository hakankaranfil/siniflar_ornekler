using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_kenkart
{
    class ogretmen:kart
    {
        public override void okut()
        {
            MessageBox.Show("2 TL alındı.Kalan bakiyeniz:" + (bakiye - 2));
            bakiye = bakiye - 2;
        }
        public override string ToString()
        {
            return this.kartıd + "\n" + this.bakiye;
        }
    }
}
