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

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = "88b49a5f-048b-4af7-9ae4-578aceccc19d",
                            CPF = "1234567890",
                            Email = "Customer1@email.com",
                            Name = "Customer 01",
                            Password = "customer01",
                            Role = "Customer"
                        },
                        new
                        {
                            Id = "81821e02-f617-4bce-a8ff-5e85997c1cf1",
                            CPF = "2234567890",
                            Email = "Customer2@email.com",
                            Name = "Customer 02",
                            Password = "customer02",
                            Role = "Customer"
                        },
                        new
                        {
                            Id = "58f534bf-f7a7-431f-afea-a045a76bae75",
                            CPF = "3234567890",
                            Email = "Customer3@email.com",
                            Name = "Customer 03",
                            Password = "customer03",
                            Role = "Customer"
                        },
                        new
                        {
                            Id = "c5785ed0-cf69-4c68-a6f5-ea97e86ca6a7",
                            CPF = "4234567890",
                            Email = "Customer4@email.com",
                            Name = "Customer 04",
                            Password = "customer04",
                            Role = "Customer"
                        },
                        new
                        {
                            Id = "87c83265-4d01-43de-8d42-d536145b8dbe",
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
