using System;
using WeatherAndMusic.Domain.Entities.Base;

namespace WeatherAndMusic.Domain.Entities
{
    public class Log : EntityBase
    {
        public Log()
        {

        }
        public int Id_user { get; set; }
        public string Action { get; set; }
        public string Data { get; set; }
        public DateTime Created_At { get; set; }
    }
}
