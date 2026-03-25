namespace CQRSales.Domain.Models
{
    public class OrderProduct
    {
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductTotalPrice { get; set; }
        public int? ProductID { get; set; }
        public Product? Product { get; set; }
        public int? OrderID { get; set; }
        public Order? Order { get; set; }
    }
}
