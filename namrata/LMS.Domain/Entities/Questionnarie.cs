using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Entities
{
    public class Questionnarie : BaseEntity<int>
    {
      
        [Required]
        [MaxLength(50)]
         public required string Content{ get; set; }
        [Required]
        [MaxLength(50)]
        public string LastUpdateBy {  get; set; }

       
    }
}
