using prmToolkit.NotificationPattern;
using WeatherAndMusic.Domain.Extensions;

namespace WeatherAndMusic.Domain.ValueObjects
{
    public class Pass : Notifiable
    {
        public string pass { get; set; }

        public Pass(string pass)
        {
            this.pass = pass;

            new AddNotifications<Pass>(this)
                .IfNullOrInvalidLength(x => x.pass, 6, 32, "Bad pass");

            this.pass = this.pass.ConvertToMD5();
        }
    }
}
