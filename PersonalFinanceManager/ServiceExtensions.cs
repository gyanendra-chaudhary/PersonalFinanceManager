using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PersonalFinanceManager.Configurations.Email;
using PersonalFinanceManager.Data;
using PersonalFinanceManager.Models.Entity;
using PersonalFinanceManager.Services.EmailService;

namespace PersonalFinanceManager
{
    public static class ServiceExtensions
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
            var connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'Default Connection' not found");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredUniqueChars = 1;
                options.Password.RequiredLength = 6;
                options.User.RequireUniqueEmail = true;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Signin";
                options.AccessDeniedPath = "/Account/AccessDenied";
            });

            var smtpSettings = configuration.GetSection("SmtpSettings").Get<SmtpSettings>();
            services.AddSingleton(smtpSettings);
            services.AddTransient<IEmailService, EmailService>();
            services.AddHttpContextAccessor();
        }
    }
}
