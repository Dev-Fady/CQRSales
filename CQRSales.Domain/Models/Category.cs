namespace CQRSales.Domain.Models
{
    public class Category : NamedEntity
    {
        public ICollection<Product> Products { get; set; }
    }
}
