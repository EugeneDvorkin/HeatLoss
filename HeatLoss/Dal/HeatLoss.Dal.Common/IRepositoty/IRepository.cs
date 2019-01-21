using System.Threading.Tasks;
using HeatLoss.Dal.Common.Entity;

namespace HeatLoss.Dal.Common.IRepositoty
{
    public interface IRepository<T> where T : IEntity
    {
        Task<T> GetAsync(int d);
    }
}