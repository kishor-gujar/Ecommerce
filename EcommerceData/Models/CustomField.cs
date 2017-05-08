using Microsoft.EntityFrameworkCore.Design.Internal;

namespace EcommerceData.Models
{
    public class CustomField
    {
        public int Id { get; set; }
        public string Type  { get; set; }
        public string Value { get; set; }
        public string Validation { get; set; }
        public string Location { get; set; }
        public bool Status { get; set; }
        public int SortOrder { get; set; } 
    }
}