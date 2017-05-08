using System.Data.SqlClient;

namespace EcommerceData.Models
{
    public class OptionValue
    {
        public int Id { get; set; }
        public Option Option { get; set; }
        public string Image { get; set; }
        public SortOrder SortOrder { get; set; }
    }
}