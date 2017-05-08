namespace EcommerceData.Models
{
    public class FilterGroupDescription
    {
        public int Id { get; set; }
        public FilterGroup FilterGroup { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
    }
}