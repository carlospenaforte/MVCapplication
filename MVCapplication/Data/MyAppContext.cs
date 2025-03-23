﻿using Microsoft.EntityFrameworkCore;
using MVCapplication.Models;

namespace MVCapplication.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item { Id=4, Name="microphone", Price=40, SerialNumberId=10 }
                );
            modelBuilder.Entity<SerialNumber>().HasData(
                new SerialNumber { Id = 10, Name = "MIC150", ItemId=4 }
                );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<SerialNumber> SerialNumbers { get; set; }
    }
}
