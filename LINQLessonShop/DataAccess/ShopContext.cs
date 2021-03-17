using LINQLessonShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQLessonShop.DataAccess
{
    public class ShopContext : DbContext
    {
        public ShopContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Item> Item { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-S75L8G1; Database=NewDataBase; Trusted_Connection=true;");
        }
    }
}
