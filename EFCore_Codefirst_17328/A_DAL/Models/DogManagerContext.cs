using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; // Thêm

namespace EFCore_Codefirst_17328.A_DAL.Models
{
    internal class DogManagerContext : DbContext
    {
        public DbSet<Human> Humans { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DogManagerContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MSI\SQLEXPRESS;Database=QuanLyCho;Trusted_Connection=True;");
        }
    }
}
            