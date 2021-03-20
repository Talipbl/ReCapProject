using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCapContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R2TQ29K;Database=ReCapProject;Integrated Security=True");
        }

        public virtual DbSet<Rental> Rentals { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Customer> Customers{ get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<User> Users { get; set; }

    }
}
