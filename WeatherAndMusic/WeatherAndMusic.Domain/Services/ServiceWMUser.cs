using prmToolkit.NotificationPattern;
using WeatherAndMusic.Domain.Arguments.WMUser;
using WeatherAndMusic.Domain.Entities;
using WeatherAndMusic.Domain.Interfaces;
using WeatherAndMusic.Domain.Interfaces.Repositories;

namespace WeatherAndMusic.Domain.Services
{
    public class ServiceWMUser : Notifiable, IServiceWMUser
    {
        private readonly IRepositoryWMUser _repository;

        public ServiceWMUser(IRepositoryWMUser repository)
        {
            _repository = repository;
        }

        public EditWMUserResponse Edit(EditWMUserRequest request)
        {
            if (request == null)
                AddNotification(nameof(EditWMUserRequest), nameof(EditWMUserRequest) + " required");

            var response = _repository.GetById(request.Id);

            if (response == null)
                AddNotification("Id", "Not Found");

            response.EditWMUser(request.Name, request.Email, request.HomeTown);

            AddNotifications(response);


            if (this.IsValid())
                _repository.Edit(response);

            return (EditWMUserResponse)response;
        }

        public LogInWMUserResponse LogIn(LogInWMUserRequest request)
        {
            if (request == null)
                AddNotification(nameof(LogInWMUserRequest), nameof(LogInWMUserRequest) + " required");

            WMUser user = new WMUser(request.Name, request.Email, request.Pass);

            AddNotifications(user);

            WMUser response = null;

            if (this.IsValid())
            {
                _repository.Add(user);
                return (LogInWMUserResponse)user;
            }


            return (LogInWMUserResponse)response;
        }

        public LogOnWMUserResponse LogOn(LogOnWMUserRequest request)
        {
            if (request == null)
                AddNotification("LogOnWMUserRequest", "LogOnWMUserRequest required");

            var user = new WMUser(request.Email, request.Pass);

            AddNotifications(user);

            WMUser response = null;

            if (this.IsValid())
                response = _repository.GetBy(x => x.Email == user.Email && x.Pass == user.Pass);

            return (LogOnWMUserResponse)response;
        }
    }
}
