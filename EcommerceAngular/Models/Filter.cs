using System.Collections.Generic;

namespace EcommerceAngular.Models
{
    public class Filter : Resource
    {
        public string FilterGroupName { get; set; }
        public int SortOrder { get; set; }

        public List<Filter> Filters { get; set; }
    }
}