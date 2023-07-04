using Domain.Common;
using Domain.Configuration;
using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Repository.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) :base(options)
        {
            
        }

        public DbSet<Basket>? Basket { get; set; }
        public DbSet<BasketCart>? BasketCart { get; set; }
        public DbSet<AppUser>? User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AboutConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new CartAuthorConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new EventConfiguration());
            modelBuilder.ApplyConfiguration(new ServicesConfiguration());
            modelBuilder.ApplyConfiguration(new SettingConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new SliderBoxConfiguration());
            modelBuilder.ApplyConfiguration(new SliderConfiguration());
            modelBuilder.ApplyConfiguration(new SubscribeConfiguration());
            modelBuilder.ApplyConfiguration(new TellUsConfiguration());

            modelBuilder.Entity<Basket>(a =>
            {
                a.Property<int>("Id");
                a.HasKey("Id");
            });
            modelBuilder.Entity<BasketCart>(a =>
            {
                a.Property<int>("Id");
                a.HasKey("Id");
            }); //ownsOne and many

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entity in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.Date = DateTime.UtcNow.AddHours(4);
                        break;
                    case EntityState.Modified:
                        entity.Entity.UpdateDate = DateTime.UtcNow.AddHours(4);
                        break;
                    case EntityState.Deleted:
                        entity.Entity.SoftDeleted = true;
                        break;
                    default:
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
