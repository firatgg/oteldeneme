namespace oteldeneme.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int CustomerId { get; set; } // Foreign Key
        public int RoomId { get; set; } // Foreign Key
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string ReservationStatus { get; set; }

        // Navigation Properties
        public Customer Customer { get; set; }
        public Room Room { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
