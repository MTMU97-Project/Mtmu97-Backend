using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mtmu97.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtmu97.Infrastructure.Persistence.EntityConfigurations
{
    public class TeacherConfigurations : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teachers");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(s => s.Speciality).IsRequired().HasMaxLength(100);

            builder.Property(s => s.Description).HasMaxLength(1024);

            builder.Property(s => s.Experience).IsRequired();

            builder.Property(s => s.BirthDate).IsRequired();

            builder.HasIndex(s => s.FullName);

            builder.HasIndex(s => s.Speciality);
        }
    }
}
