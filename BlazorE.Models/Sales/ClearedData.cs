using System.ComponentModel.DataAnnotations.Schema;
using BlazorE.Models.Others;
using BlazorE.Models.Stores;
using Microsoft.EntityFrameworkCore;


namespace BlazorE.Models.Sales
{
    [Index(nameof(StoreId), nameof(DataTypeId))]
    public class ClearedData
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public int DataTypeId { get; set; }
        public double Value { get; set; }

        [ForeignKey(nameof(StoreId))]
        public Store Store { get; set; } = null!;
        [ForeignKey(nameof(DataTypeId))]
        public DataType DataType { get; set; } = null!;
    }
}
