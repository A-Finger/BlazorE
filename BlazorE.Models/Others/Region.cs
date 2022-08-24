using System.ComponentModel.DataAnnotations;

namespace BlazorE.Models.Others
{
    public class Region
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string RegionName { get; set; } = null!;
        public int Population { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public IEnumerable<District> Districts { get; set; } = null!;
    }
}
