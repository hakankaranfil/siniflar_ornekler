namespace IZSU.DataLayer.DbCom
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class IzsuDBContext : DbContext
    {
      
        public IzsuDBContext()
            : base("name=IzsuDBContext")
        {
           
         
                
        }



        public virtual DbSet<Abone>Abone { get; set; }
        public virtual DbSet<AboneTuru> AboneTuru { get; set; }

        public virtual DbSet<Fatura> Fatura { get; set; }

        //public class Configarition : CreateDatabaseIfNotExists<IzsuDBContext>
        //{
        //    protected override void Seed(IzsuDBContext context)
        //    {
        //        context.AboneTuru.Add(new AboneTuru { AboneTuruAdi = "Hususi" });
        //        context.AboneTuru.Add(new AboneTuru { AboneTuruAdi = "Þirket/Kurum" });
        //        context.Abone.Add(new Abone { AboneNo=1 ,AboneTuruId=1,AboneAdSoyad="Yavuz Gedik"});

        //    }
        }
    }

   
