using EcommerceData.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EcommerceData.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) 
        : base(options)
        {
        }

        public DbSet<WeightClass> WeightClasses { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Affiliate> Affiliates { get; set; }
        public DbSet<AffiliateActivity> AffiliateActivities { get; set; }
        public DbSet<AttribureDescription> AttribureDescriptions { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<AttributeGroup> AttributeGroups { get; set; }
        public DbSet<AttributeGroupDecription> AttributeGroupDecriptions { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<BannerImage> BannerImages { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryDescription> CategoryDescriptions { get; set; }
        public DbSet<CategoryFilter> CategoryFilters { get; set; }
        public DbSet<CategoryPath> CategoryPaths { get; set; }
        public DbSet<CategoryToLayout> CategoryToLayouts { get; set; }
        public DbSet<CategoryToStore> CategoryToStores { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<CouponCategory> CouponCategories { get; set; }
        public DbSet<CouponHistory> CouponHistories { get; set; }
        public DbSet<CouponProduct> CouponProducts { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CustomField> CustomFields { get; set; }
        public DbSet<CustomFieldDescription> CustomFieldDescriptions { get; set; }
        public DbSet<CustomFieldUserGroup> CustomFieldUserGroups { get; set; }
        public DbSet<CustomFieldValue> CustomFieldValues { get; set; }
        public DbSet<CustomFieldValueDescription> CustomFieldValueDescriptions { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Download> Downloads { get; set; }
        public DbSet<DownloadDescription> DownloadDescriptions { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Extension> Extensions { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<FilterDescription> FilterDescriptions { get; set; }
        public DbSet<FilterGroup> FilterGroups { get; set; }
        public DbSet<FilterGroupDescription> FilterGroupDescriptions { get; set; }
        public DbSet<GeoZone> GeoZones { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<InformationDescription> InformationDescriptions { get; set; }
        public DbSet<InformationToLayout> InformationToLayouts { get; set; }
        public DbSet<InformationToStore> InformationToStores { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Layout> Layouts { get; set; }
        public DbSet<LayoutModule> LayoutModules { get; set; }
        public DbSet<LayoutRoute> LayoutRoutes { get; set; }
        public DbSet<LengthClass> LengthClasses { get; set; }
        public DbSet<LengthClassDescription> LengthClassDescriptions { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Manufacurer> Manufacurers { get; set; }
        public DbSet<ManufatureToStore> ManufatureToStores { get; set; }
        public DbSet<Marketing> Marketings { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuDescription> MenuDescriptions { get; set; }
        public DbSet<Modification> Modifications { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<MunuModule> MunuModules { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<OptionDescription> OptionDescriptions { get; set; }
        public DbSet<OptionValue> OptionValues { get; set; }
        public DbSet<OptionValueDescription> OptionValueDescriptions { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderCustomField> OrderCustomFields { get; set; }
        public DbSet<OrderHistory> OrderHistories { get; set; }
        public DbSet<OrderOption> OrderOptions { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<OrderRecurring> OrderRecurrings { get; set; }
        public DbSet<OrderRecurringTransaction> OrderRecurringTransactions { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<OrderTotal> OrderTotals { get; set; }
        public DbSet<OrderVoucher> OrderVouchers { get; set; }
        public DbSet<Path> Paths { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<ProductDescription> ProductDescriptions { get; set; }
        public DbSet<ProductDiscount> ProductDiscounts { get; set; }
        public DbSet<ProductFilter> ProductFilters { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductOption> ProductOptions { get; set; }
        public DbSet<ProductOptionValue> ProductOptionValues { get; set; }
        public DbSet<ProductRecurring> ProductRecurrings { get; set; }
        public DbSet<ProductRelated> ProductRelateds { get; set; }
        public DbSet<ProductReward> ProductRewards { get; set; }
        public DbSet<ProductSpecial> ProductSpecials { get; set; }
        public DbSet<ProductToCategory> ProductToCategorys { get; set; }
        public DbSet<ProductToDownload> ProductToDownloads { get; set; }
        public DbSet<ProductToLayout> ProductToLayouts { get; set; }
        public DbSet<ProductToStore> ProductToStores { get; set; }
        public DbSet<Recurring> Recurrings { get; set; }
        public DbSet<Related> Relateds { get; set; }
        public DbSet<Return> Returns { get; set; }
        public DbSet<ReturnAcion> ReturnAcions { get; set; }
        public DbSet<ReturnHistory> ReturnHistorys { get; set; }
        public DbSet<ReturnReason> ReturnReasons { get; set; }
        public DbSet<ReturnStatus> ReturnStatuses { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<StockStatus> StockStatuses { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<TaxClass> TaxClasses { get; set; }
        public DbSet<TaxRate> TaxRates { get; set; }
        public DbSet<TaxRateToUserGroup> TaxRateToUserGroups { get; set; }
        public DbSet<TaxRule> TaxRules { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Upload> Uploads { get; set; }
        public DbSet<UrlAlias> UrlAliass { get; set; }
        public DbSet<UserActivity> UserActivities { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserGroupDecription> UserGroupDecriptions { get; set; }
        public DbSet<UserHistory> UserHistorys { get; set; }
        public DbSet<UserOnline> UserOnlines { get; set; }
        public DbSet<UserReward> UserRewards { get; set; }
        public DbSet<UserSearch> UserSearches { get; set; }
        public DbSet<UserTransaction> UserTransactions { get; set; }
        public DbSet<UserWishlist> UserWishlists { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<VoucherHistory> VoucherHistories { get; set; }
        public DbSet<VoucherThemDescription> VoucherThemDescriptions { get; set; }
        public DbSet<VoucherTheme> VoucherThemes { get; set; }
        public DbSet<WeightClassDescription> WeightClassDescriptions { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<ZoneToGeoLocation> ZoneToGeoLocations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var entity in builder.Model.GetEntityTypes())
            {
                entity.Relational().TableName = entity.DisplayName();
            }

            base.OnModelCreating(builder);
        }
    }
    
}