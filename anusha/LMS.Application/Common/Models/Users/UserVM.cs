using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Common.Models.Users
{
    public class UserVM
    {

        public int Id { get; set; }

        [Display(Name = "Pahilo Name")]
        public required string FirstName { get; set; }
        [Display(Name = "Antim Name")]

        public required string LastName { get; set; } 
        [Display(Name = "Phone#")]
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
    }
}
