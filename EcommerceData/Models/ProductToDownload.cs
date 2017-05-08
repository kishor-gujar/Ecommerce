namespace EcommerceData.Models
{
    public class ProductToDownload
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}