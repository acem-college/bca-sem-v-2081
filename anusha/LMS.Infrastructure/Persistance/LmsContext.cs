using LMS.Application.Interfaces;
using LMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Infrastructure.Persistance
{
    public class LmsContext : DbContext, ILmsContext
    {
        // implementation/ inheritance of base class
        public LmsContext(DbContextOptions<LmsContext> options) : base(options)
        {

        }

        public DbSet<Option> Options { get; set; }
        public DbSet<Questionnaire> Questionnaires { get; set; }
        
        //overrriding base class controller
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Questionnaire>(o =>
            {
                o.Property(p => p.Id)
                 .ValueGeneratedOnAdd()
                 .UseIdentityColumn(1, 1);
                o.HasKey(h => h.Id);
            });

            modelBuilder.Entity<Option>(o =>
            {
                // primary key define using fluent api
                o.Property(p => p.Id)
                 .ValueGeneratedOnAdd()
                 .UseIdentityColumn(1, 1);
                o.HasKey(h => h.Id);

                // foreign key define, delete behaviour and required attribute using fluent api
                o.HasOne(h => h.QuestionnairRef)
                 .WithMany(w => w.Options)
                 .HasForeignKey(h => h.QuestionnaireId)
                 .OnDelete(DeleteBehavior.Cascade)
                 .IsRequired();
            });
        }
    }
}
