namespace EcommerceData.Models
{
    public class FilterDescription
    {
        public int Id { get; set; }
        public Filter Filter { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
    }
}