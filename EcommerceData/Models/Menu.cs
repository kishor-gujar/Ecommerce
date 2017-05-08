using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Design.Internal;

namespace EcommerceData.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public Store Store { get; set; }
        public string Type { get; set; }
        public string Link { get; set; }
        public SortOrder SortOrder { get; set; }
        public bool Status { get; set; }    
    }
}