using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorE.Models.Locations
{
    public class Locality
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public IEnumerable<City> Cities { get; set; } = null!;
    }
}
