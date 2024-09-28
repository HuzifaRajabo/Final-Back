using Microsoft.EntityFrameworkCore;
using Nursery.Domin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Infrastructure.DBContext
{
    public class NurseryDbContext : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
        public virtual DbSet<Kind> Kinds { get; set; }
        public virtual DbSet<Plant> Plants { get; set; }
        public virtual DbSet<Sector> Sectors { get; set; }
        public virtual DbSet<SaleInvoice> SaleInvoices { get; set; }
        public virtual DbSet<SectorPlant> SectorPlants { get; set; }
        public virtual DbSet<SaleInvoicePlant> SaleInvoicePlants { get; set; }
        public virtual DbSet<Store> Stores { get; set; }

        public NurseryDbContext()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SaleInvoicePlant>()
                .HasKey(ss => new { ss.SaleInvoiceId, ss.PlantId }); // مفتاح مركب


            modelBuilder.Entity<SectorPlant>()
                .HasKey(ss => new { ss.SectorId, ss.PlantId });


            modelBuilder.Entity<SectorPlant>()
                        .HasOne(ss => ss.Sector)
                        .WithMany(s => s.Sectorplants)
                        .HasForeignKey(ss => ss.SectorId)
                        .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<SectorPlant>()
                        .HasOne(ss => ss.Plant)
                        .WithMany(s => s.SectorPlants)
                        .HasForeignKey(ss => ss.PlantId)
                        .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<SaleInvoicePlant>()
                        .HasOne(ss => ss.SaleInvoice)
                        .WithMany(s => s.SaleInvoicePlants)
                        .HasForeignKey(ss => ss.SaleInvoiceId)
                        .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<SaleInvoicePlant>()
                        .HasOne(ss => ss.Plant)
                        .WithMany(s => s.SaleInvoicePlants)
                        .HasForeignKey(ss => ss.PlantId)
                        .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(modelBuilder);
        }

        public NurseryDbContext(DbContextOptions<NurseryDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NurseryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}