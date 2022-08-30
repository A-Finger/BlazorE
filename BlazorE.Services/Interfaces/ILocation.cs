using BlazorE.Models.Locations;

namespace BlazorE.Services.Interfaces
{
    public interface ILocation
    {
        Task<List<District>> GetAllDistrictAsync();
        Task<List<Region>> GetAllRegionsAsync();
        Task<List<City>> GetAllCitiesAsync();
    }
}
