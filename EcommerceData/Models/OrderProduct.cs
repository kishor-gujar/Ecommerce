using System.Diagnostics;

namespace EcommerceData.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public decimal Tax { get; set; }
        public int Reward { get; set; } 
    }
}