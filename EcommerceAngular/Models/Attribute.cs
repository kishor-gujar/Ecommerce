
using EcommerceData.Models;

namespace EcommerceAngular.Models
{
    public class Attribute : Resource
    {
        public string Name { get; set; }
        public AttributeGroup AttributeGroup { get; set; }
        public int SortOrder { get; set; }
    }
}