namespace NewCo.Controllers.Resources
{
    public class AccountResource
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int SubscriberTypeId { get; set; }
        public int PaymentOptionId { get; set; }
        public int NotificationTypeId { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal { get; set; }
        public int CountryId { get; set; }
    }
}