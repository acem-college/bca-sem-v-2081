using LMS.Application.Common.Models.Users;
using LMS.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Ui.Controllers
{
    [Route("Users")]
    public class UsersController : Controller
    {
        public readonly IUserServices _userServices;
        public UsersController(IUserServices userService)
        {
            _userServices = userService;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        public static List<UserVM> usersList = new List<UserVM>();

        [HttpGet("")]
        public async Task<IActionResult> List(CancellationToken cancellationToken)
        {
            

            usersList.Add(new UserVM { Id = 1, FirstName = "ujwal", LastName = "hgjhf", Email = "jhgf@gmail.com", PhoneNumber = "98765678876" });
            return View(usersList);
        }

        public IActionResult create() 
        {
            var model = new UserVM();
            

            return View(model);
        }


    }

}
