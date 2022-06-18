using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webShop.Data.interfaces;
using webShop.Data.Models;

namespace webShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {

            shopCart.listShopItems = shopCart.GetShopItems();

            if(shopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("","У вас повинні бути товари");
            }

            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }


        public IActionResult Complete()
        {
            ViewBag.Message = "Замовлення успішно оброблено";
            return View(); 
        }
    }
}
