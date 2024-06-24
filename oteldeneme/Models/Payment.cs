namespace oteldeneme.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int ReservationId { get; set; } // Foreign Key
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }

        // Navigation Property
        public Reservation Reservation { get; set; }
    }
}
