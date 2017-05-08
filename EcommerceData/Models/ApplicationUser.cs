using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EcommerceData.Models
{
    public sealed class ApplicationUser : IdentityUser 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ApplicationUser()
        {
            Address = new List<Address>();
        }
        public UserGroup Group { get; set; }
        public Store Store { get; set; }
        public Language Laguage { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Salt  { get; set; }
        public string Cart { get; set; }
        public string Wishlist { get; set; }
        public bool  Newsleter { get; set; }
        public bool Status { get; set; }
        public ICollection<Address>  Address { get; set; }
        public DateTime DateCreated { get; set; }

    }
}