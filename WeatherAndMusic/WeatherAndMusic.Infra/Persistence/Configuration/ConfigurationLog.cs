using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeatherAndMusic.Domain.Entities;

namespace WeatherAndMusic.Infra.Persistence.Configuration
{
    public class ConfigurationLog : IEntityTypeConfiguration<Log>
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.HasKey(p => p.Id).HasName("id");

            builder.Property(p => p.Id_user)
                    .HasColumnName("id_user")
                    .IsRequired();

            builder.Property(p => p.Data)
                .HasMaxLength(500)
                .HasColumnName("data");

            builder.Property(p => p.Action)
                .HasMaxLength(500)
                .HasColumnName("action");

            builder.Property(p => p.Created_At)
                .HasColumnName("created_at");
        }
    }
}
