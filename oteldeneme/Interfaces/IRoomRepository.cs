namespace oteldeneme.Interfaces
{
    public class IRoomRepository
    {
        public int RoomId { get; set; }
        public int HotelId { get; set; } // Foreign Key
        public string RoomNumber { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
    }
}
