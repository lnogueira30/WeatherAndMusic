using WeatherAndMusic.Domain.Arguments.Base;
using WeatherAndMusic.Domain.Interfaces.Arguments;

namespace WeatherAndMusic.Domain.Arguments.WMUser
{
    public class EditNoteRequest : RequestBase, IRequest
    {
        public int WMUserId { get; set; }
        public string Text { get; set; }
    }
}
