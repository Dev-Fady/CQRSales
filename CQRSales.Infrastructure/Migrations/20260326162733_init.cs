using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRSales.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IArchived = table.Column<bool>(type: "bit", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IArchived = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalMoney = table.Column<double>(type: "float", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IArchived = table.Column<bool>(type: "bit", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyPrice = table.Column<double>(type: "float", nullable: false),
                    SalePrice = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    MinQuantity = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IArchived = table.Column<bool>(type: "bit", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalOrder = table.Column<double>(type: "float", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IArchived = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductPrice = table.Column<double>(type: "float", nullable: false),
                    ProductQuantity = table.Column<int>(type: "int", nullable: false),
                    ProductTotalPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => new { x.OrderID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    StockID = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IArchived = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StockDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_StockDetails_Stocks_StockID",
                        column: x => x.StockID,
                        principalTable: "Stocks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "ArchivedById", "ArchivedByName", "ArchivedDateTime", "CreatedById", "CreatedByName", "CreatedDateTime", "DescriptionAr", "DescriptionEn", "IArchived", "ModifiedById", "ModifiedByName", "ModifiedDateTime", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, "أدوية لتخفيف الألم", "Medicines used to relieve pain", false, null, null, null, "مسكنات الألم", "Pain Relief" },
                    { 2, null, null, null, null, null, null, "مكملات غذائية لتحسين الصحة", "Supplements and vitamins for better health", false, null, null, null, "فيتامينات ومكملات", "Vitamins & Supplements" },
                    { 3, null, null, null, null, null, null, "أدوية لعلاج العدوى البكتيرية", "Drugs used to treat bacterial infections", false, null, null, null, "مضادات حيوية", "Antibiotics" },
                    { 4, null, null, null, null, null, null, "لعلاج نزلات البرد والانفلونزا", "Medicines for cold and flu symptoms", false, null, null, null, "أدوية البرد والانفلونزا", "Cold & Flu" },
                    { 5, null, null, null, null, null, null, "منتجات العناية بالبشرة والجمال", "Skin care and beauty products", false, null, null, null, "مستحضرات تجميل", "Cosmetics" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Address", "ArchivedById", "ArchivedByName", "ArchivedDateTime", "BirthDate", "CreatedById", "CreatedByName", "CreatedDateTime", "IArchived", "ModifiedById", "ModifiedByName", "ModifiedDateTime", "NameAr", "NameEn", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Cairo, Egypt", null, null, null, new DateTime(1995, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, "أحمد علي", "Ahmed Ali", "01012345678" },
                    { 2, "Alexandria, Egypt", null, null, null, new DateTime(1998, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, "سارة محمد", "Sara Mohamed", "01098765432" },
                    { 3, "Giza, Egypt", null, null, null, new DateTime(1990, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, "خالد إبراهيم", "Khaled Ibrahim", "01122334455" },
                    { 4, "Mansoura, Egypt", null, null, null, new DateTime(1993, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, "منى عبد الرحمن", "Mona Abdelrahman", "01255667788" },
                    { 5, "Tanta, Egypt", null, null, null, new DateTime(1999, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, "يوسف حسن", "Youssef Hassan", "01066554433" }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "ID", "ArchivedById", "ArchivedByName", "ArchivedDateTime", "CreatedById", "CreatedByName", "CreatedDateTime", "DescriptionAr", "DescriptionEn", "IArchived", "ModifiedById", "ModifiedByName", "ModifiedDateTime", "NameAr", "NameEn", "TotalMoney" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, "مخزون رئيسي في القاهرة", "Main stock located in Cairo", false, null, null, null, "مخزون القاهرة", "Cairo Stock", 50000.0 },
                    { 2, null, null, null, null, null, null, "مخزون فرعي في الإسكندرية", "Secondary stock in Alexandria", false, null, null, null, "مخزون الإسكندرية", "Alexandria Stock", 30000.0 },
                    { 3, null, null, null, null, null, null, "مخزون خاص بالجيزة", "Giza local stock", false, null, null, null, "مخزون الجيزة", "Giza Stock", 25000.0 },
                    { 4, null, null, null, null, null, null, "مخزون احتياطي في المنصورة", "Backup stock in Mansoura", false, null, null, null, "مخزون المنصورة", "Mansoura Stock", 15000.0 },
                    { 5, null, null, null, null, null, null, "مخزون محلي في طنطا", "Local stock in Tanta", false, null, null, null, "مخزون طنطا", "Tanta Stock", 20000.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "ArchivedById", "ArchivedByName", "ArchivedDateTime", "BuyPrice", "CategoryID", "CreatedById", "CreatedByName", "CreatedDateTime", "DescriptionAr", "DescriptionEn", "IArchived", "MinQuantity", "ModifiedById", "ModifiedByName", "ModifiedDateTime", "NameAr", "NameEn", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 1, null, null, null, 10.0, 1, null, null, null, "مسكن للألم وخافض للحرارة", "Pain reliever and fever reducer", false, 20, null, null, null, "بانادول", "Panadol", 200.0, 15.0 },
                    { 2, null, null, null, 12.0, 1, null, null, null, "مسكن للآلام والالتهابات", "Pain reliever and anti-inflammatory", false, 15, null, null, null, "بروفين", "Brufen", 150.0, 18.0 },
                    { 3, null, null, null, 25.0, 2, null, null, null, "مكمل غذائي لتعزيز المناعة", "Dietary supplement to boost immunity", false, 10, null, null, null, "فيتامين سي", "Vitamin C", 100.0, 35.0 },
                    { 4, null, null, null, 30.0, 2, null, null, null, "مكمل للعظام والأسنان", "Calcium supplement for bones and teeth", false, 15, null, null, null, "كالسيوم دي", "Calcium D", 120.0, 45.0 },
                    { 5, null, null, null, 18.0, 3, null, null, null, "مضاد حيوي واسع المدى", "Broad-spectrum antibiotic", false, 10, null, null, null, "أموكسيل", "Amoxil", 80.0, 28.0 },
                    { 6, null, null, null, 22.0, 3, null, null, null, "مضاد حيوي لعلاج العدوى", "Antibiotic for bacterial infections", false, 8, null, null, null, "سيبروفلوكساسين", "Ciprofloxacin", 90.0, 35.0 },
                    { 7, null, null, null, 10.0, 4, null, null, null, "لعلاج نزلات البرد والأنفلونزا", "Cold and flu medicine", false, 15, null, null, null, "فلودريكس", "Fludrex", 160.0, 15.0 },
                    { 8, null, null, null, 9.0, 4, null, null, null, "لعلاج أعراض البرد والاحتقان", "For cold and nasal congestion relief", false, 20, null, null, null, "كونجستال", "Congestal", 180.0, 14.0 },
                    { 9, null, null, null, 20.0, 5, null, null, null, "مرطب للبشرة الجافة", "Moisturizing cream for dry skin", false, 25, null, null, null, "مرطب نيفيا", "Nivea Cream", 250.0, 30.0 },
                    { 10, null, null, null, 15.0, 5, null, null, null, "غسول يومي للبشرة", "Daily face cleanser", false, 20, null, null, null, "غسول الوجه", "Face Wash", 220.0, 25.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductID",
                table: "OrderProducts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_StockDetails_OrderID",
                table: "StockDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_StockDetails_StockID",
                table: "StockDetails",
                column: "StockID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "StockDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
