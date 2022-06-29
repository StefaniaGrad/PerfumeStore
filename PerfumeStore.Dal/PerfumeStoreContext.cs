using Microsoft.EntityFrameworkCore;
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
        public DbSet<Address> Adresses { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<OptionType> OptionTypes { get; set; }
        public DbSet<OptionValue> OptionValues { get; set; }

        public PerfumeStoreContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=ROMOB41211\SQLEXPRESS01;Database=PerfumeDb;Trusted_Connection=True;", b => b.MigrationsAssembly("CryptoAvenue.Dal"))
                .EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            throw new NotImplementedException();
        }
    }
}
