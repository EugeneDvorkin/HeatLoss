using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using HeatLoss.Dal.Common;
using HeatLoss.Dal.Common.Entity.OvergroundLaying.CanalLaying;
using HeatLoss.Dal.Common.IRepositoty.Laying;
using HeatLoss.Dal.EfImplementation.EF;

namespace HeatLoss.Dal.EfImplementation.Repository
{
    public class OvergroundCanalRepository:IOvergroundCanalRepository
    {
        private readonly HeatLossContext _context;

        public OvergroundCanalRepository(HeatLossContext context)
        {
            _context = context ?? throw new ArgumentNullException($"{nameof(context)} is null");
        }

        public async Task<OvergroundCanalLaying> GetAsync(int d)
        {
            try
            {
                return await _context.OvergroundCanalLaying.Where(e => e.D == d).SingleAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new DalException(DalException.ErrorType.NorFoundDiameter, DalException.LayingType.OverGroundCanalLaying, e.Message, e.InnerException);
            }
        }

        public async Task<IEnumerable<OvergroundCanalLaying>> GetAllAsync()
        {
            try
            {
                return await _context.OvergroundCanalLaying.ToListAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new DalException(DalException.ErrorType.DatabaseException, DalException.LayingType.OverGroundCanalLaying, e.Message, e.InnerException);
            }
        }

        public async Task<OvergroundCanalLaying> UpdateAsync(OvergroundCanalLaying entity)
        {
            try
            {
                var temp = await GetAsync(entity.D);
                temp.Q10 = entity.Q10;
                temp.Q60 = entity.Q60;
                temp.Q160 = entity.Q160;
                temp.Q260 = entity.Q260;
                temp.Q360 = entity.Q360;

                return temp;
            }
            catch (Exception e)
            {
                throw new DalException(DalException.ErrorType.NorFoundDiameter, DalException.LayingType.OverGroundCanalLaying, e.Message, e.InnerException);
            }
        }

        public async Task DeleteAsync(OvergroundCanalLaying entity)
        {
            try
            {
                var temp = await GetAsync(entity.D);

                if (temp == null)
                {
                    throw new DalException(DalException.ErrorType.NorFoundDiameter, DalException.LayingType.OverGroundCanalLaying, "Deleting UndergroundLaying entity exception");
                }

                _context.Entry(temp).State = EntityState.Deleted;
            }
            catch (Exception e)
            {
                throw new DalException(DalException.ErrorType.DatabaseException, DalException.LayingType.OverGroundCanalLaying, e.Message, e.InnerException);
            }
        }

        public async Task<OvergroundCanalLaying> AddAsync(OvergroundCanalLaying entity)
        {
            try
            {
                var temp = await GetAsync(entity.D);
                if (temp != null)
                {
                    throw new DalException(DalException.ErrorType.ExistDiameter, DalException.LayingType.OverGroundCanalLaying, "Create UndergroundLaying entity exception");
                }

                _context.OvergroundCanalLaying.Add(entity);

                return entity;
            }
            catch (Exception e)
            {
                throw new DalException(DalException.ErrorType.DatabaseException, DalException.LayingType.OverGroundCanalLaying, e.Message, e.InnerException);
            }
        }
    }
}