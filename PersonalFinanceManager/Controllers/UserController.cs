using Microsoft.AspNetCore.Mvc;

namespace PersonalFinanceManager.Controllers
{
    public class UserController : MainController
    {
        public UserController(IHttpContextAccessor httpContextAccessor):base(httpContextAccessor) 
        {
            
        }
        public IActionResult Index()
        {
            ViewData["AppUser"] = GetAppUser();
            return View();
        }
    }
}
