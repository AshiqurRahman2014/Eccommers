using Eccommers.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eccommers.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Address address)
        {
            return View();
        }
    }
}
