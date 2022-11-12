using MarcaPonto.Model.Users;
using MarcaPonto.Model.Ponto;
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
        public DbSet<Ponto> Ponto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            var dirPath = Assembly.GetExecutingAssembly().Location;
            dirPath = Path.GetDirectoryName(dirPath);
            var fullPath = Path.GetFullPath(Path.Combine(dirPath, "Db/AppDB.db"));

            //Usar este para teste local
            dbContextOptionsBuilder.UseSqlite($"Data Source={fullPath}");

            //Usar este para rodar Migrations
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

            var ponto = new Ponto()
            {
                Id = Guid.NewGuid().ToString(),
                UserId = customers[0].Id,
                DataCadastro = Utils.Utils.DateTimeBr().ToString(),
                UserName = customers[0].Name,
                Active = true
            };

            modelBuilder.Entity<Customer>().HasData(customers);
            modelBuilder.Entity<Ponto>().HasData(ponto);
        }
    }
}