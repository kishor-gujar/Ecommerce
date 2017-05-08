namespace EcommerceData.Models
{
    public class Attribute
    {
        public string Id { get; set; } = IdGenerator.NewId();
        public AttributeGroup AttributeGroup { get; set; }
    }
}