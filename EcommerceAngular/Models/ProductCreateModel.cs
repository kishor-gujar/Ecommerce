using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using EcommerceData.Models;
using Microsoft.AspNetCore.Authorization;

namespace EcommerceAngular.Models
{
    public class ProductCreateModel
    {
        [Required]
        public string Name { get; set; }
        public string Discription { get; set; }

        [Required]
        public string MetaTagTitle { get; set; }

        public string MetaTagDiscription { get; set; }
        public string MetaTagKeywords { get; set; }
        public string ProductTags { get; set; }

        [Required]
        public int Model { get; set; }
        public string Sku { get; set; }
        public string Upc { get; set; }
        public string Ean { get; set; }
        public string Jan { get; set; }
        public string Isbn { get; set; }
        public string Mpn { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public TaxClass TaxClass { get; set; }
        public int Quantity { get; set; }
        public int MinimumQuantity { get; set; }
        public bool SubtractStock { get; set; }
        public StockStatus StockStatus { get; set; }
        public bool RequiersShipping { get; set; }
        public string SeoUrl { get; set; }
        public DateTime DateAvailable { get; set; }
        public Dimensions Dimensions { get; set; }
        public string Wight { get; set; }
        public WeightClass WeightClass { get; set; }
        public bool Status { get; set; }
        public int SortOrder { get; set; }
        public Manufacurer Manufacurer { get; set; }

        public List<Category> Categories { get; set; }

        public List<Store> Stores { get; set; }

        public List<Download> Downloads { get; set; }

        public List<ProductRelated> RelatedsProducts { get; set; }

        public List<EcommerceData.Models.Attribute> Attributes { get; set; }
        
        public bool Shipping { get; set; }
        public int Points { get; set; }
        public decimal Weight { get; set; }
        public decimal Length { get; set; }
        public LengthClass LengthClass { get; set; }
        public bool Subtract { get; set; }
        public int StockOrder { get; set; }
    }

}