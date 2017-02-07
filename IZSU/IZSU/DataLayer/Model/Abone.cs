using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU.DataLayer.Model
{
 public   class Abone
    {
        public int ID  { get; set; }
        public int AboneNo { get; set; }

        public string AboneAdSoyad { get; set; }

        public int AboneTuruId { get; set; }

        public AboneTuru AboneTuru { get; set; }
    }
}
