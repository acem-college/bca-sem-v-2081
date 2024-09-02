using LMS.Application.Common.Models;
using LMS.Application.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Ui.Controllers
{

    public class AccountsController : Controller
    {
        private readonly ISecurityService _securityService;
        public AccountsController(ISecurityService securityService)
        {
            _securityService = securityService;
        }

        public IActionResult login()
        {
            var authenticateVM = new AuthenticateVM();
            return View(authenticateVM);
        }

        [HttpPost]
        public async Task<IActionResult> Login(AuthenticateVM authenticateVM)
        {
            try
            {
                var principal = _securityService.Authenticate(authenticateVM);
                var authProps = new AuthenticationProperties { IsPersistent = false };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return Redirect("/");
            }

            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            return View();
        }
    }
}
