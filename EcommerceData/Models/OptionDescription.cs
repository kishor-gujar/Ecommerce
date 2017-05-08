namespace EcommerceData.Models
{
    public class OptionDescription
    {
        public int Id { get; set; }
        public Option Option { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
    }
}