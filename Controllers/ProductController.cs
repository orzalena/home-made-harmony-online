using Microsoft.AspNetCore.Mvc;

namespace home_made_harmony_online.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
