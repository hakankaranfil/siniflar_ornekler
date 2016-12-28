using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_arabakira
{
    class arabakira
    {
        public string marka { get; set; }
       public string model { get; set; }

        public string yakıttüketim { get; set; }
        public int ucret { get; set; }

        public int hesapla(int gunsayisi)
        {
            int sonuc = gunsayisi * ucret;
            return sonuc;

        }
        public override string ToString()
        {
            return string.Format("marka: {0} Model: {1} yakıt tüketimi: {2} ucret: {3}", marka, model, yakıttüketim, ucret);
        }

    }
}
