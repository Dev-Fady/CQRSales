namespace CQRSales.Domain.Models
{
    public class Order : BaseEntity
    {
        public DateTime DateOrder { get; set; }
        public double TotalOrder { get; set; }
        public int? CustomerID { get; set; }
        public Customer? Customer { get; set; }

        public ICollection<OrderProduct>? OrderProducts { get; set; }
    }
}
