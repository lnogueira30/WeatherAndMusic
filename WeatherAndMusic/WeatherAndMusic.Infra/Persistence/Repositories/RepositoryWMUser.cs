using WeatherAndMusic.Domain.Entities;
using WeatherAndMusic.Domain.Interfaces.Repositories;
using WeatherAndMusic.Infra.Persistence.Repositories.Base;

namespace WeatherAndMusic.Infra.Persistence.Repositories
{
    public class RepositoryWMUser : RepositoryBase<WMUser, int>, IRepositoryWMUser
    {
        private readonly WeatherAndMusicContext _context;

        public RepositoryWMUser(WeatherAndMusicContext context) : base(context)
        {
            _context = context;
        }
    }
}
