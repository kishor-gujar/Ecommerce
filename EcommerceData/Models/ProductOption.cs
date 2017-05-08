namespace EcommerceData.Models
{
    public class ProductOption
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Option Option { get; set; }
        public string Value { get; set; }
        public bool Required { get; set; }  
    }
}