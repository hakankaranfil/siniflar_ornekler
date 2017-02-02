using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSimple2.DBCom.Model
{
  public  class Category
    {
        public int CategoryID { get; set; }
        public string Categoryname { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return this.Categoryname;
        }


    }
}
