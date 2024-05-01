using ASP_Project.Data.Interfaces;
using ASP_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Data.Repository
{
    public class FlowerRepository : IFlower
    {
        private readonly AppContent appContent;

        public FlowerRepository(AppContent appContent)
        {
            this.appContent = appContent;
        }
        public void AddFlower(Flower flower)
        {
            flower.Id = appContent.Flowers.ToList().Count;
            appContent.Flowers.Add(flower);
        }

        public void DellFlower(int id)
        {
            var findInd = appContent.Flowers.ToList().FindIndex(i => i.Id == id);
            if (findInd >= 0) { appContent.Flowers.ToList().RemoveAt(findInd); };
        }

        public List<Flower> GetFlowers()
        {
            return appContent.Flowers.ToList();
        }
    }
}
