using System;
using System.ComponentModel.DataAnnotations;

namespace EcommerceAngular.Models
{
    public class RewiewCreateModel
    {
        [Required]
        public string Author { get; set; }

        [Required]
        public Product Product { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public int Rating { get; set; }

        public DateTime DateCreated { get; set; }
        public bool Status { get; set; }
    }
}