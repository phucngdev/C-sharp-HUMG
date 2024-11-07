using Microsoft.EntityFrameworkCore;
using ef01.Models;
using System;

namespace ef01.Data
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        private const string connectionString = "Server=127.0.0.1;Database=newdotnet2;UserID=root;Password=;Port=3306;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 26)));
        }
    }
}
