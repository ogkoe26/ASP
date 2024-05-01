using ASP_Project.Data.Interfaces;
using ASP_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Data.Repository
{
    public class ShoppingCartRepository : IShoppingCart
    {
        private readonly ShoppingCart shoppingcart;
        public ShoppingCartRepository()
        {
            shoppingcart = new ShoppingCart();
        }

        public void AddFlowerToCart(Flower flower)
        {
            var cartItem = shoppingcart.Items.FirstOrDefault(i => i.Flower.Id == flower.Id);
            if (cartItem == null)
            {
                shoppingcart.Items.Add(new ShoppingCartItem { Flower = flower, Count = 1 });
                shoppingcart.TotalPrice += flower.Price;
            }
        }
        public bool Contains(Flower flower)
        {
            return shoppingcart.Items.Any(i => i.Flower.Id == flower.Id);
        }
        public void ChangeCount(Flower flower, int add)
        {
            var cartItem = shoppingcart.Items.FirstOrDefault(i => i.Flower.Id == flower.Id);
            if(cartItem != null)
            {
                cartItem.Count += add;
                shoppingcart.TotalPrice += add;
            }
        }

        public void ClearShoppingCart()
        {
            shoppingcart.Items = new List<ShoppingCartItem>();
            shoppingcart.TotalPrice = 0;
        }

        public void DellFlowerFromCart(Flower flower)
        {
            var findInd = shoppingcart.Items.FindIndex(i => i.Flower.Id == flower.Id);
            if (findInd >= 0) { shoppingcart.Items.RemoveAt(findInd); };
        }

        public ShoppingCart GetShoppingCart()
        {
            return shoppingcart;
        }
    }
}
