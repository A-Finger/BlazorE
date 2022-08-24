using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorE.Models.Stores
{
    public class Format
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; } = null!;
    }
}
