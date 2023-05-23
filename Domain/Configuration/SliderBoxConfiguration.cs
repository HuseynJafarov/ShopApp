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
    public class SliderBoxConfiguration : BaseEntityConfiguration, IEntityTypeConfiguration<SliderBoxs>
    {
        public void Configure(EntityTypeBuilder<SliderBoxs> builder)
        {
            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Image).IsRequired();
        }
    }
}
