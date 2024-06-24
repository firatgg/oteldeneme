﻿namespace oteldeneme.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }

        // Navigation Property
        public ICollection<Room> Rooms { get; set; }
    }
}
