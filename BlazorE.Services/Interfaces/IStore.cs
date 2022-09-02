using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorE.Models.Locations;
using BlazorE.Models.Stores;

namespace BlazorE.Services.Interfaces
{
	public interface IStore
	{
		public Task<IEnumerable<Store>> GetAllStoresAsync();
		public Task<Store> GetStoreAsync(int id);
		public Task<IEnumerable<Store>> GetStoresBy(City city);
        public Task<IEnumerable<Store>> GetStoresBy(District city);
        public Task<IEnumerable<Store>> GetStoresBy(Region city);
    }
}
