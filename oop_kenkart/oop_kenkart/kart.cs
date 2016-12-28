using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_kenkart
{
    enum yolcutipi
    {
        ogrenci,
        ogretme,
        tam
    }
   public class kart
    {
        public double bakiye
        {
            get
            {
                return bakiye;
            }

            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("bakiye yetersiz");

                }
                else
                {
                    bakiye = value;
                }
            }
        }
        
        public int kartıd { get; set; }
        public yolcutipi kartturu { get; set; }
        
        public virtual void okut()
        {
            MessageBox.Show("3 TL alındı.Kalan bakiyeniz:" + (bakiye - 3));
            bakiye = bakiye - 3;

        }

       

    }
}
