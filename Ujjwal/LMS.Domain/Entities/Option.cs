using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Entities
{
    public class Option : BaseEntity<int>
    {
        [StringLength(3000)]
        [Required]
        public string Content { get; set; }
        public int Questionnaire { get; set; }
        public bool Iscorrect { get; set; }
        
        public int QuestionnaireId {get; set; }
        public virtual Questionnaire QuestionnaireRef { get; set; }
    }
}
