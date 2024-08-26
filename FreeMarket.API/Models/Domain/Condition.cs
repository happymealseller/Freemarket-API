namespace FreeMarket.API.Models.Domain
{
    public class Condition
    {
        public Guid Id { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
    }
}