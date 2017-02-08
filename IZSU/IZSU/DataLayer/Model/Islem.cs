using IZSU.DataLayer.DbCom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU.DataLayer.Model
{
    public class Fatura
    {
        public int FaturaID { get; set; }
        public int AboneID { get; set; }
        public double OncekiSayac { get; set; }
        public double GuncelSayac { get; set; }
        public double OdemeTutari
        {
           get
            {
                double result = 0;
                if (AboneTuruGetir()==1)
                {
                    result=(GuncelSayac-OncekiSayac)*0.3;
                }
                else
                {
                    result = (GuncelSayac - OncekiSayac) * 0.5;
                }
                return result;
            }
        
           
            
        }


        public DateTime FaturaTarihi { get; set; }
        public bool Tahsilat { get; set; }

        public int AboneTuruGetir()
        {
            int result;
            using (IzsuDBContext context = new IzsuDBContext())
            {
                result = context.Abone.FirstOrDefault(a => a.AboneTuruId == AboneID).AboneTuruId;
               

}
            return result;

        }
    }
}
