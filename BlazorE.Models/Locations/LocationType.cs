using System.ComponentModel.DataAnnotations;
using BlazorE.Models.Stores;

namespace BlazorE.Models.Locations
{
    public class LocationType
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string TypeOfLocation { get; set; } = null!;

        public IEnumerable<Store> Stores { get; set; } = null!;
    }
}
