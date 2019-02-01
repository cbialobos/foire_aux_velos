using SQLite.CodeFirst;
using System.Data.Entity;

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
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<FoireAuxVeloDbContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }
    }
}
