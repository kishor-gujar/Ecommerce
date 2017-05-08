namespace EcommerceData.Models
{
    public class LengthClassDescription
    {
        public int Id { get; set; }
        public LengthClass LengthClass { get; set; }
        public Language Language { get; set; }
        public string Title { get; set; }
        public string Unit { get; set; }
    }
}