using Microsoft.EntityFrameworkCore;
using PerfumeStore.Dal.EntityTypeConfigurations;
using PerfumeStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStore.Dal
{
    public class PerfumeStoreContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public PerfumeStoreContext(DbContextOptions options) : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=DESKTOP-DLVFJ7V\SQLEXPRESS;Database=PerfumeDb;Trusted_Connection=True;", b => b.MigrationsAssembly("PerfumeStore.Dal"))
                .EnableSensitiveDataLogging();
        }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }*/
    }
}
