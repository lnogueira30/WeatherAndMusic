using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using WeatherAndMusic.Domain.Arguments.WMUser;
using WeatherAndMusic.Domain.Interfaces;
using WeatherAndMusic.Domain.Interfaces.Repositories;
using WeatherAndMusic.Domain.Services;
using WeatherAndMusic.Infra.Persistence;
using WeatherAndMusic.Infra.Persistence.Repositories;
using WeatherAndMusic.Infra.Transactions;

namespace TesteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
            .AddDbContext<WeatherAndMusicContext>(options =>
                options.UseMySql(connectionString: "Server=localhost,3306;Database=weatherandmusicdb;Uid=WMSystemUser;Pwd=Senha123456"))
            .AddSingleton<IUnitOfWork, UnitOfWork>()
            .AddSingleton<IRepositoryWMUser, RepositoryWMUser>()
            .AddSingleton<IServiceWMUser, ServiceWMUser>()

            .BuildServiceProvider();

            var request = new LogInWMUserRequest
            {
                Email = "teste@gmail.com",
                Name = "Hardtimes",
                Pass = "123567"
            };

            var service = serviceProvider.GetService<IServiceWMUser>();

            var response = service.LogIn(request);

            var unity = serviceProvider.GetService<IUnitOfWork>();

            unity.Commit();

            Console.WriteLine(response.Message);

        }
    }
}
