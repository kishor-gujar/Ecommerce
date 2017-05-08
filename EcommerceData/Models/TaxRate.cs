using System;
using System.Reflection.Metadata.Ecma335;

namespace EcommerceData.Models
{
    public class TaxRate
    {
        public int Id { get; set; }
        public GeoZone GeoZone { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public char Type { get; set; }
        public DateTime  DateCreated { get; set; }
        public DateTime DateModified { get; set; }  
    }
}