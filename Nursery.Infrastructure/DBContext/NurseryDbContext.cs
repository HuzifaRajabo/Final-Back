using Microsoft.EntityFrameworkCore;
using Nursery_Domin.Models;
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
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Kind> Kinds { get; set; }
        public virtual DbSet<Plant> Plants { get; set; }
        public virtual DbSet<Sector> Sectors { get; set; }
        public NurseryDbContext()
        {
        }

        public NurseryDbContext(DbContextOptions<NurseryDbContext> options) : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NurseryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        //}
    }
}
