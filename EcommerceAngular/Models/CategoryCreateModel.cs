using System.Collections.Generic;
using EcommerceData.Models;

namespace EcommerceAngular.Models
{
    public class CategoryCreateModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string MetaTagTitle { get; set; }
        public string MetaTagDescription { get; set; }
        public string MetaTagKeyWord { get; set; }
        public string Parent { get; set; }
        public List<Filter> Filterses { get; set; }
        public string Store { get; set; }
        public string SeoUrl { get; set; }
        public string Image { get; set; }
        public bool Top { get; set; }
        public int Columns { get; set; }
        public int SortOrder { get; set; }
        public bool Status { get; set; }
    }
}