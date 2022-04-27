using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using Sales.Models.Entities;
using Sales.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Sales.Models.Concrete
{
    public class SalesDbContext : DbContext
    {
        //private readonly IHttpContextAccessor _httpContextAccessor;

        public SalesDbContext() : this(ServiceTool.ServiceProvider.GetService<DbContextOptions<SalesDbContext>>())
        {
            //_httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
        }

        public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options)
        {
            //_httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Name=ConnectionStrings:SalesConn");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
