namespace EcommerceData.Models
{
    public class ProductDescription
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
    }
}