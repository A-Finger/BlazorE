using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorE.Models.Others
{
    public class City
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string CityName { get; set; } = null!;
        public int Population { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double DistrictId { get; set; }

        [ForeignKey(nameof(DistrictId))]
        public District District { get; set; } = null!;
    }
}
