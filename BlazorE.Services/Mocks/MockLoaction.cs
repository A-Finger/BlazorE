﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorE.Models.Locations;
using BlazorE.Services.Interfaces;

namespace BlazorE.Services.Mocks
{
    public class MockLoaction : ILocation
    {
        private readonly List<District> _districts;
        private readonly List<Region> _regions;
        private readonly List<City> _cities;
        private readonly List<Locality> _localities;

        public MockLoaction()
        {
            #region Add entities to list of regions
            _regions = new List<Region>
            {
                new Region(1, "Вінницька область", 1545416, 48.9720909, 27.5753649),
                new Region(2, "Волинська область", 1031421, 51.1228084, 23.7341467),
                new Region(3, "Дніпропетровська область", 3176648, 48.3195469, 33.8268897)
            };
            #endregion
            #region Add entites to list of districts
            _districts = new List<District>
            {
                new District(1, "Вінниця (місто)", 370707, 49.2347128, 28.399594, 1),
                new District(2, "Жмеринка (місто)", 34353, 49.0347082, 28.0653579, 1),
                new District(4, "Барський район", 50000, 48.9864982, 27.0951065, 1),

                new District(35, "Луцьк (місто)", 217315, 50.73977, 25.263965, 2),
                new District(36, "Володимир-Волинський район", 24545, 50.8808717, 23.9922737, 2),
                new District(37, "Горохівський район", 50220, 50.4832748, 24.5962435, 2),

                new District(62, "Дніпро (міськрада)", 993220, 48.4622135, 34.8602725, 3),
                new District(63, "Дніпровський район", 83879, 48.485929, 34.6318772, 3),
                new District(64, "Жовті Води (міськрада)", 44320, 48.3662787, 33.4673882, 3)
            };
            #endregion
            #region Add entites to list of cities
            _cities = new List<City>
            {
                new City(1, "Вінниця", 370707, 1, 49.2347128, 28.399594, 1),
                new City(2, "Жмеринка", 34353, 1, 49.0347082, 28.0653579, 2),
                new City(4, "Бар", 15775, 1, 49.0773188, 27.6074541, 4),
                new City(5, "Копайгород", 1243, 2, 48.8544896, 27.7661602, 4),

                new City(50, "Луцьк", 217315, 1, 50.73977, 25.263965, 35),
                new City(51, "Устилуг", 2096, 1, 50.8598762, 24.1395284, 36),
                new City(52, "Берестечко", 1694, 1, 50.3618529, 25.0934278, 37),
                new City(53, "Горохів", 9053, 1, 50.4987121, 24.7456097, 37),
                new City(54, "Мар'янівка", 2736, 2, 50.45399, 24.7852098, 37),
                new City(55, "Сенкевичівка", 1257, 2, 50.5290912, 25.0207398, 37),

                new City(96, "Дніпро", 990724, 1, 48.4622135, 34.8602725, 62),
                new City(97, "Авіаторське", 2496, 2, 48.3679517, 35.0725533, 62),
                new City(98, "Підгородне", 19526, 1, 48.5753292, 35.0626666, 63),
                new City(99, "Обухівка", 9224, 2, 48.5441211, 34.8392666, 63),
                new City(100, "Слобожанське", 13889, 2, 48.5442264, 35.0402961, 63),
                new City(101, "Жовті Води", 44320, 1, 48.3662787, 33.4673882, 64)
            };
            #endregion
            #region Add entites to list of localities
            _localities = new List<Locality>()
            {
                new Locality() { Id = 1, TypeOfLocality = "місто" },
                new Locality() { Id = 2, TypeOfLocality = "смт" },
                new Locality() { Id = 3, TypeOfLocality = "село" }
            };
            #endregion
        }

        public async Task<List<City>> GetAllCities()
        {
            return await Task.Run(() => _cities);
        }

        public async Task<List<District>> GetAllDistrict()
        {
            return await Task.Run(() => _districts);
        }

        public async Task<List<Region>> GetAllRegions()
        {
            return await Task.Run(() => _regions);
        }
        public async Task<List<Locality>> GetAllLocality()
        {
            return await Task.Run(() => _localities);
        }
    }
}
