using System.Collections.Generic;
using System.Threading.Tasks;

namespace HeatLoss.Dal.Common.IRepository.Laying
{
    public interface IUndergroundRepository : IRepository<Entity.UndergroundLaying.UndergroundLaying>
    {
        Task<IEnumerable<Entity.UndergroundLaying.UndergroundLaying>> GetAllAsync();

        Task<Entity.UndergroundLaying.UndergroundLaying> UpdateAsync(Entity.UndergroundLaying.UndergroundLaying entity);

        Task DeleteAsync(Entity.UndergroundLaying.UndergroundLaying entity);

        Task<Entity.UndergroundLaying.UndergroundLaying> AddAsync(Entity.UndergroundLaying.UndergroundLaying entity);
    }
}