using WeatherAndMusic.Domain.Arguments.Base;
using WeatherAndMusic.Domain.Interfaces.Arguments;

namespace WeatherAndMusic.Domain.Arguments.WMUser
{
    public class EditWMUserRequest : RequestBase, IRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string HomeTown { get; set; }
    }
}
