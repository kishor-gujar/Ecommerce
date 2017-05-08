namespace EcommerceData.Models
{
    public class CustomFieldDescription
    {
        public int Id { get; set; }
        public CustomField CustomField { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
    }
}