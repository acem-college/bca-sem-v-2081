using LMS.Application.Interfaces;
using LMS.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LMS.Infrastructure
{
    public static class DependecyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ILmscontext, LmsContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("LmsContext"));

            });
        }
    }
}
