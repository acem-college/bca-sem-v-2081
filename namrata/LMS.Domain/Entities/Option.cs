using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Entities
{
   public class Option: BaseEntity<int>
    {
        public string Content { get; set; }
        public int QuestionnariesId { get; set; }
        public bool IsCorrect { get; set; }
        public virtual Questionnarie QuestionnarieRef { get; set; }
    }
}
