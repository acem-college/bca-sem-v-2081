using LMS.Application.Interfaces;
using LMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Infrastructure.Persistence
{
    public class LmsContext : DbContext, ILmscontext
    {
        public LmsContext(DbContextOptions<LmsContext> options) : base(options)
        {

        }
        public DbSet<Questionnaire> Questionnaires { get; set; }
        

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
                //define primary key using fluent API
                o.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(1, 1);
                o.HasKey(h => h.Id);

                //define foreign key using fluent API
                o.HasOne(n=>n.QuestionnaireRef)
                .WithMany(w=>w.Options)
                .HasForeignKey(n=>n.QuestionnaireId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            });
        }


    }
}
