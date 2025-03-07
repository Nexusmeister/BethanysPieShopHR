using System.Collections.Generic;
using System.Threading.Tasks;
using BethanysPieShopHRM.Shared;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.Server.Services
{
    public interface IJobCategoryDataService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
