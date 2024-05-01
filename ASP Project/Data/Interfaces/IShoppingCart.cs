using ASP_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Data.Interfaces
{
    public interface IShoppingCart
    {
        ShoppingCart GetShoppingCart();
        public void AddFlowerToCart(Flower flower);
        public void DellFlowerFromCart(Flower flower);
        public void ClearShoppingCart();
        public bool Contains(Flower flower);
        public void ChangeCount(Flower flower, int add);
    }
}
