using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Common.Models.Questionnaire
{
    public class CreateQuestionnaireVM
    {
        [MaxLength(1000)]
        [Required]
        public string Content { get; set; }
        public List<CreateOptionVM> Options { get; set; }

        public class CreateOptionVM
        {
            [MaxLength(255)]
            [Required]
            public string Content { get; set; }
            public bool IsCorrect { get; set; }
        }
    }
}
