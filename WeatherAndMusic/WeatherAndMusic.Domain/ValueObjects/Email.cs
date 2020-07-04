using prmToolkit.NotificationPattern;

namespace WeatherAndMusic.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public string email { get; private set; }

        public Email(string email)
        {
            this.email = email;

            new AddNotifications<Email>(this)
            .IfNotEmail(x => x.email, "Bad E-mail.");
        }

        public override string ToString()
        {
            return this.email;
        }
    }
}
