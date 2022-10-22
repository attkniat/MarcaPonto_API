using MarcaPonto.Model.Usuários;
using Microsoft.EntityFrameworkCore;
using System;
using MarcaPonto.Enum;

namespace MarcaPonto.DataBase
{
    public class AppDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {

#if DEBUG
            dbContextOptionsBuilder.UseSqlite($"Data Source=./Db/AppDB.db");
#else
            var dirPath = Assembly.GetExecutingAssembly().Location;
            dirPath = Path.GetDirectoryName(dirPath);
            var fullPath = Path.GetFullPath(Path.Combine(dirPath, "Db/AppDB.db"));

            dbContextOptionsBuilder.UseSqlite($"Data Source={fullPath}");
#endif
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var customers = new Customer[5];

            for (int i = 1; i <= 5; i++)
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
