using System.ComponentModel.DataAnnotations;

namespace LMS.Domain.Entities
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }
        public bool IsActive { get; set; }

        public DateTimeOffset LastUpdatedAt { get; set; }

        [MaxLength(255)]
        [Required]
        public string LastUpdatedBy { get; set; }
    }
}
