using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Common.Models.Questionnaire
{
    public class QuestionnaireVM
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public List<TotalOption> TotalOptions { get; set; }
        public class TotalOption
        {
            [MaxLength(255)]
            [Required]
            public string Content { get; set; }
            public bool IsCorrect { get; set; }
        }

    }
}
