using LMS.Application.Interfaces;
using LMS.Infrastructure.Persistance;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LMS.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ILmsContext, LmsContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("LmsContext"));
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/accounts/login";
                });
         
        }
    }
}
