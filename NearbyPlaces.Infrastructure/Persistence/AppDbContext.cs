using Microsoft.EntityFrameworkCore;
using NearbyPlaces.Domain.Entities;
using System;

namespace NearbyPlaces.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Kullanıcı ve Roller
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        // Mekan ve ilişkili tablolar
        public DbSet<Place> Places { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FavoritePlace> FavoritePlaces { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ReviewReply> ReviewReplies { get; set; }
        public DbSet<Photo> Photos { get; set; }

        // Diğer tablolar
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User & UserRole ilişkisi (Many-to-Many)
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId);

            // Place & Category ilişkisi
            modelBuilder.Entity<Place>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Places)
                .HasForeignKey(p => p.CategoryId);

            // Place & Review ilişkisi
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Place)
                .WithMany(p => p.Reviews)
                .HasForeignKey(r => r.PlaceId);

            // FavoritePlace ilişkileri
            modelBuilder.Entity<FavoritePlace>()
                .HasOne(fp => fp.User)
                .WithMany()
                .HasForeignKey(fp => fp.UserId);

            modelBuilder.Entity<FavoritePlace>()
                .HasOne(fp => fp.Place)
                .WithMany()
                .HasForeignKey(fp => fp.PlaceId);

            // Place & Photo ilişkisi
            modelBuilder.Entity<Photo>()
                .HasOne(p => p.Place)
                .WithMany(pl => pl.Photos)
                .HasForeignKey(p => p.PlaceId);

            // ReviewReply & Review ilişkisi
            modelBuilder.Entity<ReviewReply>()
                .HasOne(rr => rr.Review)
                .WithMany(r => r.ReviewReplies)
                .HasForeignKey(rr => rr.ReviewId);
        }
    }
}
