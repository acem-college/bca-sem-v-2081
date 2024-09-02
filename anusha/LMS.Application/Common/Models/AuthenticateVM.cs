using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Common.Models
{
    public class AuthenticateVM
    {
        [Required]
        public string UserName { get; set; }

        [Required] 
        public string Password { get; set; }

    }
}
