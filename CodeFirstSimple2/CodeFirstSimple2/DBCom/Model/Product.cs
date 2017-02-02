using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSimple2.DBCom.Model
{
  public  class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }
        public int CategoryID { get; set; }

        public Category Category { get; set; }

    }
}
