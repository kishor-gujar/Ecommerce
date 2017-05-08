using System;

namespace EcommerceData.Models
{
    public class Order
    {
        public int Id { get; set; }
        public  int InvoiceNo { get; set; }
        public string InvoicePrefix { get; set; }
        public Store Store { get; set; }
        public string StoreName { get; set; }
        public string StoreUrl { get; set; }
        public ApplicationUser User { get; set; }
        public UserGroup Group { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string CustomFild { get; set; }
        public string PaymentFirstName { get; set; }
        public string PaymentLastName { get; set; }
        public string PaymentCompany { get; set; }
        public string PaymentAddress1 { get; set; }
        public string PaymentAddress2 { get; set; }
        public string PaymentCity { get; set; }
        public string PaymentPostalcode { get; set; }
        public string PaymentCountryName { get; set; }
        public Country PaymentCountry { get; set; }
        public string PaymentZoneName { get; set; }
        public Zone PaymentZone { get; set; }
        public string PaymentAddressFormat { get; set; }
        public string PaymentCustomField { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentCode { get; set; }
        public string ShippingFirstName { get; set; }
        public string ShippingLastName { get; set; }
        public string ShippingCompany { get; set; }
        public string ShippingAddress1 { get; set; }
        public string ShippingAddress2 { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingCountryName { get; set; }
        public Country ShippingCountry { get; set; }
        public string ShippingZoneName { get; set; }
        public Zone ShippingZone { get; set; }
        public string ShippingAddressFormat { get; set; }
        public string ShippingCustomField { get; set; }
        public string ShippingMethod { get; set; }
        public string ShippingCode { get; set; }
        public string Comment { get; set; }
        public decimal Total { get; set; }
        public Affiliate Affiliate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal Commission { get; set; }
        public Marketing Marketing { get; set; }
        public string Tracking { get; set; }
        public Language Language { get; set; }
        public Currency Currency { get; set; }
        public string CurrencyValue { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

    }
}