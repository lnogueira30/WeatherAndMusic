using WeatherAndMusic.Domain.Arguments.Base;
using WeatherAndMusic.Domain.Interfaces.Arguments;

namespace WeatherAndMusic.Domain.Arguments.Note
{
    public class AddNoteRequest : RequestBase, IRequest
    {
        public int WMUserId { get; set; }
        public string Text { get; set; }
    }
}
