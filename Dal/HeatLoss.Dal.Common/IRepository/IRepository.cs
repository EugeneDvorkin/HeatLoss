using System.Threading.Tasks;
using HeatLoss.Dal.Common.Entity;

namespace HeatLoss.Dal.Common.IRepository
{
    public interface IRepository<T> where T : IEntity
    {
        Task<T> GetAsync(int d);
    }
}