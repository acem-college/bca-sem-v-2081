using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Common.Models.Users
{
    public class UserVM
    {
        //public IActionResult Index()
        //{
        //    retrn View();
        //}

        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }
    }
}

