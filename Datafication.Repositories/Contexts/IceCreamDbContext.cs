using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datafication.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;


//using Microsoft.EntityFrameworkCore.Sqlite;

namespace Datafication.Repositories.Contexts
{
    public class IceCreamDbContext : DbContext
    {
        public IceCreamDbContext(DbContextOptions<IceCreamDbContext> options) : base(options)
        {

        }

        public IceCreamDbContext()
        {

        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<IceCream> IceCreams { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Manufacturer>().ToTable("Manufacturer");
            modelBuilder.Entity<Image>().ToTable("Image");
            modelBuilder.Entity<IceCream>().ToTable("IceCream");

        }

 



    }

    

    

}
