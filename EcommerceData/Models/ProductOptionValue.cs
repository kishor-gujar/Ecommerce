namespace EcommerceData.Models
{
    public class ProductOptionValue
    {
        public int Id { get; set; }
        public ProductOption ProductOption { get; set; }
        public Product  Product { get; set; }
        public Option Option { get; set; }
        public OptionValue OptionValue { get; set; }
        public int Quantity { get; set; }
        public bool Subtract { get; set; }
        public decimal Price { get; set; }
        public string PricePrefix { get; set; }
        public int Points { get; set; }
        public string PointsPrefix { get; set; }
        public decimal Weight { get; set; }
        public string WeightPrefix { get; set; }
    }
}