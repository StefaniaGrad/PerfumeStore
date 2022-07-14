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
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<OptionType> OptionTypes { get; set; }
        public DbSet<OptionValue> OptionValues { get; set; }

        public PerfumeStoreContext(DbContextOptions options) : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=DESKTOP-DLVFJ7V\SQLEXPRESS;Database=PerfumeDb2;Trusted_Connection=True;", b => b.MigrationsAssembly("PerfumeStore.Dal"))
                .EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OptionValueVariant>()
                .HasKey(ovv => new { ovv.OptionValueId, ovv.VariantId });

            modelBuilder.Entity<OptionValueVariant>()
                .HasOne(ovv => ovv.OptionValue)
                .WithMany(ovv => ovv.Variants)
                .HasForeignKey(ovv => ovv.VariantId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OptionValueVariant>()
                .HasOne(ovv => ovv.Variant)
                .WithMany(ovv => ovv.OptionValues)
                .HasForeignKey(ovv => ovv.OptionValueId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
