using System.Data.SqlClient;

namespace EcommerceData.Models
{
    public class OrderTotal
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public SortOrder SortOrder { get; set; }
    }
}