using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace EcommerceAngular.Models
{
    public class FilterCreateModel
    {
        [Required]
        public string FilterGroupName { get; set; }
        public int SortOrder { get; set; }
        public List<Filter> Filters { get; set; }
    }
}