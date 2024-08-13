using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Entities
{
    public class Questionnaire: BaseEntity<int>
    {
        [StringLength(3000)]
        [Required]
        public string Content { get; set; }

        public virtual ICollection<Option> Options { get; set; }
        
    }
}
