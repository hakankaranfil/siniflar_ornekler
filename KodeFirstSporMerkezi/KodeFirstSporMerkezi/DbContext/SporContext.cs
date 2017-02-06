namespace KodeFirstSporMerkezi.DbContext
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



        public virtual DbSet<MusBilgi> MusBilgi { get; set; }
    }


}