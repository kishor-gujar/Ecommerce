using System.Reflection.Metadata.Ecma335;

namespace EcommerceData.Models
{
    public class TaxRule
    {
        public int Id { get; set; }
        public TaxClass TaxClass { get; set; }
        public TaxRate TaxRate { get; set; }
        public string Based { get; set; }
        public int Priority { get; set; }   
    }
}