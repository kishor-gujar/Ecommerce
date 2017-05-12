using System.Data.SqlClient;

namespace EcommerceData.Models
{
    public class Filter
    {
        public string Id { get; set; } = IdGenerator.NewId();

        public FilterGroup FilterGroup { get; set; }
        public SortOrder SortOrder { get; set; }
    }
}