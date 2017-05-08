using System.Data.SqlClient;

namespace EcommerceData.Models
{
    public class Information
    {
        public int Id { get; set; }
        public int Bottom { get; set; }
        public SortOrder SortOrder { get; set; }
        public bool Status { get; set; }
    }
}