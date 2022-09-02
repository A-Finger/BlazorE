using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorE.Models.Locations
{
    public class City
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string CityName { get; set; } = null!;
        public int Population { get; set; }
        public int LocalityId { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public int DistrictId { get; set; }

        [ForeignKey(nameof(DistrictId))]
        public District District { get; set; } = null!;
        [ForeignKey(nameof(LocalityId))]
        public Locality TypeOfLocality { get; set; } = null!;

        public City() { }
        public City(int id, string cityName, int population,int localityId, double? latitude, double? longitude, District district, Locality typeOfLocality)
        {
            Id = id;
            CityName = cityName;
            Population = population;
            LocalityId = localityId;
            Longitude = longitude;
            Latitude = latitude;
            DistrictId = district.Id;
            District = district;
            LocalityId = typeOfLocality.Id;
            TypeOfLocality = typeOfLocality;
        }
    }
}
