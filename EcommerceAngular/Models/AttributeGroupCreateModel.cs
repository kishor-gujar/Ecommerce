using System.ComponentModel.DataAnnotations;

namespace EcommerceAngular.Models
{
    public class AttributeGroupCreateModel
    {
        [Required]
        public string Name { get; set; }

        public int SortOrder { get; set; }
    }
}