using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Common.Models.Questionnaire
{
    public class UpdateQuestionnaireVM
    {
        [MaxLength(1000)]
        [Required]
        public string Content { get; set; }
        public List<UpdateOptionVM> TotalOptions { get; set; }

        public class UpdateOptionVM
        {
            [MaxLength(255)]
            [Required]
            public string Content { get; set; }
            public bool IsCorrect { get; set; }
        }
    }
}
