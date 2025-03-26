namespace CarRentalAPI.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }
        public string PickupLocation { get; set; } = default!;
        public DateTime PickupDatetime { get; set; }
        public string DropoffLocation { get; set; } = default!;
        public DateTime DropoffDatetime { get; set; }
        public DateTime BookingDate { get; set; }
        public int RentalDays { get; set; }
        public decimal TotalRentalPrice { get; set; }
        public string BookingStatus { get; set; } = default!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
