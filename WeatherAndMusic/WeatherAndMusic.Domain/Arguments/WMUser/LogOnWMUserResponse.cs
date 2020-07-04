using WeatherAndMusic.Domain.Arguments.Base;
using WeatherAndMusic.Domain.Interfaces.Arguments;

namespace WeatherAndMusic.Domain.Arguments.WMUser
{
    public class LogOnWMUserResponse : ResponseBase, IResponse
    {
        public string Email { get; set; }
        public string Nome { get; set; }

        public static explicit operator LogOnWMUserResponse(Entities.WMUser user)
        {
            return new LogOnWMUserResponse()
            {
                Email = user.Email.ToString(),

                Nome = user.Name.ToString()
            };
        }
    }
}
