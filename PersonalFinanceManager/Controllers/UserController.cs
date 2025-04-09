using Microsoft.AspNetCore.Mvc;

namespace PersonalFinanceManager.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
