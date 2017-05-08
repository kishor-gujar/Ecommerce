namespace EcommerceData.Models
{
    public class CategoryFilter
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public Filter Filter { get; set; }
    }
}