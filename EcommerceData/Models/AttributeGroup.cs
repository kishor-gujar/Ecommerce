namespace EcommerceData.Models
{
    public class AttributeGroup
    {
        public string Id { get; set; } = IdGenerator.NewId();
        public int SortOrder { get; set; }
    }
}