namespace EcommerceData.Models
{
    public class ProductRecurring
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Recurring Recurring { get; set; }
        public UserGroup UserGroup { get; set; }
    }
}