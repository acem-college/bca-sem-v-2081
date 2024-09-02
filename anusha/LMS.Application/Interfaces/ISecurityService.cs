using LMS.Application.Common.Models;
using System.Security.Claims;

namespace LMS.Application.Interfaces
{
    public interface ISecurityService
    {
        ClaimsPrincipal Authenticate(AuthenticateVM authenticateVM);
    }
}