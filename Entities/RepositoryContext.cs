namespace Entities
{
    using Entities.Models;
    using Microsoft.EntityFrameworkCore;

    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Account> Accounts { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Initial Catalog=SolutionRepositoryPatternDB;Trusted_Connection=True;");
        //}

    }
}


/*
    Package Manager Console

    Drop database.

        PM> Drop-Database -Context RepositoryContext

    Create a new database.

        PM> Update-Database -Context RepositoryContext
 
 */