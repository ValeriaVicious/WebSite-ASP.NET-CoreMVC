using Microsoft.AspNetCore.Mvc;


namespace TheASPSiteProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
