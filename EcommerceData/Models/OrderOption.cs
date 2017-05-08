namespace EcommerceData.Models
{
    public class OrderOption
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public OrderProduct OrderProduct { get; set; }
        public ProductOption ProductOption { get; set; }
        public ProductOptionValue ProductOptionValue { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }    
    }
}