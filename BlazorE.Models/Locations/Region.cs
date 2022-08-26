using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BlazorE.Models.Locations
{
    public class Region
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string RegionName { get; set; } = null!;
        public int Population { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }

        public IEnumerable<District> Districts { get; set; } = null!;

        public Region() { }
        public Region(int id, string regionName, int population, double? latitude, double? longitude)
        {
            Id = id;
            RegionName = regionName;
            Population = population;
            Longitude = longitude;
            Latitude = latitude;
        }
    }
}
