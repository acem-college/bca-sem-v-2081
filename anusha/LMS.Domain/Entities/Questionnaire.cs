using System.ComponentModel.DataAnnotations;

namespace LMS.Domain.Entities
{
    public class Questionnaire : BaseEntity<int>
    {
        public  int QuestionnaireId {get; set;}

        [MaxLength (3000)]
        [Required]
        public string Content { get; set; }

        public virtual ICollection<Option> Options { get; set; }
    }
}
