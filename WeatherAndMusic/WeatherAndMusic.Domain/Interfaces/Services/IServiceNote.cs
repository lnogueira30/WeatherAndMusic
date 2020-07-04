using WeatherAndMusic.Domain.Arguments.Note;
using WeatherAndMusic.Domain.Arguments.WMUser;

namespace WeatherAndMusic.Domain.Interfaces
{
    public interface IServiceNote
    {
        public AddNoteResponse Add(AddNoteRequest request);
        public RemoveNoteResponse Delete(DeleteNoteRequest request);
        public EditNoteResponse Edit(EditNoteRequest request);
    }
}
