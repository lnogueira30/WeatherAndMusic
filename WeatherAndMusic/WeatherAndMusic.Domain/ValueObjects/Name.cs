using prmToolkit.NotificationPattern;

namespace WeatherAndMusic.Domain.ValueObjects
{
    public class Name : Notifiable
    {
        public string name { get; private set; }

        public Name(string name)
        {
            this.name = name;

            new AddNotifications<Name>(this)
                .IfNullOrInvalidLength(x => x.name, 3, 20, "Bad Name");
        }

        public override string ToString()
        {
            return name;
        }
    }
}
