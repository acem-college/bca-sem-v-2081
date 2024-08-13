using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Entities
{
    public abstract class BaseEntity <T>
    {
        [Key]
        public T Id { get; set; }
        public bool IsActive  { get; set; }
    
        public DateTimeOffset LastUpdatedAt { get; set; }
        public String LastUpdatedBy { get; set; }

    }
}
