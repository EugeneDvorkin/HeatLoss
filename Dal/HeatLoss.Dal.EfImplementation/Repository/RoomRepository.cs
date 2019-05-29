using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using HeatLoss.Dal.Common;
using HeatLoss.Dal.Common.Entity;
using HeatLoss.Dal.Common.IRepository.Laying;
using HeatLoss.Dal.EfImplementation.EF;

namespace HeatLoss.Dal.EfImplementation.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly HeatLossContext _context;

        public RoomRepository(HeatLossContext context)
        {
            _context = context ?? throw new ArgumentNullException($"{nameof(context)} is null");
        }

        public async Task<RoomLaying> GetAsync(int d)
        {
            try
            {
                return await _context.RoomLaying.Where(e => e.D == d).SingleAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new DalException(DalException.ErrorType.NotFoundDiameter, DalException.LayingType.UndergroundLaying, e.Message, e.InnerException);
            }
        }

        public async Task<IEnumerable<RoomLaying>> GetAllAsync()
        {
            try
            {
                return await _context.RoomLaying.ToListAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new DalException(DalException.ErrorType.DatabaseException, DalException.LayingType.RoomLaying, e.Message, e.InnerException);
            }
        }

        public async Task<RoomLaying> UpdateAsync(RoomLaying entity)
        {
            try
            {
                var temp = await GetAsync(entity.D);
                temp.Q35 = entity.Q35;
                temp.Q85 = entity.Q85;
                temp.Q185 = entity.Q185;
                temp.Q285 = entity.Q285;

                return temp;
            }
            catch (Exception e)
            {
                throw new DalException(DalException.ErrorType.DatabaseException, DalException.LayingType.RoomLaying, e.Message, e.InnerException);
            }
        }

        public async Task DeleteAsync(RoomLaying entity)
        {
            try
            {
                var temp = await GetAsync(entity.D);

                _context.Entry(temp).State = EntityState.Deleted;
            }
            catch (Exception e)
            {
                throw new DalException(DalException.ErrorType.DatabaseException, DalException.LayingType.RoomLaying, e.Message, e.InnerException);
            }
        }

        public async Task<RoomLaying> AddAsync(RoomLaying entity)
        {
            try
            {
                var temp = await _context.RoomLaying.Where(e => e.D == entity.D).SingleOrDefaultAsync().ConfigureAwait(false);
                if (temp != null)
                {
                    throw new DalException(DalException.ErrorType.ExistDiameter, DalException.LayingType.RoomLaying, "Create Room entity exception");
                }

                _context.RoomLaying.Add(entity);

                return entity;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}