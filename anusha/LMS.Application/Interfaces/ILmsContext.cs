using LMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Application.Interfaces
{
    public interface ILmsContext
    {
        DbSet<Option> Options { get; set; }
        DbSet<Questionnaire> Questionnaires { get; set; }

        int SaveChanges();
    }
}
