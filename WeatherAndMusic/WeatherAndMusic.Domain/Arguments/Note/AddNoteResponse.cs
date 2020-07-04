using WeatherAndMusic.Domain.Arguments.Base;
using WeatherAndMusic.Domain.Interfaces.Arguments;

namespace WeatherAndMusic.Domain.Arguments.Note
{
    public class AddNoteResponse : ResponseBase, IResponse
    {
        public static explicit operator AddNoteResponse(Entities.Note note)
        {
            return new AddNoteResponse { Message = "Note added" };
        }
    }
}
