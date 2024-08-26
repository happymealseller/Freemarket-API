namespace FreeMarket.API.Models.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string DisplayName { get; set; }
        public required string Email { get; set; }
        public required string EncryptedPassword { get; set; }
        public required string UserImageUrl { get; set; }
    }
}