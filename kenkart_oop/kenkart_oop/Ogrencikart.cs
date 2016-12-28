﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kenkart_oop
{
    class Ogrencikart:Kart
    {
        class OgrenciKart : Kart
        {
            public string okulAdi { get; set; }

            public override void Okut()
            {
                MessageBox.Show("1 ₺ alındı. Kalan Bakiye : " + (bakiye - 1));
                bakiye--;
            }

            public override string ToString()
            {
                return this.kartID + "\t" + this.bakiye + "\t" + this.okulAdi + "\t" + this.kartTuru;
            }
        }
}
