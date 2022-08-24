using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorE.Models.Stores;

namespace BlazorE.Models.Others
{
    public class RetailBrand
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; } = null!;

        public IEnumerable<Store> Stores { get; set; } = null!;
    }
}
