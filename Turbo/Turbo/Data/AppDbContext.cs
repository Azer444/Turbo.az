using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turbo.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Model = Turbo.Models.Model;

namespace Turbo.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Body> Bodies { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Gear> Gears { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Year> Years { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }

}
