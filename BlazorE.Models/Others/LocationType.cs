using System.ComponentModel.DataAnnotations;
using BlazorE.Models.Stores;

namespace BlazorE.Models.Others
{
    public class LocationType
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; } = null!;

        public IEnumerable<Store> Stores { get; set; } = null!;
    }
}
