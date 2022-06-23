using System;
using System.Data.Entity;
using System.Linq;
using _102200288_LeDucTho.DTO;

namespace _102200084_DoNguyenQuocDat
{
    public class DALQLSV : DbContext
    {
        // Your context has been configured to use a 'DALQLSV' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // '_102200288_LeDucTho.DALQLSV' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DALQLSV' 
        // connection string in the application configuration file.
        public DALQLSV()
            : base("name=DALQLSV")
        {
            Database.SetInitializer<DALQLSV>(new CreateDB());
        }
        public virtual DbSet<SV> SVs { get; set; }
        public virtual DbSet<HP> HPs { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }




}