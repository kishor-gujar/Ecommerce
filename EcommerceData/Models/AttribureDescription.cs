namespace EcommerceData.Models
{
    public class AttribureDescription
    {
        public int Id { get; set; }
        public Attribute Attribute { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
    }
}