using System;

namespace EcommerceData.Models
{
    public class Currency
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string SymbolLeft { get; set; }
        public string SymbolRight { get; set; }
        public char DecimalPlace { get; set; }
        public float Value { get; set; }
        public bool Status { get; set; }
        public DateTime DateModified { get; set; }
    }
}