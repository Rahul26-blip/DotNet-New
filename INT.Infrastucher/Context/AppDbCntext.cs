using INT.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace INT.Infrastucher.Context
{
    public class AppDbCntext : DbContext
    {
        public AppDbCntext(DbContextOptions<AppDbCntext> options) : base(options)

        {

        }

        public DbSet<Owner> Owner { get; set; } 

        public  void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating (modelBuilder);
            modelBuilder.Entity<Owner>().ToTable("Owner");
        }
    }
}
