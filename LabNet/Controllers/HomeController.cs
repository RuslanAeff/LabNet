using Microsoft.AspNetCore.Mvc;

namespace LabNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
