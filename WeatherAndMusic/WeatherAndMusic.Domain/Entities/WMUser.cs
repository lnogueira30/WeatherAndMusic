using System;
using System.Collections.Generic;
using WeatherAndMusic.Domain.Entities.Base;
using WeatherAndMusic.Domain.ValueObjects;


namespace WeatherAndMusic.Domain.Entities
{
    public class WMUser : EntityBase
    {

        public WMUser() { }
        public WMUser(string email, string pass)
        {
            Email = new Email(email);
            Pass = new Pass(pass);

            AddNotifications(Email, Pass);
        }

        public WMUser(string name, string email, string pass)
        {
            Name = new Name(name);
            Email = new Email(email);
            Pass = new Pass(pass);

            Created_At = DateTime.Now;

            AddNotifications(Name, Email, Pass);
        }

        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public string Salt { get; private set; }
        public Pass Pass { get; private set; }
        public string HomeTown { get; private set; }
        public string Password_Reset_Hash { get; private set; }
        public DateTime Password_Reset_Date { get; private set; }
        public DateTime Created_At { get; private set; }
        public DateTime Updated_At { get; private set; }
        public IEnumerable<Note> Notes { get; set; }

        public void EditWMUser(string name, string email, string hometown)
        {
            this.Name = new Name(name);
            this.Email = new Email(email);
            this.HomeTown = hometown;
            this.Updated_At = DateTime.Now;

            AddNotifications(Name, Email);
        }
    }
}
