using BlazorE.Models.Locations;
using BlazorE.Models.Others;
using BlazorE.Models.Sales;
using BlazorE.Models.Stores;
using Microsoft.EntityFrameworkCore;

namespace BlazorE.Services.DbAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        #region Folder Location
        public DbSet<Region> Regions { get; set; } = null!;
        public DbSet<District> Districts { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<LocationType> LocationTypes { get; set; } = null!;
        #endregion

        #region Folder Others
        public DbSet<DataType> DataTypes { get; set; } = null!;
        public DbSet<Format> Formats { get; set; } = null!;
        public DbSet<RetailBrand> RetailBrands { get; set; } = null!;
        public DbSet<RetailType> RetailTypes { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;
        #endregion

        #region Folder Sales
        public DbSet<RealData> RealDatas { get; set; } = null!;
        public DbSet<ClearedData> ClearedDatas { get; set; } = null!;
        #endregion

        #region Folder Stores
        public DbSet<Store> Stores { get; set; } = null!;
        #endregion
    }
}
