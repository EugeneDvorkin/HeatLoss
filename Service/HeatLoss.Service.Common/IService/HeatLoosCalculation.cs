using System.Threading.Tasks;
using HeatLoss.Service.Common.Entity;

namespace HeatLoss.Service.Common.IService
{
    public interface IHeatLoosCalculation
    {
        Task<CalculationResult> CalculateArea(StartParams startParams);
    }
}