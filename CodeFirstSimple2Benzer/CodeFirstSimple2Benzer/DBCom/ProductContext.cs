namespace CodeFirstSimple2Benzer.DBCom
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ProductContext : DbContext
    {
  
        public ProductContext()
            : base("name=ProductContext")
        {
        }



        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Product> Product { get; set; }


    }


}