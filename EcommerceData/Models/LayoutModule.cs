using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Design.Internal;

namespace EcommerceData.Models
{
    public class LayoutModule   
    {
        public int Id { get; set; }
        public Layout Layout { get; set; }
        public string Code { get; set; }
        public string Position { get; set; }
        public SortOrder SortOrder { get; set; }
    }
}