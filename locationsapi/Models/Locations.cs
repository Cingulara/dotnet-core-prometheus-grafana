using System;

namespace locationsapi.Models
{
    [Serializable]
    public class Location
    {
        public Location() {
            locationId = Guid.NewGuid();
        }
        public Guid locationId { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string web { get; set; }
    }

}