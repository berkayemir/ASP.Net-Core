using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using Sales.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models.Concrete
{
    public class SalesDbContext :DbContext
    {
        public SalesDbContext()
        {

        }

        public SalesDbContext(DbContextOptions<SalesDbContext> options) :base (options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["BloggingDatabase"].ConnectionString);

            }

        }

       


    }
}
