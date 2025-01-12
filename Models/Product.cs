namespace SimpleCrudApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; } // Mark as 'required'
        public decimal Price { get; set; }
    }
}