using Microsoft.EntityFrameworkCore.Design.Internal;

namespace EcommerceData.Models
{
    public class AttributeGroupDecription
    {
        public int Id { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
    }
}