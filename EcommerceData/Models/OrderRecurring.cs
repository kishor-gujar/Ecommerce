using System;
using System.Data.SqlClient;

namespace EcommerceData.Models
{
    public class OrderRecurring
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public string Reference { get; set; }
        public Product Product { get; set; }
        public string ProdcutName { get; set; }
        public int ProductQuantity { get; set; }
        public Recurring Recurring { get; set; }
        public string RecurringName { get; set; }
        public string RecurringDescription { get; set; }
        public string RecurringFrequency { get; set; }
        public short RecurringCycle { get; set; }
        public short RecurringDuration { get; set; }
        public short RecurringPrice { get; set; }
        public bool Trial { get; set; }
        public string TrialFrequency { get; set; }
        public short TrialCycle { get; set; }
        public short TrialDuration { get; set; }
        public decimal TrialPrice { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
    }
}