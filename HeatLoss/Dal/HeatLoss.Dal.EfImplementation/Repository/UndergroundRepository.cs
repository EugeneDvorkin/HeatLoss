using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using HeatLoss.Dal.Common;
using HeatLoss.Dal.Common.Entity.UndergroundLaying;
using HeatLoss.Dal.Common.IRepositoty.Laying;
using HeatLoss.Dal.EfImplementation.EF;

namespace HeatLoss.Dal.EfImplementation.Repository
{
    public class UndergroundRepository : IUndergroundRepository
    {
        private readonly HeatLossContext _context;

        public UndergroundRepository(HeatLossContext context)
        {
            _context = context ?? throw new ArgumentNullException($"{nameof(context)} is null");
        }

        public async Task<UndergroundLaying> GetAsync(int d)
        {
            try
            {
                return await _context.UndergroundLaying.Where(e => e.Dp == d).SingleAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new DalException(DalException.ErrorType.NorFoundDiameter, DalException.LayingType.UndergroundLaying, e.Message, e.InnerException);
            }
        }

        public async Task<IEnumerable<UndergroundLaying>> GetAllAsync()
        {
            try
            {
                return await _context.UndergroundLaying.ToListAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new DalException(DalException.ErrorType.DatabaseException, DalException.LayingType.UndergroundLaying, e.Message, e.InnerException);
            }
        }

        public async Task<UndergroundLaying> UpdateAsync(UndergroundLaying entity)
        {
            try
            {
                var temp = await GetAsync(entity.Dp);
                temp.Dk = entity.Dk;
                temp.Q110 = entity.Q110;
                temp.Q145 = entity.Q145;
                temp.Q195 = entity.Q195;
                temp.Q245 = entity.Q245;
                temp.Q295 = entity.Q295;
                temp.Q345 = entity.Q345;
                temp.Qk = entity.Qk;
                //await _context.SaveChangesAsync().ConfigureAwait(false);

                return temp;
            }
            catch (Exception e)
            {
                throw new DalException(DalException.ErrorType.NorFoundDiameter, DalException.LayingType.UndergroundLaying, e.Message, e.InnerException);
            }
        }

        public async Task DeleteAsync(UndergroundLaying entity)
        {
            try
            {
                var temp = await GetAsync(entity.Dp);

                if (temp == null)
                {
                    throw new DalException(DalException.ErrorType.NorFoundDiameter, DalException.LayingType.UndergroundLaying, "Deleting UndergroundLaying entity exception");
                }

                _context.Entry(temp).State = EntityState.Deleted;
                //await _context.SaveChangesAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new DalException(DalException.ErrorType.DatabaseException, DalException.LayingType.UndergroundLaying, e.Message, e.InnerException);
            }
        }

        public async Task<UndergroundLaying> AddAsync(UndergroundLaying entity)
        {
            try
            {
                var temp = await GetAsync(entity.Dp);
                if (temp != null)
                {
                    throw new DalException(DalException.ErrorType.ExistDiameter, DalException.LayingType.UndergroundLaying, "Create UndergroundLaying entity exception");
                }

                _context.UndergroundLaying.Add(entity);
                //await _context.SaveChangesAsync().ConfigureAwait(false);

                return entity;
            }
            catch (Exception e)
            {
                throw new DalException(DalException.ErrorType.DatabaseException, DalException.LayingType.UndergroundLaying, e.Message, e.InnerException);
            }
        }
    }
}