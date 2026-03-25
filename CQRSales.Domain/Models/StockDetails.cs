namespace CQRSales.Domain.Models
{
    public enum Type
    {
        Sale = 1,
        Purchase = 2,
        Expenses = 3
    }
    public class StockDetails : BaseEntity
    {
        public double Total { get; set; }
        public DateTime Date { get; set; }
        public Type Type { get; set; }
        public int StockID { get; set; }
        public Stock? Stock { get; set; }
        public int? OrderID { get; set; }
        public Order? Order { get; set; }
    }
}
