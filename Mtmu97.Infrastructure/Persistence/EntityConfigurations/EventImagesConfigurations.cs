using Microsoft.EntityFrameworkCore;
using Mtmu97.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtmu97.Infrastructure.Persistence.EntityConfigurations
{
    public class EventImagesConfigurations : IEntityTypeConfiguration<EventImage>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<EventImage> builder)
        {
            builder.ToTable("EventImages");

            builder.HasKey(e => e.Id);

            builder.HasOne(x => x.Event)
                .WithMany(x => x.EventImages)
                .HasForeignKey(e => e.EventId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
