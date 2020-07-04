using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeatherAndMusic.Domain.Entities;

namespace WeatherAndMusic.Infra.Persistence.Configuration
{
    public class ConfigurationNote : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(p => p.Id).HasName("id");

            builder
                .Property(p => p.WMUserId)
                .HasColumnName("id_user")
                .IsRequired();

            builder.Property(p => p.Text)
                .HasMaxLength(600)
                .HasColumnName("note");

            builder.Property(p => p.Text)
                .HasColumnName("created_at");
        }
    }
}
