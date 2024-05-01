using ASP_Project.Data.Interfaces;
using ASP_Project.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Data.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCart shoppingCart;
        private readonly IFlower _flower;

        public ShoppingCartController(IShoppingCart shoppingCart, IFlower flower)
        {
            this.shoppingCart = shoppingCart;
            _flower = flower;
        }

        public IActionResult Index()
        {
            return View(shoppingCart.GetShoppingCart());
        }

        [HttpPost]
        public IActionResult AddToShoppingCart(int idFlower)
        {
            var flower = _flower.GetFlowers().FirstOrDefault(i => i.Id == idFlower);
            if(flower == null) return NotFound();

            if (shoppingCart.Contains(flower))
            {
                shoppingCart.ChangeCount(flower, 1);
            }
            else
            {
                shoppingCart.AddFlowerToCart(flower);
            }
            
            return Ok();
        }
    }
}
