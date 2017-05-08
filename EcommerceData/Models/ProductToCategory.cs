namespace EcommerceData.Models
{
    public class ProductToCategory
    {
        public int Id { get; set; }
        public Product Product  { get; set; }
        public Category Category { get; set; }
    }
}