namespace CarRentalAPI.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Make { get; set; } = default!;
        public string Model { get; set; } = default!;
        public short Year { get; set; }
        public string Category { get; set; } = default!;
        public string TransmissionType { get; set; } = default!; // "Automatic" or "Manual"
        public byte NumberOfPassengers { get; set; }
        public byte NumberOfBags { get; set; }
        public string Color { get; set; } = default!;
        public int Mileage { get; set; }
        public string RegistrationNumber { get; set; } = default!;
        public decimal DailyRate { get; set; }
        public bool AvailabilityStatus { get; set; }
        //public int LocationId { get; set; }
        public string ImageUrl { get; set; } = default!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
