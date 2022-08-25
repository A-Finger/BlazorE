using BlazorE.Models.Sales;

namespace BlazorE.Models.Others
{
    public class DataType
    {
        public int Id { get; set; }
        public string Type { get; set; } = null!;

        public IEnumerable<RealData> RealDatas { get; set; } = null!;
        public IEnumerable<ClearedData> ClearedDatas { get; set; } = null!;
    }
}
