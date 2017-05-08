using EcommerceData.Models;

namespace EcommerceAngular.Models
{
    public class AttributeCreateModel 
    {
        public string Name  { get; set; }
        public AttributeGroup AttributeGroup { get; set; }
        public int SortOrder { get; set; }
    }
}