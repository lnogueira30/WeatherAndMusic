using prmToolkit.NotificationPattern;
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

            new AddNotifications<Note>(this)
                .IfNullOrInvalidLength(x => x.Text, 10, 200, "Note cant be less than 10 characters and greater than 200.");

            new AddNotifications<Note>(this)
                .IfTrue(x => x.WMUserId <= 0);
        }

        public int WMUserId { get; private set; }

        public string Text { get; private set; }
    }
}
