using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_kenkart
{
    class ogrenci:kart
    {
        public ogrenci()
        {

        }

        public string okuladi { get; set; }
        public override void okut()
        {
            MessageBox.Show("1 TL alındı.Kalan bakiyeniz:"+(bakiye-1));
            bakiye = bakiye - 1;

        }
        public override string ToString()
        {
            return this.kartıd + "\n" + this.bakiye + "\n" + this.okuladi;
        }


    }

}
