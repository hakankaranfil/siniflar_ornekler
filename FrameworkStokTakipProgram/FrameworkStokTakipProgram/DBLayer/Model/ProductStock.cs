using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStokTakipProgram.DBLayer.Model
{
 public   class ProductStock
    {
        public int ProductStockID { get; set; }
        public string ProductName { get; set; }
        public int ProductNumber { get; set; }
        public string ProductSerialNumber { get; set; }
        public DateTime ProductDate { get; set; }
        public string Recorder { get; set; }
        public int ProductTypeID{ get; set; }
        public string ProductTypeName { get; set; }
        public ProductType ProductType { get; set; }



    }
}
