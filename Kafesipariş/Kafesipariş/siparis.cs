using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafesipariş
{
  public  class siparis
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
                if (value== "Kuru Fasulye")
                {
                    ucret = 5;

                }
                else if (value== "Tavuklu Pilav")
                {
                    ucret = 7;
                }
            }
          
        }
       
       
    }
   
}
