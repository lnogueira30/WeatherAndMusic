using WeatherAndMusic.Domain.Arguments.Base;
using WeatherAndMusic.Domain.Interfaces.Arguments;

namespace WeatherAndMusic.Domain.Arguments.WMUser
{
    public class EditNoteResponse : ResponseBase, IResponse
    {
        public int id { get; set; }
        public int WMUserId { get; set; }
        public string Text { get; set; }

        public static explicit operator EditNoteResponse(Entities.Note note)
        {
            return new EditNoteResponse()
            {
                Message = "Note edited"
            };
        }
    }
}
