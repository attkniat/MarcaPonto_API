﻿// <auto-generated />
using MarcaPonto.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MarcaPonto.DataBase.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("MarcaPonto.Model.Usuários.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = "1844ffd1-e384-4622-8213-95eae3b152f9",
                            CPF = "1234567890",
                            Email = "Customer1@email.com",
                            Name = "Customer 01",
                            Password = "customer01",
                            Role = "Customer"
                        },
                        new
                        {
                            Id = "7b9d4c8b-8a18-4116-a7f5-b6a451d7a07e",
                            CPF = "2234567890",
                            Email = "Customer2@email.com",
                            Name = "Customer 02",
                            Password = "customer02",
                            Role = "Customer"
                        },
                        new
                        {
                            Id = "bc50b967-8d2d-4d32-a8a3-dc2507aef3ea",
                            CPF = "3234567890",
                            Email = "Customer3@email.com",
                            Name = "Customer 03",
                            Password = "customer03",
                            Role = "Customer"
                        },
                        new
                        {
                            Id = "44e50611-e715-4770-83bc-314ec5527716",
                            CPF = "4234567890",
                            Email = "Customer4@email.com",
                            Name = "Customer 04",
                            Password = "customer04",
                            Role = "Customer"
                        },
                        new
                        {
                            Id = "7e48a3e6-27be-4f53-a92d-e3170a716541",
                            CPF = "5234567890",
                            Email = "Customer5@email.com",
                            Name = "Customer 05",
                            Password = "customer05",
                            Role = "Customer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
