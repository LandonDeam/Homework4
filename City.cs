using System;

namespace Cities 
{
    public class City
    {
        public int Id { get; set;}

        public string city { get; set;}
        public string State { get; set;}
        public float Latitude { get; set;}
        public float Longitude { get; set;}

        public City(string id, string city, string state, string latitude, string longitude)
        {
            Id = Int32.Parse(id);
            this.city = city;
            State = state;
            Latitude = float.Parse(latitude);
            Longitude = float.Parse(longitude);
        }
    }
}
