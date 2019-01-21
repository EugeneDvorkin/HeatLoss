using HeatLoss.Service.Common.Entity;

namespace HeatLoss.Service.Common.IService
{
    public interface IHeatLoosCalculation
    {
        CalculationResult Calculate(StartParams startParams);
    }
}