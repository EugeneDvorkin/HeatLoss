using System.Threading.Tasks;
using HeatLoss.Dal.Common;
using HeatLoss.Dal.Common.IRepository;
using HeatLoss.Service.Common;
using HeatLoss.Service.Common.Entity;
using HeatLoss.Service.Common.IService;

namespace HeatLoss.Service.Implementation
{
    public class HeatLossCalculation : IHeatLoosCalculation
    {
        private readonly IUnitOfWork _context;
        private readonly ILogger _logger;

        public HeatLossCalculation(IUnitOfWork context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<CalculationResult> CalculateArea(StartParams startParams)
        {
            if (startParams.Type == AreaType.Overground)
            {
                return await Overground(startParams);
            }
            if (startParams.Type == AreaType.Underground)
            {
                return await Underground(startParams);
            }
            if (startParams.Type == AreaType.Room)
            {
                return await Room(startParams);
            }

            throw new BllException("Wrong Area type");
        }

        private async Task<CalculationResult> Overground(StartParams startParams)
        {
            try
            {
                var temp = await _context.OvergroundCanal.GetAsync(startParams.D);
                return OvergroundCalculation.Calculate(temp, startParams);
            }
            catch (DalException e)
            {
                _logger.Log(e.Error, e, e.Message, e.StackTrace, AreaType.Overground);
                throw new BllException(e, e.Message, e.StackTrace);
            }
        }

        private async Task<CalculationResult> Underground(StartParams startParams)
        {
            try
            {
                var temp = await _context.Underground.GetAsync(startParams.D);

                return UndergroundCalculation.Calculate(startParams, temp);
            }
            catch (DalException e)
            {
                _logger.Log(e.Error, e, e.Message, e.StackTrace, AreaType.Underground);
                throw new BllException(e, e.Message, e.StackTrace);
            }
        }

        private async Task<CalculationResult> Room(StartParams startParams)
        {
            try
            {
                var temp = await _context.RoomRepository.GetAsync(startParams.D);

                return RoomCalculation.Calculate(startParams, temp);
            }
            catch (DalException e)
            {
                _logger.Log(e.Error, e, e.Message, e.StackTrace, AreaType.Room);
                throw new BllException(e, e.Message, e.StackTrace);
            }
        }
    }
}
