namespace KodeFirstSporSalonu.DBContext
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SporContext : DbContext
    {
     
        public SporContext()
            : base("name=SporContext")
        {
        }

   

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

  
}