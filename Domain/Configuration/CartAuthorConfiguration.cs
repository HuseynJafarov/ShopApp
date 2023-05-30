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
    public class CartAuthorConfiguration : IEntityTypeConfiguration<CartAuthor>
    {
        public void Configure(EntityTypeBuilder<CartAuthor> builder)
        {
            builder.Property(x => x.CartsId).IsRequired();
            builder.Property(x => x.AuthorId).IsRequired();
            builder.Property(m => m.SoftDeleted).IsRequired().HasDefaultValue(false);
            builder.Property(m => m.Date).IsRequired().HasDefaultValue(DateTime.UtcNow);

            builder.HasQueryFilter(m => !m.SoftDeleted);
        }
    }
}
