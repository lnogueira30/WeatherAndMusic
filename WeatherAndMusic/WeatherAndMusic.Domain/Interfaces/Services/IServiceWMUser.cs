using WeatherAndMusic.Domain.Arguments.WMUser;

namespace WeatherAndMusic.Domain.Interfaces
{
    public interface IServiceWMUser
    {
        public LogOnWMUserResponse LogOn(LogOnWMUserRequest request);
        public LogInWMUserResponse LogIn(LogInWMUserRequest request);
        public EditWMUserResponse Edit(EditWMUserRequest request);
    }
}
