namespace Entities
{
    using Entities.Models;
    using Microsoft.EntityFrameworkCore;

    public class RepositoryContextLocalDB : DbContext
    {
        public RepositoryContextLocalDB()
        {
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Initial Catalog=SolutionRepositoryPatternDB;Trusted_Connection=True;");
        }
    }
}
