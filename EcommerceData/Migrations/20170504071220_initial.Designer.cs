using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EcommerceData.Data;
using System.Data.SqlClient;
using EcommerceData.Models;

namespace EcommerceData.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170504071220_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EcommerceData.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("City");

                    b.Property<string>("Company");

                    b.Property<string>("CoustomField");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Postcode");

                    b.Property<int?>("ZoneId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ZoneId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("EcommerceData.Models.Affiliate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("City");

                    b.Property<string>("Company");

                    b.Property<int?>("CountryId");

                    b.Property<string>("Email");

                    b.Property<string>("Fax");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Mobile");

                    b.Property<string>("Password");

                    b.Property<string>("PostCode");

                    b.Property<string>("Salt");

                    b.Property<string>("Telephone");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Affiliate");
                });

            modelBuilder.Entity("EcommerceData.Models.AffiliateActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AffiliateId");

                    b.Property<string>("Data");

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("Key");

                    b.HasKey("Id");

                    b.HasIndex("AffiliateId");

                    b.ToTable("AffiliateActivity");
                });

            modelBuilder.Entity("EcommerceData.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Cart");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Fax");

                    b.Property<string>("FirstName");

                    b.Property<int?>("GroupId");

                    b.Property<int?>("LaguageId");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<bool>("Newsleter");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Salt");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("Status");

                    b.Property<int?>("StoreId");

                    b.Property<string>("Telephone");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<string>("Wishlist");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("LaguageId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("StoreId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("EcommerceData.Models.AttribureDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AttributeId");

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("AttributeId");

                    b.HasIndex("LanguageId");

                    b.ToTable("AttribureDescription");
                });

            modelBuilder.Entity("EcommerceData.Models.Attribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AttributeGroupId");

                    b.HasKey("Id");

                    b.HasIndex("AttributeGroupId");

                    b.ToTable("Attribute");
                });

            modelBuilder.Entity("EcommerceData.Models.AttributeGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SortOrder");

                    b.HasKey("Id");

                    b.ToTable("AttributeGroup");
                });

            modelBuilder.Entity("EcommerceData.Models.AttributeGroupDecription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("AttributeGroupDecription");
                });

            modelBuilder.Entity("EcommerceData.Models.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("Banner");
                });

            modelBuilder.Entity("EcommerceData.Models.BannerImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Link");

                    b.Property<int>("SortOrder");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("BannerImage");
                });

            modelBuilder.Entity("EcommerceData.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Api");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Option");

                    b.Property<string>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<int?>("RecurringId");

                    b.Property<string>("SessionId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("RecurringId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("EcommerceData.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Column");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Image");

                    b.Property<int>("ParentId");

                    b.Property<int>("SortOrder");

                    b.Property<bool>("Status");

                    b.Property<bool>("Top");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("EcommerceData.Models.CategoryDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<int?>("LanguageId");

                    b.Property<string>("MetaDesctiption");

                    b.Property<string>("MetaKeyWord");

                    b.Property<string>("MetaTitle");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LanguageId");

                    b.ToTable("CategoryDescription");
                });

            modelBuilder.Entity("EcommerceData.Models.CategoryFilter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<int?>("FilterId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FilterId");

                    b.ToTable("CategoryFilter");
                });

            modelBuilder.Entity("EcommerceData.Models.CategoryPath", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Level");

                    b.Property<int?>("PathId");

                    b.HasKey("Id");

                    b.HasIndex("PathId");

                    b.ToTable("CategoryPath");
                });

            modelBuilder.Entity("EcommerceData.Models.CategoryToLayout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LayoutId");

                    b.Property<int?>("StoreId");

                    b.HasKey("Id");

                    b.HasIndex("LayoutId");

                    b.HasIndex("StoreId");

                    b.ToTable("CategoryToLayout");
                });

            modelBuilder.Entity("EcommerceData.Models.CategoryToStore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("StoreId");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("CategoryToStore");
                });

            modelBuilder.Entity("EcommerceData.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressFormat");

                    b.Property<string>("IsoCode2");

                    b.Property<string>("IsoCode3");

                    b.Property<string>("Name");

                    b.Property<bool>("PostalCodeRequired");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("EcommerceData.Models.Coupon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateEnd");

                    b.Property<DateTime>("DateStart");

                    b.Property<decimal>("Discount");

                    b.Property<bool>("Logged");

                    b.Property<string>("Name");

                    b.Property<bool>("Shipping");

                    b.Property<bool>("Status");

                    b.Property<decimal>("Total");

                    b.Property<char>("Type");

                    b.Property<string>("UserCustomer");

                    b.Property<int>("UserTotal");

                    b.HasKey("Id");

                    b.ToTable("Coupon");
                });

            modelBuilder.Entity("EcommerceData.Models.CouponCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("CouponCategory");
                });

            modelBuilder.Entity("EcommerceData.Models.CouponHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<int?>("CouponId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<int?>("OrderId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CouponId");

                    b.HasIndex("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("CouponHistory");
                });

            modelBuilder.Entity("EcommerceData.Models.CouponProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CouponId");

                    b.Property<string>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("CouponId");

                    b.HasIndex("ProductId");

                    b.ToTable("CouponProduct");
                });

            modelBuilder.Entity("EcommerceData.Models.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("DateModified");

                    b.Property<char>("DecimalPlace");

                    b.Property<bool>("Status");

                    b.Property<string>("SymbolLeft");

                    b.Property<string>("SymbolRight");

                    b.Property<string>("Title");

                    b.Property<float>("Value");

                    b.HasKey("Id");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("EcommerceData.Models.CustomField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Location");

                    b.Property<int>("SortOrder");

                    b.Property<bool>("Status");

                    b.Property<string>("Type");

                    b.Property<string>("Validation");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("CustomField");
                });

            modelBuilder.Entity("EcommerceData.Models.CustomFieldDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CustomFieldId");

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CustomFieldId");

                    b.HasIndex("LanguageId");

                    b.ToTable("CustomFieldDescription");
                });

            modelBuilder.Entity("EcommerceData.Models.CustomFieldUserGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Required");

                    b.Property<int?>("UserGroupId");

                    b.HasKey("Id");

                    b.HasIndex("UserGroupId");

                    b.ToTable("CustomFieldUserGroup");
                });

            modelBuilder.Entity("EcommerceData.Models.CustomFieldValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CustomFieldId");

                    b.Property<int>("SortOrder");

                    b.HasKey("Id");

                    b.HasIndex("CustomFieldId");

                    b.ToTable("CustomFieldValue");
                });

            modelBuilder.Entity("EcommerceData.Models.CustomFieldValueDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CustomFieldId");

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CustomFieldId");

                    b.HasIndex("LanguageId");

                    b.ToTable("CustomFieldValueDescription");
                });

            modelBuilder.Entity("EcommerceData.Models.Description", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescriptionText");

                    b.Property<int?>("GroupId");

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("LanguageId");

                    b.ToTable("Description");
                });

            modelBuilder.Entity("EcommerceData.Models.Download", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("FileName");

                    b.HasKey("Id");

                    b.ToTable("Download");
                });

            modelBuilder.Entity("EcommerceData.Models.DownloadDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DownloadId");

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DownloadId");

                    b.HasIndex("LanguageId");

                    b.ToTable("DownloadDescription");
                });

            modelBuilder.Entity("EcommerceData.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<string>("Code");

                    b.Property<DateTime>("DateCreated");

                    b.Property<bool>("Status");

                    b.Property<string>("Trigger");

                    b.HasKey("Id");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("EcommerceData.Models.Extension", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Extension");
                });

            modelBuilder.Entity("EcommerceData.Models.Filter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("FilterGroupId");

                    b.Property<int>("SortOrder");

                    b.HasKey("Id");

                    b.HasIndex("FilterGroupId");

                    b.ToTable("Filter");
                });

            modelBuilder.Entity("EcommerceData.Models.FilterDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("FilterId");

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("FilterId");

                    b.HasIndex("LanguageId");

                    b.ToTable("FilterDescription");
                });

            modelBuilder.Entity("EcommerceData.Models.FilterGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SortOrder");

                    b.HasKey("Id");

                    b.ToTable("FilterGroup");
                });

            modelBuilder.Entity("EcommerceData.Models.FilterGroupDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("FilterGroupId");

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("FilterGroupId");

                    b.HasIndex("LanguageId");

                    b.ToTable("FilterGroupDescription");
                });

            modelBuilder.Entity("EcommerceData.Models.GeoZone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateUpdated");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("GeoZone");
                });

            modelBuilder.Entity("EcommerceData.Models.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("History");
                });

            modelBuilder.Entity("EcommerceData.Models.Information", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Bottom");

                    b.Property<int>("SortOrder");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("Information");
                });

            modelBuilder.Entity("EcommerceData.Models.InformationDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int?>("LanguageId");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeyword");

                    b.Property<string>("MetaTitle");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("InformationDescription");
                });

            modelBuilder.Entity("EcommerceData.Models.InformationToLayout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("InformationId");

                    b.Property<int?>("LayoutId");

                    b.Property<int?>("StoreId");

                    b.HasKey("Id");

                    b.HasIndex("InformationId");

                    b.HasIndex("LayoutId");

                    b.HasIndex("StoreId");

                    b.ToTable("InformationToLayout");
                });

            modelBuilder.Entity("EcommerceData.Models.InformationToStore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("InformationId");

                    b.Property<int?>("StoreId");

                    b.HasKey("Id");

                    b.HasIndex("InformationId");

                    b.HasIndex("StoreId");

                    b.ToTable("InformationToStore");
                });

            modelBuilder.Entity("EcommerceData.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Directory");

                    b.Property<string>("Image");

                    b.Property<string>("Locale");

                    b.Property<string>("Name");

                    b.Property<int>("SortOrder");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("EcommerceData.Models.Layout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Layout");
                });

            modelBuilder.Entity("EcommerceData.Models.LayoutModule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<int?>("LayoutId");

                    b.Property<string>("Position");

                    b.Property<int>("SortOrder");

                    b.HasKey("Id");

                    b.HasIndex("LayoutId");

                    b.ToTable("LayoutModule");
                });

            modelBuilder.Entity("EcommerceData.Models.LayoutRoute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LayoutId");

                    b.Property<string>("Route");

                    b.Property<int?>("StoreId");

                    b.HasKey("Id");

                    b.HasIndex("LayoutId");

                    b.HasIndex("StoreId");

                    b.ToTable("LayoutRoute");
                });

            modelBuilder.Entity("EcommerceData.Models.LengthClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Value");

                    b.HasKey("Id");

                    b.ToTable("LengthClass");
                });

            modelBuilder.Entity("EcommerceData.Models.LengthClassDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LanguageId");

                    b.Property<int?>("LengthClassId");

                    b.Property<string>("Title");

                    b.Property<string>("Unit");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("LengthClassId");

                    b.ToTable("LengthClassDescription");
                });

            modelBuilder.Entity("EcommerceData.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Comment");

                    b.Property<string>("Fax");

                    b.Property<string>("GeoCode");

                    b.Property<string>("Image");

                    b.Property<string>("Mobile");

                    b.Property<string>("Name");

                    b.Property<string>("Open");

                    b.Property<string>("Telephone");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("EcommerceData.Models.Manufacurer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<int>("SortOrder");

                    b.HasKey("Id");

                    b.ToTable("Manufacurer");
                });

            modelBuilder.Entity("EcommerceData.Models.ManufatureToStore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ManufacurerId");

                    b.Property<int?>("StoreId");

                    b.HasKey("Id");

                    b.HasIndex("ManufacurerId");

                    b.HasIndex("StoreId");

                    b.ToTable("ManufatureToStore");
                });

            modelBuilder.Entity("EcommerceData.Models.Marketing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Clicks");

                    b.Property<string>("Code");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Marketing");
                });

            modelBuilder.Entity("EcommerceData.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Link");

                    b.Property<int>("SortOrder");

                    b.Property<bool>("Status");

                    b.Property<int?>("StoreId");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("EcommerceData.Models.MenuDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LanguageId");

                    b.Property<int?>("MenuId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("MenuId");

                    b.ToTable("MenuDescription");
                });

            modelBuilder.Entity("EcommerceData.Models.Modification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Code");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Link");

                    b.Property<string>("Name");

                    b.Property<bool>("Status");

                    b.Property<string>("Version");

                    b.Property<string>("Xml");

                    b.HasKey("Id");

                    b.ToTable("Modification");
                });

            modelBuilder.Entity("EcommerceData.Models.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.Property<string>("Setting");

                    b.HasKey("Id");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("EcommerceData.Models.MunuModule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<int?>("MenuId");

                    b.Property<int>("SortOrder");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("MunuModule");
                });

            modelBuilder.Entity("EcommerceData.Models.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SortOrder");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Option");
                });

            modelBuilder.Entity("EcommerceData.Models.OptionDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Name");

                    b.Property<int?>("OptionId");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("OptionId");

                    b.ToTable("OptionDescription");
                });

            modelBuilder.Entity("EcommerceData.Models.OptionValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.Property<int?>("OptionId");

                    b.Property<int>("SortOrder");

                    b.HasKey("Id");

                    b.HasIndex("OptionId");

                    b.ToTable("OptionValue");
                });

            modelBuilder.Entity("EcommerceData.Models.OptionValueDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Name");

                    b.Property<int?>("OptionId");

                    b.Property<int?>("OptionValueId");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("OptionId");

                    b.HasIndex("OptionValueId");

                    b.ToTable("OptionValueDescription");
                });

            modelBuilder.Entity("EcommerceData.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AffiliateId");

                    b.Property<string>("Comment");

                    b.Property<decimal>("Commission");

                    b.Property<int?>("CurrencyId");

                    b.Property<string>("CurrencyValue");

                    b.Property<string>("CustomFild");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Email");

                    b.Property<string>("Fax");

                    b.Property<string>("FirstName");

                    b.Property<int?>("GroupId");

                    b.Property<int>("InvoiceNo");

                    b.Property<string>("InvoicePrefix");

                    b.Property<int?>("LanguageId");

                    b.Property<string>("LastName");

                    b.Property<int?>("MarketingId");

                    b.Property<int?>("OrderStatusId");

                    b.Property<string>("PaymentAddress1");

                    b.Property<string>("PaymentAddress2");

                    b.Property<string>("PaymentAddressFormat");

                    b.Property<string>("PaymentCity");

                    b.Property<string>("PaymentCode");

                    b.Property<string>("PaymentCompany");

                    b.Property<int?>("PaymentCountryId");

                    b.Property<string>("PaymentCountryName");

                    b.Property<string>("PaymentCustomField");

                    b.Property<string>("PaymentFirstName");

                    b.Property<string>("PaymentLastName");

                    b.Property<string>("PaymentMethod");

                    b.Property<string>("PaymentPostalcode");

                    b.Property<int?>("PaymentZoneId");

                    b.Property<string>("PaymentZoneName");

                    b.Property<string>("ShippingAddress1");

                    b.Property<string>("ShippingAddress2");

                    b.Property<string>("ShippingAddressFormat");

                    b.Property<string>("ShippingCity");

                    b.Property<string>("ShippingCode");

                    b.Property<string>("ShippingCompany");

                    b.Property<int?>("ShippingCountryId");

                    b.Property<string>("ShippingCountryName");

                    b.Property<string>("ShippingCustomField");

                    b.Property<string>("ShippingFirstName");

                    b.Property<string>("ShippingLastName");

                    b.Property<string>("ShippingMethod");

                    b.Property<string>("ShippingPostalCode");

                    b.Property<int?>("ShippingZoneId");

                    b.Property<string>("ShippingZoneName");

                    b.Property<int?>("StoreId");

                    b.Property<string>("StoreName");

                    b.Property<string>("StoreUrl");

                    b.Property<string>("Telephone");

                    b.Property<decimal>("Total");

                    b.Property<string>("Tracking");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AffiliateId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("GroupId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("MarketingId");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("PaymentCountryId");

                    b.HasIndex("PaymentZoneId");

                    b.HasIndex("ShippingCountryId");

                    b.HasIndex("ShippingZoneId");

                    b.HasIndex("StoreId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("EcommerceData.Models.OrderCustomField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CustomFieldId");

                    b.Property<int?>("CustomFieldValueId");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<int?>("OrderId");

                    b.Property<string>("Type");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CustomFieldId");

                    b.HasIndex("CustomFieldValueId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderCustomField");
                });

            modelBuilder.Entity("EcommerceData.Models.OrderHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<DateTime>("DateCreated");

                    b.Property<bool>("Notify");

                    b.Property<int?>("OrderId");

                    b.Property<int?>("OrderStatusId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("OrderStatusId");

                    b.ToTable("OrderHistory");
                });

            modelBuilder.Entity("EcommerceData.Models.OrderOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("OrderId");

                    b.Property<int?>("OrderProductId");

                    b.Property<int?>("ProductOptionId");

                    b.Property<int?>("ProductOptionValueId");

                    b.Property<string>("Type");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("OrderProductId");

                    b.HasIndex("ProductOptionId");

                    b.HasIndex("ProductOptionValueId");

                    b.ToTable("OrderOption");
                });

            modelBuilder.Entity("EcommerceData.Models.OrderProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Model");

                    b.Property<string>("Name");

                    b.Property<int?>("OrderId");

                    b.Property<decimal>("Price");

                    b.Property<string>("ProductId");

                    b.Property<int>("Reward");

                    b.Property<decimal>("Tax");

                    b.Property<decimal>("Total");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("EcommerceData.Models.OrderRecurring", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<int?>("OrderId");

                    b.Property<string>("ProdcutName");

                    b.Property<string>("ProductId");

                    b.Property<int>("ProductQuantity");

                    b.Property<short>("RecurringCycle");

                    b.Property<string>("RecurringDescription");

                    b.Property<short>("RecurringDuration");

                    b.Property<string>("RecurringFrequency");

                    b.Property<int?>("RecurringId");

                    b.Property<string>("RecurringName");

                    b.Property<short>("RecurringPrice");

                    b.Property<string>("Reference");

                    b.Property<string>("Status");

                    b.Property<bool>("Trial");

                    b.Property<short>("TrialCycle");

                    b.Property<short>("TrialDuration");

                    b.Property<string>("TrialFrequency");

                    b.Property<decimal>("TrialPrice");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("RecurringId");

                    b.ToTable("OrderRecurring");
                });

            modelBuilder.Entity("EcommerceData.Models.OrderRecurringTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("DateCreated");

                    b.Property<int?>("OrderRecurringId");

                    b.Property<string>("Reference");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("OrderRecurringId");

                    b.ToTable("OrderRecurringTransaction");
                });

            modelBuilder.Entity("EcommerceData.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("EcommerceData.Models.OrderTotal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<int?>("OrderId");

                    b.Property<int>("SortOrder");

                    b.Property<string>("Title");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderTotal");
                });

            modelBuilder.Entity("EcommerceData.Models.OrderVoucher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.Property<string>("FromEmail");

                    b.Property<string>("FromName");

                    b.Property<string>("Message");

                    b.Property<int?>("OrderId");

                    b.Property<string>("ToEmail");

                    b.Property<string>("ToName");

                    b.Property<int?>("VoucherId");

                    b.Property<int?>("VoucherThemeId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("VoucherId");

                    b.HasIndex("VoucherThemeId");

                    b.ToTable("OrderVoucher");
                });

            modelBuilder.Entity("EcommerceData.Models.Path", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Path");
                });

            modelBuilder.Entity("EcommerceData.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset?>("DateAvailable");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateUpdated");

                    b.Property<string>("Ean");

                    b.Property<string>("Image");

                    b.Property<string>("Isbn");

                    b.Property<string>("Jan");

                    b.Property<decimal>("Length");

                    b.Property<int?>("LengthClassId");

                    b.Property<string>("Location");

                    b.Property<int?>("ManufacurerId");

                    b.Property<int>("Minimum");

                    b.Property<int>("Model");

                    b.Property<string>("Mpn");

                    b.Property<int>("Points");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<bool>("Shipping");

                    b.Property<string>("Sku");

                    b.Property<bool>("Status");

                    b.Property<int>("StockOrder");

                    b.Property<int?>("StockStatusId");

                    b.Property<bool>("Subtract");

                    b.Property<int?>("TaxClassId");

                    b.Property<string>("Upc");

                    b.Property<int>("Viewd");

                    b.Property<decimal>("Weight");

                    b.Property<int?>("WeightClassId");

                    b.HasKey("Id");

                    b.HasIndex("LengthClassId");

                    b.HasIndex("ManufacurerId");

                    b.HasIndex("StockStatusId");

                    b.HasIndex("TaxClassId");

                    b.HasIndex("WeightClassId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AttributeId");

                    b.Property<int?>("LanguageId");

                    b.Property<string>("ProductId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("AttributeId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductAttribute");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int?>("LanguageId");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeyword");

                    b.Property<string>("MetaTitle");

                    b.Property<string>("Name");

                    b.Property<string>("ProductId");

                    b.Property<string>("Tag");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDescription");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductDiscount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProductId");

                    b.Property<int?>("UserGroupId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserGroupId");

                    b.ToTable("ProductDiscount");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductFilter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("FilterId");

                    b.HasKey("Id");

                    b.HasIndex("FilterId");

                    b.ToTable("ProductFilter");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.Property<string>("ProductId");

                    b.Property<int>("SortOrder");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImage");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OptionId");

                    b.Property<string>("ProductId");

                    b.Property<bool>("Required");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("OptionId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductOption");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductOptionValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OptionId");

                    b.Property<int?>("OptionValueId");

                    b.Property<int>("Points");

                    b.Property<string>("PointsPrefix");

                    b.Property<decimal>("Price");

                    b.Property<string>("PricePrefix");

                    b.Property<string>("ProductId");

                    b.Property<int?>("ProductOptionId");

                    b.Property<int>("Quantity");

                    b.Property<bool>("Subtract");

                    b.Property<decimal>("Weight");

                    b.Property<string>("WeightPrefix");

                    b.HasKey("Id");

                    b.HasIndex("OptionId");

                    b.HasIndex("OptionValueId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductOptionId");

                    b.ToTable("ProductOptionValue");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductRecurring", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProductId");

                    b.Property<int?>("RecurringId");

                    b.Property<int?>("UserGroupId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("RecurringId");

                    b.HasIndex("UserGroupId");

                    b.ToTable("ProductRecurring");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductRelated", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProductId");

                    b.Property<int?>("RelatedId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("RelatedId");

                    b.ToTable("ProductRelated");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductReward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Points");

                    b.Property<string>("ProductId");

                    b.Property<int?>("UserGroupId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserGroupId");

                    b.ToTable("ProductReward");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductSpecial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateEnd");

                    b.Property<DateTime>("DateStart");

                    b.Property<decimal>("Price");

                    b.Property<int>("Priority");

                    b.Property<string>("ProductId");

                    b.Property<int?>("UserGroupId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserGroupId");

                    b.ToTable("ProductSpecial");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductToCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<string>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductToCategory");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductToDownload", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<string>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductToDownload");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductToLayout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LayoutId");

                    b.Property<int?>("StoreId");

                    b.HasKey("Id");

                    b.HasIndex("LayoutId");

                    b.HasIndex("StoreId");

                    b.ToTable("ProductToLayout");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductToStore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProductId");

                    b.Property<int?>("StoreId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("StoreId");

                    b.ToTable("ProductToStore");
                });

            modelBuilder.Entity("EcommerceData.Models.Recurring", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Frequency");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Recurring");
                });

            modelBuilder.Entity("EcommerceData.Models.Related", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Related");
                });

            modelBuilder.Entity("EcommerceData.Models.Return", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("Comment");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<DateTime>("DateOrdered");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Mobile");

                    b.Property<string>("Model");

                    b.Property<bool>("Opened");

                    b.Property<int?>("OrderId");

                    b.Property<string>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<string>("RProduct");

                    b.Property<int?>("ReturnAcionId");

                    b.Property<int?>("ReturnReasonId");

                    b.Property<int?>("ReturnStatusId");

                    b.Property<string>("Telephone");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ReturnAcionId");

                    b.HasIndex("ReturnReasonId");

                    b.HasIndex("ReturnStatusId");

                    b.ToTable("Return");
                });

            modelBuilder.Entity("EcommerceData.Models.ReturnAcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("ReturnAcion");
                });

            modelBuilder.Entity("EcommerceData.Models.ReturnHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<int>("Notify");

                    b.Property<int?>("ReturnId");

                    b.Property<int?>("ReturnStatusId");

                    b.HasKey("Id");

                    b.HasIndex("ReturnId");

                    b.HasIndex("ReturnStatusId");

                    b.ToTable("ReturnHistory");
                });

            modelBuilder.Entity("EcommerceData.Models.ReturnReason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("ReturnReason");
                });

            modelBuilder.Entity("EcommerceData.Models.ReturnStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("ReturnStatus");
                });

            modelBuilder.Entity("EcommerceData.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("Author");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("ProductId");

                    b.Property<int>("Status");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ProductId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("EcommerceData.Models.Reward", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<int?>("OrderId");

                    b.Property<int>("Points");

                    b.Property<string>("UserId");

                    b.HasKey("id");

                    b.HasIndex("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Reward");
                });

            modelBuilder.Entity("EcommerceData.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Key");

                    b.Property<bool>("Serialized");

                    b.Property<int?>("StoreId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("Setting");
                });

            modelBuilder.Entity("EcommerceData.Models.StockStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("StockStatus");
                });

            modelBuilder.Entity("EcommerceData.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Ssl");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("EcommerceData.Models.TaxClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateUpdated");

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("TaxClass");
                });

            modelBuilder.Entity("EcommerceData.Models.TaxRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<int?>("GeoZoneId");

                    b.Property<string>("Name");

                    b.Property<decimal>("Rate");

                    b.Property<char>("Type");

                    b.HasKey("Id");

                    b.HasIndex("GeoZoneId");

                    b.ToTable("TaxRate");
                });

            modelBuilder.Entity("EcommerceData.Models.TaxRateToUserGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("TaxRateId");

                    b.Property<int?>("UserGroupId");

                    b.HasKey("Id");

                    b.HasIndex("TaxRateId");

                    b.HasIndex("UserGroupId");

                    b.ToTable("TaxRateToUserGroup");
                });

            modelBuilder.Entity("EcommerceData.Models.TaxRule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Based");

                    b.Property<int>("Priority");

                    b.Property<int?>("TaxClassId");

                    b.Property<int?>("TaxRateId");

                    b.HasKey("Id");

                    b.HasIndex("TaxClassId");

                    b.HasIndex("TaxRateId");

                    b.ToTable("TaxRule");
                });

            modelBuilder.Entity("EcommerceData.Models.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Route");

                    b.Property<int?>("StoreId");

                    b.Property<string>("code");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("Theme");
                });

            modelBuilder.Entity("EcommerceData.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<int?>("OrderId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("EcommerceData.Models.Upload", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("FileName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Upload");
                });

            modelBuilder.Entity("EcommerceData.Models.UrlAlias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("KeyWord");

                    b.Property<string>("Query");

                    b.HasKey("Id");

                    b.ToTable("UrlAlias");
                });

            modelBuilder.Entity("EcommerceData.Models.UserActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Data");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Key");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserActivity");
                });

            modelBuilder.Entity("EcommerceData.Models.UserGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Approvall");

                    b.Property<int>("ShortOrder");

                    b.HasKey("Id");

                    b.ToTable("UserGroup");
                });

            modelBuilder.Entity("EcommerceData.Models.UserGroupDecription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Name");

                    b.Property<int?>("UserGroupId");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("UserGroupId");

                    b.ToTable("UserGroupDecription");
                });

            modelBuilder.Entity("EcommerceData.Models.UserHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("Comment");

                    b.Property<DateTime>("DateCreated");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("UserHistory");
                });

            modelBuilder.Entity("EcommerceData.Models.UserOnline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Referer");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("UserOnline");
                });

            modelBuilder.Entity("EcommerceData.Models.UserReward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<int?>("OrderId");

                    b.Property<int>("Points");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("OrderId");

                    b.ToTable("UserReward");
                });

            modelBuilder.Entity("EcommerceData.Models.UserSearch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<int?>("CategoryId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<bool>("Decription");

                    b.Property<string>("Keyword");

                    b.Property<int?>("LanguageId");

                    b.Property<int>("Products");

                    b.Property<int?>("StoreId");

                    b.Property<bool>("SubCategory");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("StoreId");

                    b.ToTable("UserSearch");
                });

            modelBuilder.Entity("EcommerceData.Models.UserTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("ApplicationUserId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<int?>("OrderId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("OrderId");

                    b.ToTable("UserTransaction");
                });

            modelBuilder.Entity("EcommerceData.Models.UserWishlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("UserWishlist");
                });

            modelBuilder.Entity("EcommerceData.Models.Voucher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("Code");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("FormName");

                    b.Property<string>("FromEmail");

                    b.Property<string>("Message");

                    b.Property<int?>("OrderId");

                    b.Property<bool>("Status");

                    b.Property<string>("ToEmail");

                    b.Property<string>("ToName");

                    b.Property<int?>("VoucherThemeId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("VoucherThemeId");

                    b.ToTable("Voucher");
                });

            modelBuilder.Entity("EcommerceData.Models.VoucherHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("DateCreated");

                    b.Property<int?>("OrderId");

                    b.Property<int?>("VoucherId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("VoucherId");

                    b.ToTable("VoucherHistory");
                });

            modelBuilder.Entity("EcommerceData.Models.VoucherThemDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("VoucherThemDescription");
                });

            modelBuilder.Entity("EcommerceData.Models.VoucherTheme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.HasKey("Id");

                    b.ToTable("VoucherTheme");
                });

            modelBuilder.Entity("EcommerceData.Models.WeightClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("WeightClass");
                });

            modelBuilder.Entity("EcommerceData.Models.WeightClassDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LanguageId");

                    b.Property<string>("Title");

                    b.Property<string>("Unit");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("WeightClassDescription");
                });

            modelBuilder.Entity("EcommerceData.Models.Zone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<int?>("CountryId");

                    b.Property<string>("Name");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Zone");
                });

            modelBuilder.Entity("EcommerceData.Models.ZoneToGeoLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CountryId");

                    b.Property<int?>("GeoZoneId");

                    b.Property<int?>("ZoneId");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("GeoZoneId");

                    b.HasIndex("ZoneId");

                    b.ToTable("ZoneToGeoLocation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EcommerceData.Models.Address", b =>
                {
                    b.HasOne("EcommerceData.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Address")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("EcommerceData.Models.Zone", "Zone")
                        .WithMany()
                        .HasForeignKey("ZoneId");
                });

            modelBuilder.Entity("EcommerceData.Models.Affiliate", b =>
                {
                    b.HasOne("EcommerceData.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("EcommerceData.Models.AffiliateActivity", b =>
                {
                    b.HasOne("EcommerceData.Models.Affiliate", "Affiliate")
                        .WithMany()
                        .HasForeignKey("AffiliateId");
                });

            modelBuilder.Entity("EcommerceData.Models.ApplicationUser", b =>
                {
                    b.HasOne("EcommerceData.Models.UserGroup", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");

                    b.HasOne("EcommerceData.Models.Language", "Laguage")
                        .WithMany()
                        .HasForeignKey("LaguageId");

                    b.HasOne("EcommerceData.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("EcommerceData.Models.AttribureDescription", b =>
                {
                    b.HasOne("EcommerceData.Models.Attribute", "Attribute")
                        .WithMany()
                        .HasForeignKey("AttributeId");

                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("EcommerceData.Models.Attribute", b =>
                {
                    b.HasOne("EcommerceData.Models.AttributeGroup", "AttributeGroup")
                        .WithMany()
                        .HasForeignKey("AttributeGroupId");
                });

            modelBuilder.Entity("EcommerceData.Models.AttributeGroupDecription", b =>
                {
                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("EcommerceData.Models.BannerImage", b =>
                {
                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("EcommerceData.Models.Cart", b =>
                {
                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("EcommerceData.Models.Recurring", "Recurring")
                        .WithMany()
                        .HasForeignKey("RecurringId");
                });

            modelBuilder.Entity("EcommerceData.Models.CategoryDescription", b =>
                {
                    b.HasOne("EcommerceData.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("EcommerceData.Models.CategoryFilter", b =>
                {
                    b.HasOne("EcommerceData.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("EcommerceData.Models.Filter", "Filter")
                        .WithMany()
                        .HasForeignKey("FilterId");
                });

            modelBuilder.Entity("EcommerceData.Models.CategoryPath", b =>
                {
                    b.HasOne("EcommerceData.Models.Path", "Path")
                        .WithMany()
                        .HasForeignKey("PathId");
                });

            modelBuilder.Entity("EcommerceData.Models.CategoryToLayout", b =>
                {
                    b.HasOne("EcommerceData.Models.Layout", "Layout")
                        .WithMany()
                        .HasForeignKey("LayoutId");

                    b.HasOne("EcommerceData.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("EcommerceData.Models.CategoryToStore", b =>
                {
                    b.HasOne("EcommerceData.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("EcommerceData.Models.CouponCategory", b =>
                {
                    b.HasOne("EcommerceData.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("EcommerceData.Models.CouponHistory", b =>
                {
                    b.HasOne("EcommerceData.Models.Coupon", "Coupon")
                        .WithMany()
                        .HasForeignKey("CouponId");

                    b.HasOne("EcommerceData.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("EcommerceData.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EcommerceData.Models.CouponProduct", b =>
                {
                    b.HasOne("EcommerceData.Models.Coupon", "Coupon")
                        .WithMany()
                        .HasForeignKey("CouponId");

                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("EcommerceData.Models.CustomFieldDescription", b =>
                {
                    b.HasOne("EcommerceData.Models.CustomField", "CustomField")
                        .WithMany()
                        .HasForeignKey("CustomFieldId");

                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("EcommerceData.Models.CustomFieldUserGroup", b =>
                {
                    b.HasOne("EcommerceData.Models.UserGroup", "UserGroup")
                        .WithMany()
                        .HasForeignKey("UserGroupId");
                });

            modelBuilder.Entity("EcommerceData.Models.CustomFieldValue", b =>
                {
                    b.HasOne("EcommerceData.Models.CustomField", "CustomField")
                        .WithMany()
                        .HasForeignKey("CustomFieldId");
                });

            modelBuilder.Entity("EcommerceData.Models.CustomFieldValueDescription", b =>
                {
                    b.HasOne("EcommerceData.Models.CustomField", "CustomField")
                        .WithMany()
                        .HasForeignKey("CustomFieldId");

                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("EcommerceData.Models.Description", b =>
                {
                    b.HasOne("EcommerceData.Models.UserGroup", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");

                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("EcommerceData.Models.DownloadDescription", b =>
                {
                    b.HasOne("EcommerceData.Models.Download", "Download")
                        .WithMany()
                        .HasForeignKey("DownloadId");

                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("EcommerceData.Models.Filter", b =>
                {
                    b.HasOne("EcommerceData.Models.FilterGroup", "FilterGroup")
                        .WithMany()
                        .HasForeignKey("FilterGroupId");
                });

            modelBuilder.Entity("EcommerceData.Models.FilterDescription", b =>
                {
                    b.HasOne("EcommerceData.Models.Filter", "Filter")
                        .WithMany()
                        .HasForeignKey("FilterId");

                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("EcommerceData.Models.FilterGroupDescription", b =>
                {
                    b.HasOne("EcommerceData.Models.FilterGroup", "FilterGroup")
                        .WithMany()
                        .HasForeignKey("FilterGroupId");

                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("EcommerceData.Models.History", b =>
                {
                    b.HasOne("EcommerceData.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EcommerceData.Models.InformationDescription", b =>
                {
                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("EcommerceData.Models.InformationToLayout", b =>
                {
                    b.HasOne("EcommerceData.Models.Information", "Information")
                        .WithMany()
                        .HasForeignKey("InformationId");

                    b.HasOne("EcommerceData.Models.Layout", "Layout")
                        .WithMany()
                        .HasForeignKey("LayoutId");

                    b.HasOne("EcommerceData.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("EcommerceData.Models.InformationToStore", b =>
                {
                    b.HasOne("EcommerceData.Models.Information", "Information")
                        .WithMany()
                        .HasForeignKey("InformationId");

                    b.HasOne("EcommerceData.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("EcommerceData.Models.LayoutModule", b =>
                {
                    b.HasOne("EcommerceData.Models.Layout", "Layout")
                        .WithMany()
                        .HasForeignKey("LayoutId");
                });

            modelBuilder.Entity("EcommerceData.Models.LayoutRoute", b =>
                {
                    b.HasOne("EcommerceData.Models.Layout", "Layout")
                        .WithMany()
                        .HasForeignKey("LayoutId");

                    b.HasOne("EcommerceData.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("EcommerceData.Models.LengthClassDescription", b =>
                {
                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");

                    b.HasOne("EcommerceData.Models.LengthClass", "LengthClass")
                        .WithMany()
                        .HasForeignKey("LengthClassId");
                });

            modelBuilder.Entity("EcommerceData.Models.ManufatureToStore", b =>
                {
                    b.HasOne("EcommerceData.Models.Manufacurer", "Manufacurer")
                        .WithMany()
                        .HasForeignKey("ManufacurerId");

                    b.HasOne("EcommerceData.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("EcommerceData.Models.Menu", b =>
                {
                    b.HasOne("EcommerceData.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("EcommerceData.Models.MenuDescription", b =>
                {
                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");

                    b.HasOne("EcommerceData.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId");
                });

            modelBuilder.Entity("EcommerceData.Models.MunuModule", b =>
                {
                    b.HasOne("EcommerceData.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId");
                });

            modelBuilder.Entity("EcommerceData.Models.OptionDescription", b =>
                {
                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");

                    b.HasOne("EcommerceData.Models.Option", "Option")
                        .WithMany()
                        .HasForeignKey("OptionId");
                });

            modelBuilder.Entity("EcommerceData.Models.OptionValue", b =>
                {
                    b.HasOne("EcommerceData.Models.Option", "Option")
                        .WithMany()
                        .HasForeignKey("OptionId");
                });

            modelBuilder.Entity("EcommerceData.Models.OptionValueDescription", b =>
                {
                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");

                    b.HasOne("EcommerceData.Models.Option", "Option")
                        .WithMany()
                        .HasForeignKey("OptionId");

                    b.HasOne("EcommerceData.Models.OptionValue", "OptionValue")
                        .WithMany()
                        .HasForeignKey("OptionValueId");
                });

            modelBuilder.Entity("EcommerceData.Models.Order", b =>
                {
                    b.HasOne("EcommerceData.Models.Affiliate", "Affiliate")
                        .WithMany()
                        .HasForeignKey("AffiliateId");

                    b.HasOne("EcommerceData.Models.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");

                    b.HasOne("EcommerceData.Models.UserGroup", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");

                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");

                    b.HasOne("EcommerceData.Models.Marketing", "Marketing")
                        .WithMany()
                        .HasForeignKey("MarketingId");

                    b.HasOne("EcommerceData.Models.OrderStatus", "OrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderStatusId");

                    b.HasOne("EcommerceData.Models.Country", "PaymentCountry")
                        .WithMany()
                        .HasForeignKey("PaymentCountryId");

                    b.HasOne("EcommerceData.Models.Zone", "PaymentZone")
                        .WithMany()
                        .HasForeignKey("PaymentZoneId");

                    b.HasOne("EcommerceData.Models.Country", "ShippingCountry")
                        .WithMany()
                        .HasForeignKey("ShippingCountryId");

                    b.HasOne("EcommerceData.Models.Zone", "ShippingZone")
                        .WithMany()
                        .HasForeignKey("ShippingZoneId");

                    b.HasOne("EcommerceData.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");

                    b.HasOne("EcommerceData.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EcommerceData.Models.OrderCustomField", b =>
                {
                    b.HasOne("EcommerceData.Models.CustomField", "CustomField")
                        .WithMany()
                        .HasForeignKey("CustomFieldId");

                    b.HasOne("EcommerceData.Models.CustomFieldValue", "CustomFieldValue")
                        .WithMany()
                        .HasForeignKey("CustomFieldValueId");

                    b.HasOne("EcommerceData.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("EcommerceData.Models.OrderHistory", b =>
                {
                    b.HasOne("EcommerceData.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("EcommerceData.Models.OrderStatus", "OrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderStatusId");
                });

            modelBuilder.Entity("EcommerceData.Models.OrderOption", b =>
                {
                    b.HasOne("EcommerceData.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("EcommerceData.Models.OrderProduct", "OrderProduct")
                        .WithMany()
                        .HasForeignKey("OrderProductId");

                    b.HasOne("EcommerceData.Models.ProductOption", "ProductOption")
                        .WithMany()
                        .HasForeignKey("ProductOptionId");

                    b.HasOne("EcommerceData.Models.ProductOptionValue", "ProductOptionValue")
                        .WithMany()
                        .HasForeignKey("ProductOptionValueId");
                });

            modelBuilder.Entity("EcommerceData.Models.OrderProduct", b =>
                {
                    b.HasOne("EcommerceData.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("EcommerceData.Models.OrderRecurring", b =>
                {
                    b.HasOne("EcommerceData.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("EcommerceData.Models.Recurring", "Recurring")
                        .WithMany()
                        .HasForeignKey("RecurringId");
                });

            modelBuilder.Entity("EcommerceData.Models.OrderRecurringTransaction", b =>
                {
                    b.HasOne("EcommerceData.Models.OrderRecurring", "OrderRecurring")
                        .WithMany()
                        .HasForeignKey("OrderRecurringId");
                });

            modelBuilder.Entity("EcommerceData.Models.OrderStatus", b =>
                {
                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("EcommerceData.Models.OrderTotal", b =>
                {
                    b.HasOne("EcommerceData.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("EcommerceData.Models.OrderVoucher", b =>
                {
                    b.HasOne("EcommerceData.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("EcommerceData.Models.Voucher", "Voucher")
                        .WithMany()
                        .HasForeignKey("VoucherId");

                    b.HasOne("EcommerceData.Models.VoucherTheme", "VoucherTheme")
                        .WithMany()
                        .HasForeignKey("VoucherThemeId");
                });

            modelBuilder.Entity("EcommerceData.Models.Product", b =>
                {
                    b.HasOne("EcommerceData.Models.LengthClass", "LengthClass")
                        .WithMany()
                        .HasForeignKey("LengthClassId");

                    b.HasOne("EcommerceData.Models.Manufacurer", "Manufacurer")
                        .WithMany()
                        .HasForeignKey("ManufacurerId");

                    b.HasOne("EcommerceData.Models.StockStatus", "StockStatus")
                        .WithMany()
                        .HasForeignKey("StockStatusId");

                    b.HasOne("EcommerceData.Models.TaxClass", "TaxClass")
                        .WithMany()
                        .HasForeignKey("TaxClassId");

                    b.HasOne("EcommerceData.Models.WeightClass", "WeightClass")
                        .WithMany()
                        .HasForeignKey("WeightClassId");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductAttribute", b =>
                {
                    b.HasOne("EcommerceData.Models.Attribute", "Attribute")
                        .WithMany()
                        .HasForeignKey("AttributeId");

                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");

                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductDescription", b =>
                {
                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");

                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductDiscount", b =>
                {
                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("EcommerceData.Models.UserGroup", "UserGroup")
                        .WithMany()
                        .HasForeignKey("UserGroupId");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductFilter", b =>
                {
                    b.HasOne("EcommerceData.Models.Filter", "Filter")
                        .WithMany()
                        .HasForeignKey("FilterId");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductImage", b =>
                {
                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductOption", b =>
                {
                    b.HasOne("EcommerceData.Models.Option", "Option")
                        .WithMany()
                        .HasForeignKey("OptionId");

                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductOptionValue", b =>
                {
                    b.HasOne("EcommerceData.Models.Option", "Option")
                        .WithMany()
                        .HasForeignKey("OptionId");

                    b.HasOne("EcommerceData.Models.OptionValue", "OptionValue")
                        .WithMany()
                        .HasForeignKey("OptionValueId");

                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("EcommerceData.Models.ProductOption", "ProductOption")
                        .WithMany()
                        .HasForeignKey("ProductOptionId");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductRecurring", b =>
                {
                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("EcommerceData.Models.Recurring", "Recurring")
                        .WithMany()
                        .HasForeignKey("RecurringId");

                    b.HasOne("EcommerceData.Models.UserGroup", "UserGroup")
                        .WithMany()
                        .HasForeignKey("UserGroupId");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductRelated", b =>
                {
                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("EcommerceData.Models.Related", "Related")
                        .WithMany()
                        .HasForeignKey("RelatedId");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductReward", b =>
                {
                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("EcommerceData.Models.UserGroup", "UserGroup")
                        .WithMany()
                        .HasForeignKey("UserGroupId");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductSpecial", b =>
                {
                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("EcommerceData.Models.UserGroup", "UserGroup")
                        .WithMany()
                        .HasForeignKey("UserGroupId");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductToCategory", b =>
                {
                    b.HasOne("EcommerceData.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductToDownload", b =>
                {
                    b.HasOne("EcommerceData.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductToLayout", b =>
                {
                    b.HasOne("EcommerceData.Models.Layout", "Layout")
                        .WithMany()
                        .HasForeignKey("LayoutId");

                    b.HasOne("EcommerceData.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("EcommerceData.Models.ProductToStore", b =>
                {
                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("EcommerceData.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("EcommerceData.Models.Return", b =>
                {
                    b.HasOne("EcommerceData.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("EcommerceData.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("EcommerceData.Models.ReturnAcion", "ReturnAcion")
                        .WithMany()
                        .HasForeignKey("ReturnAcionId");

                    b.HasOne("EcommerceData.Models.ReturnReason", "ReturnReason")
                        .WithMany()
                        .HasForeignKey("ReturnReasonId");

                    b.HasOne("EcommerceData.Models.ReturnStatus", "ReturnStatus")
                        .WithMany()
                        .HasForeignKey("ReturnStatusId");
                });

            modelBuilder.Entity("EcommerceData.Models.ReturnAcion", b =>
                {
                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("EcommerceData.Models.ReturnHistory", b =>
                {
                    b.HasOne("EcommerceData.Models.Return", "Return")
                        .WithMany()
                        .HasForeignKey("ReturnId");

                    b.HasOne("EcommerceData.Models.ReturnStatus", "ReturnStatus")
                        .WithMany()
                        .HasForeignKey("ReturnStatusId");
                });

            modelBuilder.Entity("EcommerceData.Models.ReturnReason", b =>
                {
                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("EcommerceData.Models.ReturnStatus", b =>
                {
                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("EcommerceData.Models.Review", b =>
                {
                    b.HasOne("EcommerceData.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("EcommerceData.Models.Reward", b =>
                {
                    b.HasOne("EcommerceData.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("EcommerceData.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EcommerceData.Models.Setting", b =>
                {
                    b.HasOne("EcommerceData.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("EcommerceData.Models.StockStatus", b =>
                {
                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("EcommerceData.Models.TaxRate", b =>
                {
                    b.HasOne("EcommerceData.Models.GeoZone", "GeoZone")
                        .WithMany()
                        .HasForeignKey("GeoZoneId");
                });

            modelBuilder.Entity("EcommerceData.Models.TaxRateToUserGroup", b =>
                {
                    b.HasOne("EcommerceData.Models.TaxRate", "TaxRate")
                        .WithMany()
                        .HasForeignKey("TaxRateId");

                    b.HasOne("EcommerceData.Models.UserGroup", "UserGroup")
                        .WithMany()
                        .HasForeignKey("UserGroupId");
                });

            modelBuilder.Entity("EcommerceData.Models.TaxRule", b =>
                {
                    b.HasOne("EcommerceData.Models.TaxClass", "TaxClass")
                        .WithMany()
                        .HasForeignKey("TaxClassId");

                    b.HasOne("EcommerceData.Models.TaxRate", "TaxRate")
                        .WithMany()
                        .HasForeignKey("TaxRateId");
                });

            modelBuilder.Entity("EcommerceData.Models.Theme", b =>
                {
                    b.HasOne("EcommerceData.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("EcommerceData.Models.Transaction", b =>
                {
                    b.HasOne("EcommerceData.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("EcommerceData.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EcommerceData.Models.UserActivity", b =>
                {
                    b.HasOne("EcommerceData.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EcommerceData.Models.UserGroupDecription", b =>
                {
                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");

                    b.HasOne("EcommerceData.Models.UserGroup", "UserGroup")
                        .WithMany()
                        .HasForeignKey("UserGroupId");
                });

            modelBuilder.Entity("EcommerceData.Models.UserHistory", b =>
                {
                    b.HasOne("EcommerceData.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("EcommerceData.Models.UserOnline", b =>
                {
                    b.HasOne("EcommerceData.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("EcommerceData.Models.UserReward", b =>
                {
                    b.HasOne("EcommerceData.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("EcommerceData.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("EcommerceData.Models.UserSearch", b =>
                {
                    b.HasOne("EcommerceData.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("EcommerceData.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");

                    b.HasOne("EcommerceData.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("EcommerceData.Models.UserTransaction", b =>
                {
                    b.HasOne("EcommerceData.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("EcommerceData.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("EcommerceData.Models.UserWishlist", b =>
                {
                    b.HasOne("EcommerceData.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("EcommerceData.Models.Voucher", b =>
                {
                    b.HasOne("EcommerceData.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("EcommerceData.Models.VoucherTheme", "VoucherTheme")
                        .WithMany()
                        .HasForeignKey("VoucherThemeId");
                });

            modelBuilder.Entity("EcommerceData.Models.VoucherHistory", b =>
                {
                    b.HasOne("EcommerceData.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("EcommerceData.Models.Voucher", "Voucher")
                        .WithMany()
                        .HasForeignKey("VoucherId");
                });

            modelBuilder.Entity("EcommerceData.Models.VoucherThemDescription", b =>
                {
                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("EcommerceData.Models.WeightClassDescription", b =>
                {
                    b.HasOne("EcommerceData.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("EcommerceData.Models.Zone", b =>
                {
                    b.HasOne("EcommerceData.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("EcommerceData.Models.ZoneToGeoLocation", b =>
                {
                    b.HasOne("EcommerceData.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("EcommerceData.Models.GeoZone", "GeoZone")
                        .WithMany()
                        .HasForeignKey("GeoZoneId");

                    b.HasOne("EcommerceData.Models.Zone", "Zone")
                        .WithMany()
                        .HasForeignKey("ZoneId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EcommerceData.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EcommerceData.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EcommerceData.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
