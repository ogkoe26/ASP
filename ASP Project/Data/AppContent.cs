using ASP_Project.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Data
{
    public class AppContent : DbContext
    {
        public AppContent(DbContextOptions<AppContent> options)
        : base(options)
        { }

        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Рози", minPrice = 400, maxPrice = 5000, img = "/icon/mainroze.jpg" },
                new Category { Id = 2, Name = "Тюльпани", minPrice = 250, maxPrice = 6000, img = "/icon/maintulpan.jpg" },
                new Category { Id = 3, Name = "Лилии", minPrice = 300, maxPrice = 8500, img = "/icon/mainlilii.jpg" },
                new Category { Id = 4, Name = "Гвоздики", minPrice = 550, maxPrice = 7000, img = "/icon/maingvozdiki.jpg" },
                new Category { Id = 5, Name = "Півонії", minPrice = 385, maxPrice = 7500, img = "/icon/mainpioni.jpg" }
            );
            model.Entity<Flower>().HasData(
                new Flower { Id = 1, Price = 50, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Червоний", IdCategory = 1, img = "/icon/roze/Червоний.jpg" },
                new Flower { Id = 2, Price = 25, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Жовтий", IdCategory = 1, img = "/icon/roze/Жовтий.jpg" },
                new Flower { Id = 3, Price = 300, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Зелений", IdCategory = 1, img = "/icon/roze/Зелений.jpg" },
                new Flower { Id = 4, Price = 80, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Рожевий", IdCategory = 1, img = "/icon/roze/Рожевий.jpg" },
                new Flower { Id = 5, Price = 80, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Червоний", IdCategory = 2, img = "/icon/tulpan/Червоний.jpg" },
                new Flower { Id = 6, Price = 80, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Жовтий", IdCategory = 2, img = "/icon/tulpan/Жовтий.jpg" },
                new Flower { Id = 7, Price = 75, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Рожевий", IdCategory = 2, img = "/icon/tulpan/Рожевий.jpg" },
                new Flower { Id = 8, Price = 123, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Фіолетовий", IdCategory = 2, img = "/icon/tulpan/Фіолетовий.jpg" },
                new Flower { Id = 9, Price = 46, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Білий", IdCategory = 3, img = "/icon/lilii/Білий.jpg" },
                new Flower { Id = 10, Price = 34, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Синій", IdCategory = 3, img = "/icon/lilii/Синій.jpg" },
                new Flower { Id = 11, Price = 235, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Червоний", IdCategory = 3, img = "/icon/lilii/Червоний.jpg" },
                new Flower { Id = 12, Price = 78, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Рожевий", IdCategory = 3, img = "/icon/lilii/Рожевий.jpg" },
                new Flower { Id = 13, Price = 68, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Синій", IdCategory = 4, img = "/icon/gvozdiki/Синій.jpg" },
                new Flower { Id = 14, Price = 56, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Фіолетовий", IdCategory = 4, img = "/icon/gvozdiki/Фіолетовий.jpg" },
                new Flower { Id = 15, Price = 56, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Червоний", IdCategory = 4, img = "/icon/gvozdiki/Червоний.jpg" },
                new Flower { Id = 16, Price = 97, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Рожевий", IdCategory = 4, img = "/icon/gvozdiki/Рожевий.jpg" },
                new Flower { Id = 17, Price = 56, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Фіолетовий", IdCategory = 5, img = "/icon/pioni/Фіолетовий.jpg" },
                new Flower { Id = 18, Price = 45, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Білий", IdCategory = 5, img = "/icon/pioni/Білий.jpg" },
                new Flower { Id = 19, Price = 68, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Синій", IdCategory = 5, img = "/icon/pioni/Синій.jpg" },
                new Flower { Id = 20, Price = 46, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Червоний", IdCategory = 5, img = "/icon/pioni/Червоний.jpg" }
            );
        }
    }

}
