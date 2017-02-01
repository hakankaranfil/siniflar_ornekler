namespace OzanSuDagıtım.DbConnection
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OzanSuModel : DbContext
    {
        // Your context has been configured to use a 'OzanSuModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'OzanSuDagıtım.DbConnection.OzanSuModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'OzanSuModel' 
        // connection string in the application configuration file.
        public OzanSuModel()
            : base("name=OzanSuModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Product> Product { get; set; }


    }

 
}