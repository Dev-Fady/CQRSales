using CQRSales.Domain.Interfaces;
using CQRSales.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSales.Infrastructure.Database
{
    public class SalesContext : IdentityDbContext<ApplicaitonUser>
    {
        private readonly ICurrentUserService _currentUser;

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockDetails> StockDetails { get; set; }
        public SalesContext(DbContextOptions<SalesContext> options, ICurrentUserService currentUser
                                                                    ) :
            base(options)
        {
            _currentUser = currentUser;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
            .HasData(
                new Category { ID = 1, NameAr = "مسكنات الألم", NameEn = "Pain Relief", DescriptionAr = "أدوية لتخفيف الألم", DescriptionEn = "Medicines used to relieve pain" },
                new Category { ID = 2, NameAr = "فيتامينات ومكملات", NameEn = "Vitamins & Supplements", DescriptionAr = "مكملات غذائية لتحسين الصحة", DescriptionEn = "Supplements and vitamins for better health" },
                new Category { ID = 3, NameAr = "مضادات حيوية", NameEn = "Antibiotics", DescriptionAr = "أدوية لعلاج العدوى البكتيرية", DescriptionEn = "Drugs used to treat bacterial infections" },
                new Category { ID = 4, NameAr = "أدوية البرد والانفلونزا", NameEn = "Cold & Flu", DescriptionAr = "لعلاج نزلات البرد والانفلونزا", DescriptionEn = "Medicines for cold and flu symptoms" },
                new Category { ID = 5, NameAr = "مستحضرات تجميل", NameEn = "Cosmetics", DescriptionAr = "منتجات العناية بالبشرة والجمال", DescriptionEn = "Skin care and beauty products" }
            );

            modelBuilder.Entity<Product>()
            .HasData(
                // Pain Relief
                new Product { ID = 1, NameAr = "بانادول", NameEn = "Panadol", DescriptionAr = "مسكن للألم وخافض للحرارة", DescriptionEn = "Pain reliever and fever reducer", BuyPrice = 10, SalePrice = 15, Quantity = 200, MinQuantity = 20, CategoryID = 1 },
                new Product { ID = 2, NameAr = "بروفين", NameEn = "Brufen", DescriptionAr = "مسكن للآلام والالتهابات", DescriptionEn = "Pain reliever and anti-inflammatory", BuyPrice = 12, SalePrice = 18, Quantity = 150, MinQuantity = 15, CategoryID = 1 },

                // Vitamins & Supplements
                new Product { ID = 3, NameAr = "فيتامين سي", NameEn = "Vitamin C", DescriptionAr = "مكمل غذائي لتعزيز المناعة", DescriptionEn = "Dietary supplement to boost immunity", BuyPrice = 25, SalePrice = 35, Quantity = 100, MinQuantity = 10, CategoryID = 2 },
                new Product { ID = 4, NameAr = "كالسيوم دي", NameEn = "Calcium D", DescriptionAr = "مكمل للعظام والأسنان", DescriptionEn = "Calcium supplement for bones and teeth", BuyPrice = 30, SalePrice = 45, Quantity = 120, MinQuantity = 15, CategoryID = 2 },

                // Antibiotics
                new Product { ID = 5, NameAr = "أموكسيل", NameEn = "Amoxil", DescriptionAr = "مضاد حيوي واسع المدى", DescriptionEn = "Broad-spectrum antibiotic", BuyPrice = 18, SalePrice = 28, Quantity = 80, MinQuantity = 10, CategoryID = 3 },
                new Product { ID = 6, NameAr = "سيبروفلوكساسين", NameEn = "Ciprofloxacin", DescriptionAr = "مضاد حيوي لعلاج العدوى", DescriptionEn = "Antibiotic for bacterial infections", BuyPrice = 22, SalePrice = 35, Quantity = 90, MinQuantity = 8, CategoryID = 3 },

                // Cold & Flu
                new Product { ID = 7, NameAr = "فلودريكس", NameEn = "Fludrex", DescriptionAr = "لعلاج نزلات البرد والأنفلونزا", DescriptionEn = "Cold and flu medicine", BuyPrice = 10, SalePrice = 15, Quantity = 160, MinQuantity = 15, CategoryID = 4 },
                new Product { ID = 8, NameAr = "كونجستال", NameEn = "Congestal", DescriptionAr = "لعلاج أعراض البرد والاحتقان", DescriptionEn = "For cold and nasal congestion relief", BuyPrice = 9, SalePrice = 14, Quantity = 180, MinQuantity = 20, CategoryID = 4 },

                // Cosmetics
                new Product { ID = 9, NameAr = "مرطب نيفيا", NameEn = "Nivea Cream", DescriptionAr = "مرطب للبشرة الجافة", DescriptionEn = "Moisturizing cream for dry skin", BuyPrice = 20, SalePrice = 30, Quantity = 250, MinQuantity = 25, CategoryID = 5 },
                new Product { ID = 10, NameAr = "غسول الوجه", NameEn = "Face Wash", DescriptionAr = "غسول يومي للبشرة", DescriptionEn = "Daily face cleanser", BuyPrice = 15, SalePrice = 25, Quantity = 220, MinQuantity = 20, CategoryID = 5 }
            );

            List<Customer> Customers = new()
            {
                new Customer { ID = 1, NameAr = "أحمد علي", NameEn = "Ahmed Ali", PhoneNumber = "01012345678", Address = "Cairo, Egypt", BirthDate = new DateTime(1995, 5, 14) },
                new Customer {ID = 2,  NameAr = "سارة محمد", NameEn = "Sara Mohamed", PhoneNumber = "01098765432", Address = "Alexandria, Egypt", BirthDate = new DateTime(1998, 11, 2) },
                new Customer { ID =3, NameAr = "خالد إبراهيم", NameEn = "Khaled Ibrahim", PhoneNumber = "01122334455", Address = "Giza, Egypt", BirthDate = new DateTime(1990, 2, 25) },
                new Customer {ID = 4,  NameAr = "منى عبد الرحمن", NameEn = "Mona Abdelrahman", PhoneNumber = "01255667788", Address = "Mansoura, Egypt", BirthDate = new DateTime(1993, 8, 19) },
                new Customer {ID = 5,  NameAr = "يوسف حسن", NameEn = "Youssef Hassan", PhoneNumber = "01066554433", Address = "Tanta, Egypt", BirthDate = new DateTime(1999, 12, 1) }
            };
            modelBuilder.Entity<Customer>().HasData(Customers);

            List<Stock> Stocks = new()
            {
                new Stock {ID = 1,  NameAr = "مخزون القاهرة", NameEn = "Cairo Stock", DescriptionAr = "مخزون رئيسي في القاهرة", DescriptionEn = "Main stock located in Cairo", TotalMoney = 50000 },
                new Stock { ID = 2, NameAr = "مخزون الإسكندرية", NameEn = "Alexandria Stock", DescriptionAr = "مخزون فرعي في الإسكندرية", DescriptionEn = "Secondary stock in Alexandria", TotalMoney = 30000 },
                new Stock {ID = 3,  NameAr = "مخزون الجيزة", NameEn = "Giza Stock", DescriptionAr = "مخزون خاص بالجيزة", DescriptionEn = "Giza local stock", TotalMoney = 25000 },
                new Stock {ID = 4,  NameAr = "مخزون المنصورة", NameEn = "Mansoura Stock", DescriptionAr = "مخزون احتياطي في المنصورة", DescriptionEn = "Backup stock in Mansoura", TotalMoney = 15000 },
                new Stock {ID = 5, NameAr = "مخزون طنطا", NameEn = "Tanta Stock", DescriptionAr = "مخزون محلي في طنطا", DescriptionEn = "Local stock in Tanta", TotalMoney = 20000 }
            };
            modelBuilder.Entity<Stock>().HasData(Stocks);

            modelBuilder.Entity<OrderProduct>().HasKey(a => new { a.OrderID, a.ProductID });
            base.OnModelCreating(modelBuilder);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entiries = ChangeTracker.Entries<BaseEntity>();

            foreach (var entry in entiries)
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedById = _currentUser.UserId;
                        entry.Entity.CreatedByName = _currentUser.UserName;
                        entry.Entity.CreatedDateTime = DateTime.UtcNow;
                        break;

                    case EntityState.Modified:
                        entry.Entity.ModifiedById = _currentUser.UserId;
                        entry.Entity.ModifiedByName = _currentUser.UserName;
                        entry.Entity.ModifiedDateTime = DateTime.UtcNow;
                        break;

                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        entry.Entity.IArchived = true;
                        entry.Entity.ArchivedById = _currentUser.UserId;
                        entry.Entity.ArchivedByName = _currentUser.UserName;
                        entry.Entity.ArchivedDateTime = DateTime.UtcNow;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
