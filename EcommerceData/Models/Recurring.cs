namespace EcommerceData.Models
{
    public class Recurring
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public Frequency Frequency { get; set; }
    }

    public enum Frequency
    {
        Day,
        Week,
        SemiMonth,
        Month, 
        Year
    };
}