using System.ComponentModel.DataAnnotations;

namespace LMS.Domain.Entities
{
    public class Option : BaseEntity<int>
    {
        // defining models
        [MaxLength(3000)]
        [Required]
        public string Content { get; set; }
        public int QuestionnaireId { get; set; }
        public bool IsCorrect { get; set; }
        public virtual Questionnaire QuestionnairRef { get; set; }
    }
}
