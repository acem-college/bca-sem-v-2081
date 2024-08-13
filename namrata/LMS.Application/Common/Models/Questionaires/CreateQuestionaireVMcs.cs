using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Common.Models.Questionaires
{
    public class CreateQuestionaireVMcs
    {
        [MaxLength(1000)]

        [Required]
        public string Content { get; set; }
        public List<CreateOptonVM> Options { get; set; }

        public class CreateOptonVM
        {
            [MaxLength(255)]
            public string Content { get; set; }

            public bool IsCorrect { get; set; }
        }

    }
}
