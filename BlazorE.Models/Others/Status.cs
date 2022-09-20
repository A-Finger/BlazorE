using System.ComponentModel.DataAnnotations;
using BlazorE.Models.Stores;

namespace BlazorE.Models.Others
{
    public class Status
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string State { get; set; } = null!;

        public IEnumerable<Store> Stores { get; set; } = null!;
    }
}
