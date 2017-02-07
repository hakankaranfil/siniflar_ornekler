using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU.DataLayer.Model
{
 public   class AboneTuru
    {
        public int AboneTuruID { get; set; }

        public string AboneTuruAdi { get; set; }

        public override string ToString()
        {
            return AboneTuruAdi;

        }
    }
}
