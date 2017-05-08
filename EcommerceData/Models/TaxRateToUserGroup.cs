using System.Reflection.Metadata.Ecma335;

namespace EcommerceData.Models
{
    public class TaxRateToUserGroup
    {
        public int Id { get; set; }
        public TaxRate TaxRate { get; set; }
        public UserGroup UserGroup { get; set; }
    }
}