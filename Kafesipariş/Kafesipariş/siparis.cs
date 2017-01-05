using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafesipariş
{
    public class siparis : masa
    {
        public List<siparis> yemekList = new List<siparis>();
        public List<siparis> icecekList = new List<siparis>();
        public int ucret { get; set; }

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
                    ucret = 5;

                }
                else if (value == "Tavuklu Pilav")
                {
                    ucret = 6;



                }
                else if (value == "simit+tost")
                {
                    ucret = 4;



                }
                else if (value == "lazanya")
                {
                    ucret = 2;



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
                    ucret = 1;

                }
                else if (value == "Kola")
                {
                    ucret = 2;



                }
                else if (value == "limonata")
                {
                    ucret = 3;



                }
                else if (value == "çay")
                {
                    ucret = 2;



                }
            }
        }

        public override string ToString()
        {
            return this._yemekadi;
        }
       









    }




}
       
       
    
   

