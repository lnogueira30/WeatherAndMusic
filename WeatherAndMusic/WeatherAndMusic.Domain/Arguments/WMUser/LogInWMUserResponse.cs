using WeatherAndMusic.Domain.Arguments.Base;
using WeatherAndMusic.Domain.Interfaces.Arguments;

namespace WeatherAndMusic.Domain.Arguments.WMUser
{
    public class LogInWMUserResponse : ResponseBase, IResponse
    {
        public int Id { get; set; }
        public int State { get; set; }

        public static explicit operator LogInWMUserResponse(Entities.WMUser User)
        {
            return new LogInWMUserResponse()
            {
                Id = User.Id,
                Message = "User created",
                State = (int)Enum.WMUserState.Active,
            };
        }
    }
}
