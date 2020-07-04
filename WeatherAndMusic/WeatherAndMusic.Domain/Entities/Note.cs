using WeatherAndMusic.Domain.Entities.Base;
using WeatherAndMusic.Domain.Extensions;

namespace WeatherAndMusic.Domain.Entities
{
    public class Note : EntityBase
    {
        public Note() { }
        public Note(int wMUserId, string text)
        {
            WMUserId = wMUserId;
            Text = text.ConvertToMD5();
        }

        public int WMUserId { get; private set; }

        public string Text { get; private set; }
    }
}
