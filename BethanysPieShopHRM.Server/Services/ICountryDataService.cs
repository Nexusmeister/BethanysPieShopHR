using System.Collections.Generic;
using System.Threading.Tasks;
using BethanysPieShopHRM.Shared;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.Server.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
