namespace FreeMarket.API.Models.Domain
{
    public class Listing
    {
        public Guid Id { get; set; }
        public required Guid UserId { get; set; }
        public required Guid CategoryId { get; set; }
        public required Guid ConditionId { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required decimal Price { get; set; }
        public required string ListingImageUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public required User User { get; set; }
        public required Category Category { get; set; }
        public required Condition Condition { get; set; }
    }
}