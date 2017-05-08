using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Design.Internal;

namespace EcommerceData.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Locale { get; set; }
        public string Image { get; set; }
        public string Directory { get; set; }
        public SortOrder SortOrder { get; set; }
        public bool Status { get; set; }
    }
}