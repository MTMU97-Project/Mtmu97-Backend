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
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.FullName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(s => s.Rank).IsRequired() .HasMaxLength(100);

            builder.Property(s => s.Description).IsRequired().HasMaxLength(100);

            builder.Property(s => s.Motto).IsRequired().HasMaxLength(100);

            builder.Property(s => s.Competition).IsRequired().HasMaxLength(100);

            builder.HasIndex(s => s.Rank);
            builder.HasIndex(s => s.Competition);
            builder.HasIndex(s => s.FullName);
            builder.HasIndex(s => s.Competition);

        }
    }
}
