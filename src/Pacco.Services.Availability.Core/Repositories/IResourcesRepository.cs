
using Pacco.Services.Availability.Core.Entities;
using System.Threading.Tasks;

namespace Pacco.Services.Availability.Core.Repositories
{
    public interface IResourcesRepository
    {
        Task<Resource> GetAsync(Resource resources);
        Task AddAsync(Resource resources);
        Task UpdateAsync(Resource resources);
        Task GetAsync(AggregateId id);

    }
}
