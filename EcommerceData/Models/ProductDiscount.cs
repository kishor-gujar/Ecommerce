namespace EcommerceData.Models
{
    public class ProductDiscount
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public UserGroup UserGroup { get; set; }
    }
}