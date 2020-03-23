﻿// <auto-generated />
using System;
using AspNetCoreSpa.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNetCoreSpa.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.Account", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR(255)");

                    b.Property<string>("Avatar")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("Password")
                        .HasColumnType("NVARCHAR(255)");

                    b.Property<string>("Phone")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR(500)");

                    b.Property<string>("Image")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(100)");

                    b.HasKey("Id");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.BookingPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookingDetailId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TourBookingDetailId")
                        .HasColumnType("int");

                    b.Property<int>("TouristTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TourBookingDetailId");

                    b.HasIndex("TouristTypeId");

                    b.ToTable("BookingPrices");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR(255)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("Phone")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Title")
                        .HasColumnType("NVARCHAR(100)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.Culture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(255)");

                    b.HasKey("Id");

                    b.ToTable("Cultures");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.Evaluation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FiveStar")
                        .HasColumnType("int");

                    b.Property<int>("FourStar")
                        .HasColumnType("int");

                    b.Property<int>("OneStar")
                        .HasColumnType("int");

                    b.Property<int>("ThreeStar")
                        .HasColumnType("int");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.Property<int>("TwoStar")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TourId");

                    b.ToTable("Evaluations");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<bool>("Censorship")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("Image")
                        .HasColumnType("NVARCHAR(255)");

                    b.Property<string>("MetaDescription")
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("MetaKeyWord")
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<int>("PostCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("PostContent")
                        .HasColumnType("NVARCHAR(200)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PostCategoryId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.PostCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(100)");

                    b.HasKey("Id");

                    b.ToTable("PostCategories");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PromotionPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDatePro")
                        .HasColumnType("datetime2");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.Property<int>("TouristTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TouristTypeId");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(100)");

                    b.HasKey("Id");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CultureId")
                        .HasColumnType("int");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CultureId");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .HasColumnType("NVARCHAR(100)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.Tour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("Censorship")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartureId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR(500)");

                    b.Property<string>("Image")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Images")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<int?>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<int>("Slot")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("TourCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.HasIndex("TourCategoryId");

                    b.ToTable("Tours");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.TourBooking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR(255)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("Mobile")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Note")
                        .HasColumnType("NVARCHAR(500)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserId1")
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.HasIndex("UserId1");

                    b.ToTable("TourBookings");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.TourBookingDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TourBookingId")
                        .HasColumnType("int");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TourBookingId");

                    b.ToTable("TourBookingDetails");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.TourCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR(500)");

                    b.Property<string>("Image")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(100)");

                    b.HasKey("Id");

                    b.ToTable("TourCategories");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.TourCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("TourBookingId")
                        .HasColumnType("int");

                    b.Property<int>("TouristTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TourBookingId");

                    b.HasIndex("TouristTypeId");

                    b.ToTable("TourCustomers");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.TourProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR(500)");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<int?>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.HasIndex("TourId");

                    b.ToTable("TourPrograms");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.TouristType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(100)");

                    b.HasKey("Id");

                    b.ToTable("TouristTypes");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.Account", b =>
                {
                    b.HasOne("AspNetCoreSpa.Core.Entities.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.BookingPrice", b =>
                {
                    b.HasOne("AspNetCoreSpa.Core.Entities.TourBookingDetail", "TourBookingDetail")
                        .WithMany("BookingPrices")
                        .HasForeignKey("TourBookingDetailId");

                    b.HasOne("AspNetCoreSpa.Core.Entities.TouristType", "TouristType")
                        .WithMany()
                        .HasForeignKey("TouristTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.Evaluation", b =>
                {
                    b.HasOne("AspNetCoreSpa.Core.Entities.Tour", "Tour")
                        .WithMany("Evaluations")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.Post", b =>
                {
                    b.HasOne("AspNetCoreSpa.Core.Entities.PostCategory", "PostCategory")
                        .WithMany("Posts")
                        .HasForeignKey("PostCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.Price", b =>
                {
                    b.HasOne("AspNetCoreSpa.Core.Entities.TouristType", "TouristType")
                        .WithMany("Price")
                        .HasForeignKey("TouristTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.Resource", b =>
                {
                    b.HasOne("AspNetCoreSpa.Core.Entities.Culture", "Culture")
                        .WithMany("Resources")
                        .HasForeignKey("CultureId");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.Tour", b =>
                {
                    b.HasOne("AspNetCoreSpa.Core.Entities.Province", "Province")
                        .WithMany("Tours")
                        .HasForeignKey("ProvinceId");

                    b.HasOne("AspNetCoreSpa.Core.Entities.TourCategory", "TourCategory")
                        .WithMany("Tours")
                        .HasForeignKey("TourCategoryId");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.TourBooking", b =>
                {
                    b.HasOne("AspNetCoreSpa.Core.Entities.Account", "User")
                        .WithMany("TourBookings")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.TourBookingDetail", b =>
                {
                    b.HasOne("AspNetCoreSpa.Core.Entities.TourBooking", "TourBooking")
                        .WithMany("TourBookingDetails")
                        .HasForeignKey("TourBookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.TourCustomer", b =>
                {
                    b.HasOne("AspNetCoreSpa.Core.Entities.TourBooking", null)
                        .WithMany("TourCustomers")
                        .HasForeignKey("TourBookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspNetCoreSpa.Core.Entities.TouristType", "TouristType")
                        .WithMany("TourCustomer")
                        .HasForeignKey("TouristTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AspNetCoreSpa.Core.Entities.TourProgram", b =>
                {
                    b.HasOne("AspNetCoreSpa.Core.Entities.Province", null)
                        .WithMany("TourPrograms")
                        .HasForeignKey("ProvinceId");

                    b.HasOne("AspNetCoreSpa.Core.Entities.Tour", "Tour")
                        .WithMany()
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
