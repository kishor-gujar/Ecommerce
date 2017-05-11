using System;
using System.ComponentModel.DataAnnotations;

namespace EcommerceAngular.Models
{
    public class Review : Resource
    {
        public string Author { get; set; }

        public Product Product { get; set; }

        public string Text { get; set; }

        public int Rating { get; set; }

        public DateTime DateCreated { get; set; }
        public bool  Status { get; set; }

    }
}