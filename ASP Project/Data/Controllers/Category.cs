using ASP_Project.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Data.Controllers
{
    public class Category : Controller
    {
        private readonly ICategory icategory;

        public Category(ICategory icategory)
        {
            this.icategory = icategory;
        }

        public IActionResult Index()
        {
            var categorys = icategory.GetCategorys();
            return View(categorys);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Index();
        }
    }
}
