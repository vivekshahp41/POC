using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Npgsql;
using POC.Models;
using System.Configuration;

namespace POC
{
    //public class NpgSqlConfiguration : DbConfiguration
    //{
    //    public NpgSqlConfiguration()
    //    {
    //        var name = "Npgsql";

    //        SetProviderFactory(providerInvariantName: name,
    //                           providerFactory: NpgsqlFactory.Instance);

    //        SetProviderServices(providerInvariantName: name,
    //                            provider: NpgsqlServices.Instance);

    //        SetDefaultConnectionFactory(connectionFactory: new NpgsqlConnectionFactory());
    //    }
    //}

    //[DbConfigurationType(typeof(Configuration))]
    //public class PostGres_DbContext : DbContext
    //{
    //    public DbSet<Student> Students { get; set; }

    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        //modelBuilder.Entity<Department>()
    //        //    .Property(p => p.Version)
    //        //        .HasColumnName("xmin")
    //        //        .HasColumnType("text")
    //        //        .IsConcurrencyToken()
    //        //        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
    //        base.OnModelCreating(modelBuilder);
    //    }
    //}


    public class PostGres_DbContext : DbContext
    {
        public PostGres_DbContext() : base(GetConnectionString())
        {
        }
        public DbSet<Student> Students { get; set; }

        private static string GetConnectionString()
        {
            //var builder = new NpgsqlConnectionStringBuilder
            //{
            //    Host= "127.0.0.1",
            //    Username="postgres",
            //    Password="Test@1234",
            //    Database="StudentDB",
            //    Port=5432
            //    //SslMode = SslMode.Require, // Adjust this according to your PostgreSQL server setup
            //    //TrustServerCertificate = true // Change or remove in a production environment
            //};
            return "Server=localhost;Port=5432;Database=StudentDB;User Id=postgres;Password=Test@1234;";
            //return "Server=localhost;User ID=postgres;Password=Test@1234;Database=StudentDB;Port=5432";
            //builder.ToString();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public static NpgsqlConnection GetConnection(string connectionString)
        {
            //var executingPath = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath);
            //var connectionStringWithCertPath =
            //    connectionString.Replace("Root Certificate=", "Root Certificate=" + executingPath + "\\");

            //return new NpgsqlConnection(string.Format(connectionStringWithCertPath, "repspark_read_write"))
            //{
            //    ProvidePasswordCallback = (host, port, database, username) =>
            //        RDSAuthTokenGenerator.GenerateAuthToken(RegionEndpoint.USWest2, host, port, username)
            //};

            return new NpgsqlConnection("Server=localhost;Port=5432;Database=StudentDB;User Id=postgres;Password=Test@1234;");
        }
    }
}
