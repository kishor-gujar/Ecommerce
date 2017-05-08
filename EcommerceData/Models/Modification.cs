using System;
using System.IO;

namespace EcommerceData.Models
{
    public class Modification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Author { get; set; }
        public string Version { get; set; }
        public string Link { get; set; }
        public string Xml { get; set; }
        public bool Status { get; set; }
        public DateTime DateCreated { get; set; }
    }
}