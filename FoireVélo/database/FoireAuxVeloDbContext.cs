using SQLite.CodeFirst;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FoireVélo.database
{
    public class FoireAuxVeloDbContext : DbContext
    {
        public FoireAuxVeloDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<Article> Articles {get; set;}
        public DbSet<Deposant> Deposants {get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Database does not pluralize table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<FoireAuxVeloDbContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }
    }
}
