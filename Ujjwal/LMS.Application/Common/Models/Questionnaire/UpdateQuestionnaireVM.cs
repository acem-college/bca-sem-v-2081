using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Common.Models.Questionnaire
{
    public class UpdateQuestionnaireVM
    {
        public int Id { get; set; }
        [MaxLength(1000)]
        [Required]
        public string Content { get; set; }
        public List<UpdateOptionVM> TotalOptions { get; set; }

        public class UpdateOptionVM
        {
            public int Id { get; set; }
            [MaxLength(255)]
            [Required]
            public string Content { get; set; }
            public bool IsCorrect { get; set; }
        }
    }
}
