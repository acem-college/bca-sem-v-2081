using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
