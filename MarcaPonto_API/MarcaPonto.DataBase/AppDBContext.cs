using MarcaPonto.Model.Usuários;
using Microsoft.EntityFrameworkCore;
using System;
using MarcaPonto.Enum;
using System.Reflection;
using System.IO;

namespace MarcaPonto.DataBase
{
    public class AppDBContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            var dirPath = Assembly.GetExecutingAssembly().Location;
            dirPath = Path.GetDirectoryName(dirPath);
            var fullPath = Path.GetFullPath(Path.Combine(dirPath, "Db/AppDB.db"));

            dbContextOptionsBuilder.UseSqlite($"Data Source={fullPath}");
            //dbContextOptionsBuilder.UseSqlite("Data Source=./Db/AppDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var customers = new Customer[3];

            for (int i = 1; i <= 3; i++)
            {
                customers[i - 1] = new Customer
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = $"Customer 0{i}",
                    CPF = $"{i}234567890",
                    Email = $"Customer{i}@email.com",
                    Password = $"customer0{i}",
                    Role = nameof(UsersEnum.Customer).ToString()
                };
            }
            modelBuilder.Entity<Customer>().HasData(customers);
        }
    }
}
