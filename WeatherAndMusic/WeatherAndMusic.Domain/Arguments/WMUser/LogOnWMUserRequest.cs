using WeatherAndMusic.Domain.Arguments.Base;
using WeatherAndMusic.Domain.Interfaces.Arguments;

namespace WeatherAndMusic.Domain.Arguments.WMUser
{
    public class LogOnWMUserRequest : RequestBase, IRequest
    {
        public string Email { get => Email; set => Email = value; }
        public string Pass { get => Pass; set => Pass = value; }
    }
}
