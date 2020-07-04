using prmToolkit.NotificationPattern;
using WeatherAndMusic.Domain.Entities;
using WeatherAndMusic.Domain.Interfaces;
using WeatherAndMusic.Domain.Interfaces.Repositories;

namespace WeatherAndMusic.Domain.Services
{
    public class ServiceLog : Notifiable, IServiceLog
    {
        private readonly IRepositoryLog _repository;

        public ServiceLog(IRepositoryLog repository)
        {
            _repository = repository;
        }

        public void Record(Log log)
        {
            if (log == null)
                throw new System.Exception("log cant be null");

            _repository.Add(log);

        }
    }
}
