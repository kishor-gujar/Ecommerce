namespace EcommerceData.Models
{
    public class ProductToStore
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Store Store { get; set; }
    }
}