namespace CQRSales.Domain.Models
{
    public class Customer : BaseEntity
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
