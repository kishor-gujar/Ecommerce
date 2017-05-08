using System;

namespace EcommerceData.Models
{
    public class ProductSpecial
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public UserGroup UserGroup { get; set; }
        public int Priority { get; set; }
        public decimal Price { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}