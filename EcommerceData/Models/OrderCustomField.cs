namespace EcommerceData.Models
{
    public class OrderCustomField
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public CustomField CustomField { get; set; }
        public CustomFieldValue CustomFieldValue { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
    }
}