namespace EcommerceData.Models
{
    public class CustomFieldValue
    {
        public int Id { get; set; }
        public CustomField CustomField { get; set; }
        public int SortOrder { get; set; }
    }
}