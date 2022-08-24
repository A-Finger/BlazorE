using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorE.Models.Locations
{
    public class District
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string DistrictName { get; set; } = null!;
        public int Population { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double RegionId { get; set; }

        [ForeignKey(nameof(RegionId))]
        public Region Region { get; set; } = null!;
        public IEnumerable<City> Cities { get; set; } = null!;
    }
}
