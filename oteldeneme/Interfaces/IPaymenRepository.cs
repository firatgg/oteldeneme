namespace oteldeneme.Interfaces
{
    public class IPaymenRepository
    {
        public int PaymentId { get; set; }
        public int ReservationId { get; set; } 
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
    }
}
