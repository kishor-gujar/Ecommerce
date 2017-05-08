using System.Data.SqlClient;

namespace EcommerceData.Models
{
    public class MunuModule
    {
        public int Id { get; set; }
        public Menu Menu { get; set; }
        public string Code { get; set; }
        public SortOrder SortOrder { get; set; }
    }
}