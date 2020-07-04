namespace WeatherAndMusic.Infra.Transactions
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
