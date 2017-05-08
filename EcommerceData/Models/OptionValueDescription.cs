namespace EcommerceData.Models
{
    public class OptionValueDescription
    {
        public int Id { get; set; }
        public OptionValue OptionValue { get; set; }
        public Language Language { get; set; }
        public Option Option { get; set; }
        public string Name { get; set; }
    }
}