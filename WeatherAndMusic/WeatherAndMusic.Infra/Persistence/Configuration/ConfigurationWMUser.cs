using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeatherAndMusic.Domain.Entities;

namespace WeatherAndMusic.Infra.Persistence.Configuration
{
    public class ConfigurationWMUser : IEntityTypeConfiguration<WMUser>
    {
        public void Configure(EntityTypeBuilder<WMUser> builder)
        {
            builder.Property(p => p.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            builder.OwnsOne(m => m.Name, a =>
            {
                a.Property(p => p.name).HasMaxLength(300)
                    .HasColumnName("name")
                    .IsRequired();
            });

            builder.Ignore(x => x.Notifications);

            builder.OwnsOne(m => m.Email, a =>
            {
                a.Property(p => p.email).HasMaxLength(300)
                    .HasColumnName("email");
            });

            builder.OwnsOne(m => m.Pass, a =>
            {
                a.Property(p => p.pass).HasMaxLength(600)
                    .HasColumnName("password")
                    .IsRequired();
            });

            builder.Property(p => p.Salt)
                .HasColumnName("salt")
                .HasMaxLength(300);

            builder.Property(p => p.HomeTown)
                .HasColumnName("hometown")
                .HasMaxLength(300);

            builder.Property(p => p.Password_Reset_Hash)
                .HasColumnName("password_reset_hash")
                .HasMaxLength(300);

            builder.Property(p => p.Password_Reset_Date)
                .HasColumnName("password_reset_date");

            builder.Property(p => p.Created_At)
                .HasColumnName("created_at");

            builder.Property(p => p.Updated_At)
                .HasColumnName("updated_at");

            builder.HasMany(p => p.Notes)
                .WithOne()
                .HasForeignKey(t => t.WMUserId);
        }
    }
}
