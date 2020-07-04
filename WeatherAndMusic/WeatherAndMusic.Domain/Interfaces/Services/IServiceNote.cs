using WeatherAndMusic.Domain.Arguments.WMUser;

namespace WeatherAndMusic.Domain.Interfaces
{
    public interface IServiceNote
    {
        public LogOnWMUserResponse Add(LogOnWMUserRequest request);
        public LogInWMUserResponse Delete(LogInWMUserRequest request);
        public EditNoteResponse Edit(EditNoteRequest request);
    }
}
