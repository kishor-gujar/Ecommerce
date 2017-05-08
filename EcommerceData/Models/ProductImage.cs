namespace EcommerceData.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
    }
}