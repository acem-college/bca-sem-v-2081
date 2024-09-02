using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Common.Models.Questionnaires
{
    public class CreateQuestionnaireVM
    {
        [MaxLength(1000)]
        [Required]
        public string Content { get; set; }
        public List<CreateOptionVm> Options { get; set; }
        public class CreateOptionVm
        {
            [MaxLength(2000)]
            [Required]
            public string Content { get; set; }
            public bool IsCorrect { get; set; }

            public static implicit operator List<object>(CreateOptionVm v)
            {
                throw new NotImplementedException();
            }
        }
    }
}
