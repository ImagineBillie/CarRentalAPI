using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalAPI.Models
{
    public class User
    {
        public int UserId { get; set; }

        //public required string Username { get; set; }
        //public required string PasswordHash { get; set; }
        //public required string Email { get; set; }

        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

}
