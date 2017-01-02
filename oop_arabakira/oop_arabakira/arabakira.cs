using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_arabakira
{
    public enum arabatipi
    {
        fiat,
        honda,
        mercedes,
        bmw
    };
   public class arabakira
    {
        public string adsoyad { get; set; }
        public int tckimlik { get; set; }
        public string marka { get; set; }
       public string model { get; set; }

        public string yakıttüketim { get; set; }
        public int ucret { get; set; }
        public int guncelborc { get; set; }
        public int gunluk { get; set; }

        //public int hesapla(int gunsayisi)
        //{
        //    int sonuc = gunsayisi * ucret;
        //    return sonuc;

        public virtual int hesapla(int gunsayısı)
        {
            return gunsayısı;
        }
        public arabatipi secim { get; set; }

        public override string ToString()
        {
            return this.marka + " " + this.model + " " + this.yakıttüketim;
        }
    }
       
      

    }

