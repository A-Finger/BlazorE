using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorE.Models.Stores;

namespace BlazorE.Models.Others
{
    public class Status
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string StatusOf { get; set; } = null!;

        public IEnumerable<Store> Stores { get; set; } = null!;
    }
}
