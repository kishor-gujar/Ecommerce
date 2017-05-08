using System.Data.SqlClient;

namespace EcommerceData.Models
{
    public class Filter
    {
        public int Id { get; set; }
        public FilterGroup FilterGroup { get; set; }
        public SortOrder SortOrder { get; set; }
    }
}