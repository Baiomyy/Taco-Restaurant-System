namespace TequilasRestaurant.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public ICollection<Product> products { get; set; }
    }
}