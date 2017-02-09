namespace IzsuFramework.DataLayer
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class IzsuContext : DbContext
    {
     
        public IzsuContext()
            : base("name=IzsuContext")
        {
        }


        public virtual DbSet<Abone> Abone { get; set; }
        public virtual DbSet<AboneTuru> AboneTuru { get; set; }
        public virtual DbSet<Fatura> Fatura { get; set; }

    }

   
}