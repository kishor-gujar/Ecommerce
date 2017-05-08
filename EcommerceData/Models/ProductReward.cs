namespace EcommerceData.Models
{
    public class ProductReward
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public UserGroup UserGroup { get; set; }
        public int Points { get; set; }
    }
}