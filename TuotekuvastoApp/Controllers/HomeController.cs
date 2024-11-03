using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using TuotekuvastoApp.Models;

namespace TuotekuvastoApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Product()
        {
            var products = GetProducts();
            return View(products);
        }

        private List<Product> GetProducts()
        {
            var json = System.IO.File.ReadAllText("wwwroot/products.json");
            return JsonConvert.DeserializeObject<List<Product>>(json);
        }
    }
}
