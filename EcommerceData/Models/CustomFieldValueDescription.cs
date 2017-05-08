namespace EcommerceData.Models
{
    public class CustomFieldValueDescription
    {
        public int Id { get; set; }
        public Language Language { get; set; }
        public CustomField CustomField { get; set; }
        public string Name { get; set; }
    }
}