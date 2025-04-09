using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PersonalFinanceManager.Models.Entity;
using PersonalFinanceManager.Models.ViewModel;

namespace PersonalFinanceManager.Controllers
{
    public class MainController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public MainController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public  AppUser GetAppUser()
        {
            var user = _httpContextAccessor.HttpContext.User;
            return new AppUser
            {
                Id = Convert.ToInt32(user.FindFirst("Id").Value),
                UserName = user.FindFirst("UserName").Value,
                FullName = user.FindFirst("FullName").Value,
                Email = user.FindFirst("Email").Value,
                ProfilePicture = user.FindFirst("Email").Value
            };
        }
       
    }

}
