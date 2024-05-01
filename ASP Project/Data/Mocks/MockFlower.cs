using ASP_Project.Data.Interfaces;
using ASP_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Data.Mocks
{
    public class MockFlower : IFlower 
    {
        private List<Flower> flowers;
        public MockFlower()
        {
            flowers = new List<Flower>()
            {
                new Flower { Id = 1, Price = 500, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Червоний", IdCategory = 1, img = "/icon/roze/Червоний.jpg"},
                new Flower { Id = 2, Price = 250, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Жовтий", IdCategory = 1, img = "/icon/roze/Жовтий.jpg"},
                new Flower { Id = 3, Price = 300, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Зелений", IdCategory = 1, img = "/icon/roze/Зелений.jpg"},
                new Flower { Id = 4, Price = 800, Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.", Color = "Рожевий", IdCategory = 1, img = "/icon/roze/Рожевий.jpg"},
                new Flower { Id = 5, Price = 80, Description = "Genus of perennial herbaceous bulbous plants of the Liliaceae family", Color = "Yellow", IdCategory = 2},
                new Flower { Id = 6, Price = 75, Description = "A plant with a diverse structure of flowers, inflorescences, fruits, leaves", Color = "Green", IdCategory = 3},
            };
        }

        public void AddFlower(Flower flower)
        {
            flower.Id = flowers.Count;
            flowers.Add(flower);
        }

        public void DellFlower(int id)
        {
            var findInd = flowers.FindIndex(i => i.Id == id);
            if(findInd >= 0) { flowers.RemoveAt(findInd); };
        }

        public List<Flower> GetFlowers()
        {
            return flowers;
        }
    }
}
