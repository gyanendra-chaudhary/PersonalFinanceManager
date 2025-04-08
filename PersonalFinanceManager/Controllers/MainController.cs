using Microsoft.AspNetCore.Mvc;

namespace PersonalFinanceManager.Controllers
{
    public class MainController : Controller
    {
        public MainController()
        {

        }
        protected bool AppUser(HttpContext context)
        {
            return context.User.Identity.IsAuthenticated == true;
        }
    }

}
