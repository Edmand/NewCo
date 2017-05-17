using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewCo.Core.Models
{
    [Table("Accounts")]
    public class Account
    {
        public int AccountId { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }
        
        [Required]
        public int SubscriberTypeId { get; set; }
        
        [Required]
        public int PaymentOptionId { get; set; }
        
        [Required]
        public int NotificationTypeId { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
}