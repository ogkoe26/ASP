using ASP_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Data.Interfaces
{
    public interface IFlower
    {
        public List<Flower> GetFlowers();
        public void AddFlower(Flower flower);
        public void DellFlower(int id);
    }
}
