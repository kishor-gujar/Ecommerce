namespace EcommerceData.Models
{
    public class ProductRelated
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Related Related { get; set; }
    }
}