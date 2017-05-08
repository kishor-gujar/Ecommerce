namespace EcommerceData.Models
{
    public class ProductAttribute
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Attribute Attribute { get; set; }
        public Language Language { get; set; }
        public string Text { get; set; }
    }
}