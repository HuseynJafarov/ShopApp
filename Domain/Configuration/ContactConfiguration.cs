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
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(x => x.Title).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(250);
            builder.Property(x=> x.Phone).IsRequired().HasMaxLength(50);
            builder.Property(x=> x.Email).IsRequired().HasMaxLength(100);
            builder.Property(x=> x.Location).IsRequired().HasMaxLength(200);
        }
    }
}
