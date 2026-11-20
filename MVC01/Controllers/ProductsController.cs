using Microsoft.AspNetCore.Mvc;
using MVC01.Models;

namespace MVC01.Controllers
{
    public class ProductsController : Controller
    {

        [HttpGet]
        public JsonResult GetProducts()
        {
            return new JsonResult(new List<Product>()
            {
                new Product(){Id = 1, Name = "P1", Price = 100},
                new Product(){Id = 2, Name = "P2", Price = 130},
                new Product(){Id = 3, Name = "P3", Price = 110},
            });
        }


        [HttpGet]
        public ViewResult Index()
        {
            return new ViewResult();
        }


        [HttpGet]
        public FileContentResult DownloadFile()
        {
            var bytes = System.IO.File.ReadAllBytes("wwwroot/files/notes.txt");
            return new FileContentResult(bytes, "application/txt");
        }


        [HttpGet]
        public RedirectResult RedirectToUrl()
        {
            return Redirect("https://www.google.com");
        }


        [HttpGet]
        public IActionResult Test(int id)
        {
            if (id == 1)
                return View();
            else if (id == 2)
                return Json(new Product() { Id = 1, Name = "Iphone 13 Pro Max", Price = 20 });
            else if (id == 3)
                return Redirect("https://www.facebook.com");
            else
                return View();

        }
    }
}
