namespace FreeMarket.API.Models.Domain
{
    public class Category
    {
        public Guid Id { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
    }
}