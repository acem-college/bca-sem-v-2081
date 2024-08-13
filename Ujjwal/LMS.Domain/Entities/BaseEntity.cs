using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Entities
{
    public abstract class BaseEntity<T>
    {
       
        public T Id { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset LastUpdateAt { get; set; }
        //data annotation
        [StringLength(255)]
        [Required]
        public string LastUpdateBy { get; set; }
    }
}
