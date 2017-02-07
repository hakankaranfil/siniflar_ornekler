using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU.DataLayer.Model
{
 public   class Fatura
    {
        public int FaturaID { get; set; }
        public int AboneID { get; set; }
        public decimal OncekiSayac { get; set; }
        public decimal GuncelSayac { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public bool Tahsilat { get; set; }
    }
}
