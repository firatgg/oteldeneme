﻿namespace oteldeneme.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // Navigation Property
        public ICollection<Reservation> Reservations { get; set; }
    }
}