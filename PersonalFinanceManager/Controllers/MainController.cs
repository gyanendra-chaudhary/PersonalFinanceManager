using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PersonalFinanceManager.Models.Entity;

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
                Id =0,
                UserName = "",
                FullName = "",
                Email = "",
                ProfilePicture = ""
            };
        }
        public class AppUser
        {
            public int Id { get; set; }
            public string UserName { get; set; }
            public string Email { get; set; }
            public string FullName { get; set; }
            public string ProfilePicture { get; set; }
        }
    }

}
