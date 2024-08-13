using LMS.Application.Interfaces;
using LMS.Application.Services;
using LMS.Ui.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LMS.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection Services) 
        {

         Services.AddScoped<IQuestionnaireService, QuestionnaireService>();
         Services.AddScoped<IUserServices, UserService>();

        }

    }
}
