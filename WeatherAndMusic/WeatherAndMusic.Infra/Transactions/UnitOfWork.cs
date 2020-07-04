using WeatherAndMusic.Infra.Persistence;

namespace WeatherAndMusic.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WeatherAndMusicContext _context;

        public UnitOfWork(WeatherAndMusicContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
