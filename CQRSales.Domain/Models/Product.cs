namespace CQRSales.Domain.Models
{
    public class Product : NamedEntity
    {
        public double BuyPrice { get; set; }
        public double SalePrice { get; set; }
        public double Quantity { get; set; }
        public int MinQuantity { get; set; }

        public int? CategoryID { get; set; }
        public Category? Category { get; set; }

        public ICollection<OrderProduct>? OrderProducts { get; set; }
    }
}
