using System;

namespace EcommerceData.Models
{
    public class Category
    {
        public string Id { get; set; } = IdGenerator.NewId();
        public string Image { get; set; }
        public int ParentId { get; set; }
        public bool Top { get; set; }
        public int Column { get; set; }
        public int SortOrder { get; set; }
        public bool Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}