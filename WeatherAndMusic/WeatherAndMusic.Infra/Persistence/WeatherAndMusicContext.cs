using Microsoft.EntityFrameworkCore;
using prmToolkit.NotificationPattern;
using WeatherAndMusic.Domain.Entities;
using WeatherAndMusic.Infra.Persistence.Configuration;

namespace WeatherAndMusic.Infra.Persistence
{
    public class WeatherAndMusicContext : DbContext
    {
        public WeatherAndMusicContext(DbContextOptions<WeatherAndMusicContext> options)
            : base(options)
        { }

        public DbSet<WMUser> WMUsers { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<WMUser>().ToTable("mwuser");
            builder.Entity<Note>().ToTable("note");
            builder.Ignore<Notifiable>();
            builder.Ignore<Notification>();
            builder.ApplyConfiguration<WMUser>(new ConfigurationWMUser());
            builder.ApplyConfiguration<Note>(new ConfigurationNote());
            builder.ApplyConfiguration<Log>(new ConfigurationLog());
        }

    }
}
