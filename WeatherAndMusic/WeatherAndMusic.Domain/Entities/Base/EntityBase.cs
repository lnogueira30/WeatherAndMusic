using prmToolkit.NotificationPattern;

namespace WeatherAndMusic.Domain.Entities.Base
{
    public abstract class EntityBase : Notifiable
    {
        public int Id { get; private set; }
    }
}
