using BlazorE.Models.Sales;
using System.ComponentModel.DataAnnotations;

namespace BlazorE.Models.Others
{
    public class DataType
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Type { get; set; } = null!;

        public IEnumerable<RealData> RealDatas { get; set; } = null!;
        public IEnumerable<ClearedData> ClearedDatas { get; set; } = null!;
    }
}
