using System;
using System.Threading.Tasks;
using HeatLoss.Dal.Common;
using HeatLoss.Dal.Common.IRepositoty;
using HeatLoss.Dal.Common.IRepositoty.Laying;
using HeatLoss.Dal.EfImplementation.EF;
using HeatLoss.Dal.EfImplementation.Repository;

namespace HeatLoss.Dal.EfImplementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HeatLossContext _context;
        private UndergroundRepository _underground;
        private OvergroundCanalRepository _overgroundCanal;
        private bool _disposed = false;

        public UnitOfWork(HeatLossContext context)
        {
            _context = context ?? throw new ArgumentNullException($"{nameof(context)} is null");
        }

        public IUndergroundRepository Underground => _underground ?? (_underground = new UndergroundRepository(_context));

        public IOvergroundCanalRepository OvergroundCanal =>
            _overgroundCanal ?? (_overgroundCanal = new OvergroundCanalRepository(_context));

        public async Task Save()
        {
            try
            {
                await _context.SaveChangesAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new DalException(DalException.ErrorType.DatabaseException, DalException.LayingType.CommonLaying, e.Message, e.InnerException);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }
    }
}