using System;
using System.Threading.Tasks;
using HeatLoss.Dal.Common.IRepository.Laying;

namespace HeatLoss.Dal.Common.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IUndergroundRepository Underground { get; }

        IOvergroundCanalRepository OvergroundCanal { get; }

        IRoomRepository RoomRepository { get; }

        Task SaveAsync();
    }
}