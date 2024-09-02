using LMS.Application.Common.Models;
using LMS.Application.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace LMS.Application.Services
{
    public class SecurityService : ISecurityService
    {
        public ClaimsPrincipal Authenticate(AuthenticateVM authenticateVM)
        {
            if (authenticateVM.UserName == "admin" &&
                authenticateVM.Password == "admin123")
            {
                var principal = new ClaimsPrincipal();
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString()),
                    new Claim(ClaimTypes.Name, "admin"),
                    new Claim(ClaimTypes.Role, "Admin")
                };
                principal.AddIdentity(new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme));
                return principal;
            }
            return null;
        }

    }
}
