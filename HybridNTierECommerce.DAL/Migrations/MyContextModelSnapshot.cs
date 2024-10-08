﻿// <auto-generated />
using System;
using HybridNTierECommerce.DAL.ContextClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HybridNTierECommerce.DAL.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<Guid?>("ActivationCode")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1ec57956-3364-4ba8-a222-63388c1e0a69",
                            CreatedDate = new DateTime(2024, 9, 26, 12, 47, 14, 259, DateTimeKind.Local).AddTicks(3310),
                            Email = "cagri@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "CAGRI@EMAIL.COM",
                            NormalizedUserName = "CGR123",
                            PasswordHash = "AQAAAAIAAYagAAAAEMjflSX462pl0IAnNwDbhnW4Q1e4HQInZK0i6KUhXpjK3hwof5fwwuQGuA7dtDGTEw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "dbb31ad5-c088-4578-8962-48036e713e56",
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "cgr123"
                        });
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.AppUserProfile", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryName = "Home",
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 315, DateTimeKind.Utc).AddTicks(9578),
                            Description = "Quaerat un voluptatum cezbelendi doloremque layıkıyla alias aut vel ötekinden.",
                            Status = 1
                        },
                        new
                        {
                            ID = 2,
                            CategoryName = "Electronics",
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(128),
                            Description = "Göze sokaklarda umut ea sed sıla commodi layıkıyla velit mıknatıslı.",
                            Status = 1
                        },
                        new
                        {
                            ID = 3,
                            CategoryName = "Shoes",
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(371),
                            Description = "Tv ab totam sıla yazın ipsum incidunt alias gazete quaerat.",
                            Status = 1
                        },
                        new
                        {
                            ID = 4,
                            CategoryName = "Books",
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(424),
                            Description = "Gül et sit aperiam dışarı illo mıknatıslı gülüyorum dolayı quae.",
                            Status = 1
                        },
                        new
                        {
                            ID = 5,
                            CategoryName = "Movies",
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(475),
                            Description = "Sarmal enim commodi odit dağılımı blanditiis için sed magni amet.",
                            Status = 1
                        },
                        new
                        {
                            ID = 6,
                            CategoryName = "Movies",
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(548),
                            Description = "Çarpan gidecekmiş tv gitti yaptı karşıdakine çarpan aut sıla vel.",
                            Status = 1
                        },
                        new
                        {
                            ID = 7,
                            CategoryName = "Health",
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(1028),
                            Description = "Cezbelendi magni umut tempora eve anlamsız ve kutusu quaerat incidunt.",
                            Status = 1
                        },
                        new
                        {
                            ID = 8,
                            CategoryName = "Health",
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(1084),
                            Description = "Dignissimos ötekinden enim orta ut sit sandalye de gitti adresini.",
                            Status = 1
                        },
                        new
                        {
                            ID = 9,
                            CategoryName = "Industrial",
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(1134),
                            Description = "Molestiae dolayı ut gidecekmiş makinesi masanın dolore numquam sit tempora.",
                            Status = 1
                        },
                        new
                        {
                            ID = 10,
                            CategoryName = "Grocery",
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(1181),
                            Description = "Odio ekşili çarpan accusantium tv değirmeni lakin kutusu totam amet.",
                            Status = 1
                        });
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("AppUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AppUserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("OrderID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 1,
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(1343),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 642.55m,
                            ProductName = "Fantastic Concrete Towels",
                            Status = 1,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = 2,
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(1827),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 991.81m,
                            ProductName = "Generic Rubber Fish",
                            Status = 1,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 3,
                            CategoryID = 3,
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(1968),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 717.71m,
                            ProductName = "Awesome Fresh Hat",
                            Status = 1,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 4,
                            CategoryID = 4,
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(2067),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 543.72m,
                            ProductName = "Unbranded Concrete Soap",
                            Status = 1,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 5,
                            CategoryID = 5,
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(2247),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 544.88m,
                            ProductName = "Handmade Granite Cheese",
                            Status = 1,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 6,
                            CategoryID = 6,
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(2339),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 970.66m,
                            ProductName = "Awesome Fresh Ball",
                            Status = 1,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 7,
                            CategoryID = 7,
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(2482),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 898.81m,
                            ProductName = "Gorgeous Rubber Cheese",
                            Status = 1,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 8,
                            CategoryID = 8,
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(2575),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 745.01m,
                            ProductName = "Tasty Wooden Hat",
                            Status = 1,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 9,
                            CategoryID = 9,
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(2718),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 904.72m,
                            ProductName = "Ergonomic Wooden Keyboard",
                            Status = 1,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 10,
                            CategoryID = 10,
                            CreatedDate = new DateTime(2024, 9, 26, 9, 47, 14, 316, DateTimeKind.Utc).AddTicks(2813),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 263.55m,
                            ProductName = "Unbranded Granite Sausages",
                            Status = 1,
                            UnitsInStock = 100
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "35454ede-6f67-47bc-a7c6-1b4b0a9e9113",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.AppUserProfile", b =>
                {
                    b.HasOne("HybridNTierECommerce.ENTITIES.Models.AppUser", "AppUser")
                        .WithOne("Profile")
                        .HasForeignKey("HybridNTierECommerce.ENTITIES.Models.AppUserProfile", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.Order", b =>
                {
                    b.HasOne("HybridNTierECommerce.ENTITIES.Models.AppUser", "AppUser")
                        .WithMany("Orders")
                        .HasForeignKey("AppUserID");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.OrderDetail", b =>
                {
                    b.HasOne("HybridNTierECommerce.ENTITIES.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HybridNTierECommerce.ENTITIES.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.Product", b =>
                {
                    b.HasOne("HybridNTierECommerce.ENTITIES.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("HybridNTierECommerce.ENTITIES.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("HybridNTierECommerce.ENTITIES.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HybridNTierECommerce.ENTITIES.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("HybridNTierECommerce.ENTITIES.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.AppUser", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Profile")
                        .IsRequired();
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
