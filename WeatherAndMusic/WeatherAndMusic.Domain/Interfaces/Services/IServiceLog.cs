using WeatherAndMusic.Domain.Entities;

namespace WeatherAndMusic.Domain.Interfaces
{
    public interface IServiceLog
    {
        public void Record(Log log);
    }
}
