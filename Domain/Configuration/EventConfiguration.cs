using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configuration
{
    public class EventConfiguration: IEntityTypeConfiguration<Events>
    {
        public void Configure(EntityTypeBuilder<Events> builder)
        {
            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Location).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Image).IsRequired();
        builder.Property(m => m.SoftDeleted).IsRequired().HasDefaultValue(false);
        builder.Property(m => m.Date).IsRequired().HasDefaultValue(DateTime.UtcNow);

        builder.HasQueryFilter(m => !m.SoftDeleted);
    }
    }
}
