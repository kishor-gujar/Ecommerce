using System;

namespace EcommerceData.Models
{
    public class Return
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string RProduct { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public bool Opened { get; set; }
        public ReturnReason ReturnReason { get; set; }
        public ReturnAcion ReturnAcion { get; set; }
        public ReturnStatus ReturnStatus { get; set; }
        public string Comment { get; set; }
        public DateTime DateOrdered { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}