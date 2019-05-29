using System.Collections.Generic;
using System.Threading.Tasks;
using HeatLoss.Dal.Common.Entity;

namespace HeatLoss.Dal.Common.IRepository.Laying
{
    public interface IRoomRepository:IRepository<RoomLaying>
    {
        Task<IEnumerable<RoomLaying>> GetAllAsync();

        Task<RoomLaying> UpdateAsync(RoomLaying entity);

        Task DeleteAsync(RoomLaying entity);

        Task<RoomLaying> AddAsync(RoomLaying entity);
    }
}