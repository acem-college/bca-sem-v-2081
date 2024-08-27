using LMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Application.Interfaces
{
    public interface ILmscontext 
    {
        DbSet<Questionnaire> Questionnaires { get; set; }
        int SaveChanges();
    }
}
