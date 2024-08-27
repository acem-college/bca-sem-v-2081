using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Common.Models.Questionnaire
{
    public class QuestionnaireVM
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int TotalOptions { get; set; }
        public List<OptionVM> Options { get; set; }

        public class OptionVM
        {
            public int Id { get; set; }
            public string Content { get; set; }
            public bool IsCorrect { get; set; }
        }
    }
}
