using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Areas.Manage.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
