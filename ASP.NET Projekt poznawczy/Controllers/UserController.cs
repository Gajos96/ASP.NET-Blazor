using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Projekt_poznawczy.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Registration()
        {
            return View();
        }
    }
}
