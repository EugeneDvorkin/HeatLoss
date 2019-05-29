using System.Collections.Generic;
using System.Threading.Tasks;
using HeatLoss.Dal.Common.Entity.OvergroundLaying.CanalLaying;

namespace HeatLoss.Dal.Common.IRepository.Laying
{
    public interface IOvergroundCanalRepository : IRepository<OvergroundCanalLaying>
    {
        Task<IEnumerable<OvergroundCanalLaying>> GetAllAsync();

        Task<OvergroundCanalLaying> UpdateAsync(OvergroundCanalLaying entity);

        Task DeleteAsync(OvergroundCanalLaying entity);

        Task<OvergroundCanalLaying> AddAsync(OvergroundCanalLaying entity);
    }
}