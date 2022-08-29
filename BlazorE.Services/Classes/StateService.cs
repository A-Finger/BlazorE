using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorE.Models.Locations;
using BlazorE.Services.Interfaces;

namespace BlazorE.Services.Classes
{
    public class StateService : IStateService
    {
        private List<Region> _regions = null!;
        private List<District> _districts = null!;
        private List<City> _cities = null!;
        private List<Locality> _localities = null!;


        public List<Region> Regions
        {
            get => _regions;
            set
            {
                _regions = value;
                NotifyStateChanged();
            }
        }
        public List<District> Districts {
            get => _districts;
            set
            {
                _districts = value;
                NotifyStateChanged();
            }
        }
        public List<City> Cities {
            get => _cities;
            set
            {
                _cities = value;
                NotifyStateChanged();
            }
        }
        public List<Locality> Localities
        {
            get => _localities;
            set
            {
                _localities = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
