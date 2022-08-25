using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorE.Models.Locations;

namespace BlazorE.Services.Interfaces
{
    public interface ILocation
    {
        Task<List<District>> GetAllDistrict();
        Task<List<Region>> GetAllRegions();
        Task<List<City>> GetAllCities();
    }
}
