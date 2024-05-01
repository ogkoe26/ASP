using ASP_Project.Data.Interfaces;
using ASP_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Data.Mocks
{
    public class MockCategory : ICategory
    {

        private List<Category> categorys;
        public MockCategory()
        {
            categorys = new List<Category>()
            {
                new Category { Id = 1, Name = "Рози", minPrice = 400, maxPrice = 5000, img = "/icon/mainroze.jpg"},
                new Category { Id = 2, Name = "Тюльпани", minPrice = 250, maxPrice = 6000, img = "/icon/maintulpan.jpg"},
                new Category { Id = 2, Name = "Лилии", minPrice = 15000, maxPrice = 5500, img = "/icon/mainlilii.jpg"},
            };
        }
        public void AddCategorys(Category category)
        {
            category.Id = categorys.Count;
            categorys.Add(category);
        }

        public void DellCategorys(int id)
        {
            var findInd = categorys.FindIndex(i => i.Id == id);
            if (findInd >= 0) { categorys.RemoveAt(findInd); };
        }

        public List<Category> GetCategorys()
        {
            return categorys;
        }
    }
}
