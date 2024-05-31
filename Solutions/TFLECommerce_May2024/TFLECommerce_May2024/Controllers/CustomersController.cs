using Microsoft.AspNetCore.Mvc;

namespace TFLECommerce_May2024.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
