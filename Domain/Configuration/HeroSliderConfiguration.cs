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
    public class HeroSliderConfiguration :IEntityTypeConfiguration<HeroSliders>
    {
        public void Configure(EntityTypeBuilder<HeroSliders> builder)
        {
            builder.Property(x => x.Student).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(100);
            builder.Property(x => x.StudentStatus).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Image).IsRequired();
            builder.Property(m => m.SoftDeleted).IsRequired().HasDefaultValue(false);
            builder.Property(m => m.Date).IsRequired().HasDefaultValue(DateTime.UtcNow);

            builder.HasQueryFilter(m => !m.SoftDeleted);
        }
    }
}
