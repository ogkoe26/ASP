﻿// <auto-generated />
using System;
using ASP_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP_Project.Migrations
{
    [DbContext(typeof(AppContent))]
    [Migration("20230604191931_Flowermigration")]
    partial class Flowermigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("ASP_Project.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("img")
                        .HasColumnType("longtext");

                    b.Property<int>("maxPrice")
                        .HasColumnType("int");

                    b.Property<int>("minPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Рози",
                            img = "/icon/mainroze.jpg",
                            maxPrice = 5000,
                            minPrice = 400
                        },
                        new
                        {
                            Id = 2,
                            Name = "Тюльпани",
                            img = "/icon/maintulpan.jpg",
                            maxPrice = 6000,
                            minPrice = 250
                        },
                        new
                        {
                            Id = 3,
                            Name = "Лилии",
                            img = "/icon/mainlilii.jpg",
                            maxPrice = 8500,
                            minPrice = 300
                        },
                        new
                        {
                            Id = 4,
                            Name = "Гвоздики",
                            img = "/icon/maingvozdiki.jpg",
                            maxPrice = 7000,
                            minPrice = 550
                        },
                        new
                        {
                            Id = 5,
                            Name = "Півонії",
                            img = "/icon/mainpioni.jpg",
                            maxPrice = 7500,
                            minPrice = 385
                        });
                });

            modelBuilder.Entity("ASP_Project.Data.Models.Flower", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<int>("IdCategory")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.Property<string>("img")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Flowers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Червоний",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 1,
                            Price = 50f,
                            img = "/icon/roze/Червоний.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Color = "Жовтий",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 1,
                            Price = 25f,
                            img = "/icon/roze/Жовтий.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Color = "Зелений",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 1,
                            Price = 300f,
                            img = "/icon/roze/Зелений.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Color = "Рожевий",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 1,
                            Price = 80f,
                            img = "/icon/roze/Рожевий.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Color = "Червоний",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 2,
                            Price = 80f,
                            img = "/icon/tulpan/Червоний.jpg"
                        },
                        new
                        {
                            Id = 6,
                            Color = "Жовтий",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 2,
                            Price = 80f,
                            img = "/icon/tulpan/Жовтий.jpg"
                        },
                        new
                        {
                            Id = 7,
                            Color = "Рожевий",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 2,
                            Price = 75f,
                            img = "/icon/tulpan/Рожевий.jpg"
                        },
                        new
                        {
                            Id = 8,
                            Color = "Фіолетовий",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 2,
                            Price = 123f,
                            img = "/icon/tulpan/Фіолетовий.jpg"
                        },
                        new
                        {
                            Id = 9,
                            Color = "Білий",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 3,
                            Price = 46f,
                            img = "/icon/lilii/Білий.jpg"
                        },
                        new
                        {
                            Id = 10,
                            Color = "Синій",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 3,
                            Price = 34f,
                            img = "/icon/lilii/Синій.jpg"
                        },
                        new
                        {
                            Id = 11,
                            Color = "Червоний",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 3,
                            Price = 235f,
                            img = "/icon/lilii/Червоний.jpg"
                        },
                        new
                        {
                            Id = 12,
                            Color = "Рожевий",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 3,
                            Price = 78f,
                            img = "/icon/lilii/Рожевий.jpg"
                        },
                        new
                        {
                            Id = 13,
                            Color = "Синій",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 4,
                            Price = 68f,
                            img = "/icon/gvozdiki/Синій.jpg"
                        },
                        new
                        {
                            Id = 14,
                            Color = "Фіолетовий",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 4,
                            Price = 56f,
                            img = "/icon/gvozdiki/Фіолетовий.jpg"
                        },
                        new
                        {
                            Id = 15,
                            Color = "Червоний",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 4,
                            Price = 56f,
                            img = "/icon/gvozdiki/Червоний.jpg"
                        },
                        new
                        {
                            Id = 16,
                            Color = "Рожевий",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 4,
                            Price = 97f,
                            img = "/icon/gvozdiki/Рожевий.jpg"
                        },
                        new
                        {
                            Id = 17,
                            Color = "Фіолетовий",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 5,
                            Price = 56f,
                            img = "/icon/pioni/Фіолетовий.jpg"
                        },
                        new
                        {
                            Id = 18,
                            Color = "Білий",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 5,
                            Price = 45f,
                            img = "/icon/pioni/Білий.jpg"
                        },
                        new
                        {
                            Id = 19,
                            Color = "Синій",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 5,
                            Price = 68f,
                            img = "/icon/pioni/Синій.jpg"
                        },
                        new
                        {
                            Id = 20,
                            Color = "Червоний",
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                            IdCategory = 5,
                            Price = 46f,
                            img = "/icon/pioni/Червоний.jpg"
                        });
                });

            modelBuilder.Entity("ASP_Project.Data.Models.Flower", b =>
                {
                    b.HasOne("ASP_Project.Data.Models.Category", null)
                        .WithMany("Flowers")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("ASP_Project.Data.Models.Category", b =>
                {
                    b.Navigation("Flowers");
                });
#pragma warning restore 612, 618
        }
    }
}