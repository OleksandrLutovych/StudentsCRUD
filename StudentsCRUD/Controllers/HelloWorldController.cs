using Microsoft.AspNetCore.Mvc;

namespace StudentsCRUD.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
