using WeatherAndMusic.Domain.Entities;
using WeatherAndMusic.Domain.Interfaces.Repositories;
using WeatherAndMusic.Infra.Persistence.Repositories.Base;

namespace WeatherAndMusic.Infra.Persistence.Repositories
{
    public class RepositoryNote : RepositoryBase<Note, int>, IRepositoryNote
    {
        private readonly WeatherAndMusicContext _context;

        public RepositoryNote(WeatherAndMusicContext context) : base(context)
        {
            _context = context;
        }
    }
}
