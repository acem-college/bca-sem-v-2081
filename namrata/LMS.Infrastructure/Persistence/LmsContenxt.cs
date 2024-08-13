using LMS.Application.Interfaces;
using LMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructure.Persistence
{
    public class LmsContenxt : DbContext, ILmsContext
    {
        public LmsContenxt(DbContextOptions<LmsContenxt> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Questionnarie>()
            //    .HasKey(x => x.Id);
            modelBuilder.Entity<Questionnarie>(o =>
            {
                o.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(1, 1);
                o.HasKey(h => h.Id);
            });


            modelBuilder.Entity<Option>(o =>
            {
                o.Property(p => p.Id)
              .ValueGeneratedOnAdd()
              .UseIdentityColumn(1, 1);
                o.HasKey(h => h.Id);


                o.HasOne(h => h.QuestionnarieRef)
                .WithMany()
                .HasForeignKey(h => h.QuestionnariesId)
                .OnDelete(DeleteBehavior.Cascade);
            });

        }
    }
}
