using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LMS.Domain.Entities;
using LMS.Application.Interfaces;

namespace LMS.Infrastructure.Persistence
{
    public class LmsContext : DbContext, ILmscontext
    {
        public LmsContext(DbContextOptions<LmsContext> options) : base(options)
        {

        }

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
