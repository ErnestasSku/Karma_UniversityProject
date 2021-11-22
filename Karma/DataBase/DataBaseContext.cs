﻿using System;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DataBase.Services
{
    public class DataBaseContext : DbContext, IDataBaseContext
    {
        public DbSet<Models.Item> Items { get; set; }
        public DbSet<Models.User> Users { get; set; }


        public DataBaseContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=KarmaDb")
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

    }
}
