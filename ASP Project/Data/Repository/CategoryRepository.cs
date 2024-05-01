using ASP_Project.Data.Interfaces;
using ASP_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Data.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly AppContent appContent;

        public CategoryRepository(AppContent appContent)
        {
            this.appContent = appContent;
        }
        public void AddCategorys(Category category)
        {
            category.Id = appContent.Categories.ToList().Count;
            appContent.Categories.Add(category);
        }

        public void DellCategorys(int id)
        {
            var findInd = appContent.Categories.ToList().FindIndex(i => i.Id == id);
            if (findInd >= 0) { appContent.Categories.ToList().RemoveAt(findInd); };
        }

        public List<Category> GetCategorys()
        {
            return appContent.Categories.ToList();
        }
    }
}
