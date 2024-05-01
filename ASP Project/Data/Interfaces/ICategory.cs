using ASP_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Data.Interfaces
{
    public interface ICategory
    {
        public List<Category> GetCategorys();
        public void AddCategorys(Category category);
        public void DellCategorys(int id);

    }
}
