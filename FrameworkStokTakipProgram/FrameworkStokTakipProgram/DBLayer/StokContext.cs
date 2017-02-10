namespace FrameworkStokTakipProgram.DBLayer
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StokContext : DbContext
    {
      
        public StokContext()
            : base("name=StokContext")
        {
        }



        public virtual DbSet<ProductStock>ProductSock{ get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }

    }


}