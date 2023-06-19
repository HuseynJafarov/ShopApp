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
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Info).IsRequired().HasMaxLength(250);
            builder.Property(x => x.IsGraduated).IsRequired().HasDefaultValue(false);
            builder.Property(x => x.Image).IsRequired();
            builder.Property(x => x.CartsId).IsRequired();
        }
    }
}
