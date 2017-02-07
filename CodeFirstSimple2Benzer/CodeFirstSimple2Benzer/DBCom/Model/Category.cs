using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSimple2Benzer.DBCom.Model
{
   public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }


        public override string ToString()
        {
        return    this.CategoryName;
        }
    }
}
