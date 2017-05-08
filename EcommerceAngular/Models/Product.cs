using System;
using EcommerceData;
using EcommerceData.Models;

namespace EcommerceAngular.Models
{
    public class Product : Resource
    {
        public string Id { get; set; } = IdGenerator.NewId();
        public int Model { get; set; }
        public string Sku { get; set; }
        public string Upc { get; set; }
        public string Ean { get; set; }
        public string Jan { get; set; }
        public string Isbn { get; set; }
        public string Mpn { get; set; }
        public string Location { get; set; }
        public int Quantity { get; set; }
        public StockStatus StockStatus { get; set; }
        public string Image { get; set; }
        public Manufacurer Manufacurer { get; set; }
        public bool Shipping { get; set; }
        public decimal Price { get; set; }
        public int Points { get; set; }
        public TaxClass TaxClass { get; set; }
        public DateTime DateAvailable { get; set; }
        public decimal Weight { get; set; }
        public WeightClass WeightClass { get; set; }
        public decimal Length { get; set; }
        public LengthClass LengthClass { get; set; }
        public bool Subtract { get; set; }
        public int Minimum { get; set; }
        public int StockOrder { get; set; }
        public bool Status { get; set; }
        public int Viewd { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}

