using LayersOffice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersOffice.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Costumer> Costumers { get; set; }
        public DbSet<CourtCase> CourtCases { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=lawyerDb");
        }

    }
}
