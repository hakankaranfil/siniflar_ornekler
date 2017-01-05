using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafesipariş
{
    public class siparis : masa
    {
        //public List<siparis> yemekList = new List<siparis>();
        //public List<siparis> icecekList = new List<siparis>();
        public int yemekucret { get; set; }
        public int yemekadet { get; set; }
        public int icecekadet { get; set; }
        public int icecekücret { get; set; }

        public string _yemekadi;
        public string yemekadi
        {
            get
            {
                return _yemekadi;
            }
            set
            {
                if (value == "Kuru Fasulye")
                {
                    yemekucret = 5;

                }
                else if (value == "Tavuklu Pilav")
                {
                   yemekucret = 6;



                }
                else if (value == "simit+tost")
                {
                    yemekucret = 4;



                }
                else if (value == "lazanya")
                {
                    yemekucret = 2;



                }
            }
        }
                public string _icecekadi;
        public string icecekadi
        {
            get
            {
                return _icecekadi;
            }
            set
            {
                if (value == "su")
                {
                    icecekücret = 1;

                }
                else if (value == "Kola")
                {
                  icecekücret = 2;



                }
                else if (value == "limonata")
                {
                    icecekücret= 3;



                }
                else if (value == "çay")
                {
                   icecekücret = 2;



                }
            }
        }
                public int hesapla(int yemekadet,int icecekadet)
        {
            int sonuc =  (yemekadet*yemekucret)+(icecekadet*icecekücret);
            return sonuc;
        }
            }
        }

        //public override string ToString()
        //{
        //    return "yemek adeti:" + this.yemekadet + " " + this._yemekadi + "içeçek adeti:" + this.icecekadet + this._icecekadi;
        //}










    





       
       
    
   

