namespace CarRentalAPI.Models
{
	public class Feedback
	{
		public int FeedbackId { get; set; }
		public int BookingId { get; set; }
		public int UserId { get; set; }
		public byte OverallSatisfaction { get; set; }
		public byte CarConditionRating { get; set; }
		public byte PickupProcessRating { get; set; }
		public byte DropoffProcessRating { get; set; }
		public byte CustomerServiceRating { get; set; }
		public string Comments { get; set; } = default!;
		public bool WouldRentAgain { get; set; }
		public bool WouldRecommend { get; set; }
		public DateTime FeedbackSubmissionDate { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}
