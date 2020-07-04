using WeatherAndMusic.Domain.Arguments.Base;
using WeatherAndMusic.Domain.Interfaces.Arguments;

namespace WeatherAndMusic.Domain.Arguments.WMUser
{
    public class EditWMUserResponse : ResponseBase, IResponse
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public string HomeTown { get; set; }

        public static explicit operator EditWMUserResponse(Entities.WMUser user)
        {
            return new EditWMUserResponse()
            {
                Email = user.Email.ToString(),

                Nome = user.Name.ToString()
            };
        }
    }
}
