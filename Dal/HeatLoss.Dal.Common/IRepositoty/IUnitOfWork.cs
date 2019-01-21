using System;
using System.Threading.Tasks;
using HeatLoss.Dal.Common.IRepositoty.Laying;

namespace HeatLoss.Dal.Common.IRepositoty
{
    public interface IUnitOfWork : IDisposable
    {
        IUndergroundRepository Underground { get; }

        IOvergroundCanalRepository OvergroundCanal { get; }

        Task Save();
    }
}