using WeatherAndMusic.Domain.Entities;
using WeatherAndMusic.Domain.Interfaces.Repositories;
using WeatherAndMusic.Infra.Persistence.Repositories.Base;

namespace WeatherAndMusic.Infra.Persistence.Repositories
{
    public class RepositoryLog : RepositoryBase<Log, int>, IRepositoryLog
    {
        private readonly WeatherAndMusicContext _context;

        public RepositoryLog(WeatherAndMusicContext context) : base(context)
        {
            _context = context;
        }
    }
}
