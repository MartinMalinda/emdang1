using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models; // enabling using the ShopItem object

namespace WebShop.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        List<ShopItem> shopItemsList = new List<ShopItem>() {
            new ShopItem("Running shoes", "Nike running shoes for every day sport", 1000, 5),
            new ShopItem("Printer", "Some HP printer that will print pages", 3000, 2),
            new ShopItem("Coca Cola", "0.5 l standard coke", 25, 0),
            new ShopItem("Wokin", "Chicken with fried rice", 119, 100),
            new ShopItem("T-shirt", "Blue with corgi on a bike", 300, 1),
            new ShopItem("T-shirt GUCCI", "Blue with corgi on a bike", 30000, 1),
            new ShopItem("T-shirt NIKE", "Blue with corgi on a bike", 30000, 0)
        };


        [Route("")] //webshop
        public IActionResult Index()
        {
            ViewBag.Items = shopItemsList;
            return View();
        }

        [Route("onlyavailable")]
        public IActionResult OnlyAvailable()
        {
            ViewBag.Items = shopItemsList.Where(si => si.QuantityOfStock > 0);
            return View("Index");
        }

        [Route("cheapestfirst")]
        public IActionResult CheapestFirst()
        {
            ViewBag.Items = shopItemsList.OrderBy(si => si.Price);
            return View("Index");
        }

        [Route("containsnike")]
        public IActionResult ContainsNike()
        {
            ViewBag.Items = shopItemsList.Where(si => si.Name.ToLower().Contains("nike")||si.Description.ToLower().Contains("nike"));
            return View("Index");
        }

        [Route("averagestock")]
        public IActionResult AverageStock()
        {
            ViewBag.Items = shopItemsList.Select(si => si.QuantityOfStock).Average();

            return View();
        }

        [Route("mostexpensiveavailable")]
        public IActionResult MostExpensiveAvailable()
        {
            ViewBag.Items = shopItemsList.Where(si => si.QuantityOfStock > 0).OrderByDescending(si => si.Price).Take(1);

            return View("Index");
        }

        [HttpPost]
        [Route("search")]
        public IActionResult Search(string search)
        {
            //ViewData["keyword"] = search;
            ViewBag.Items = shopItemsList.Where(si => si.Name.ToLower().Contains(search) || si.Description.ToLower().Contains(search));


            return View();
        }
    }

}