using ASP_Project.Data.Interfaces;
using ASP_Project.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Data.Controllers
{
    public class CreatingOrderController : Controller
    {
        private readonly IShoppingCart shoppingCart;
        public CreatingOrderController(IShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            return View();
        }
       public IActionResult Create(CreatingOrder model)
        {
            if (ModelState.IsValid)
            {
                shoppingCart.ClearShoppingCart();
                return View("End");
            }
            else
            {
                return View("Index", model);
            }
        }
    }
}
