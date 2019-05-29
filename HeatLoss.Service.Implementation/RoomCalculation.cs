using System;
using HeatLoss.Dal.Common.Entity;
using HeatLoss.Service.Common.Entity;

namespace HeatLoss.Service.Implementation
{
    public static class RoomCalculation
    {
        public static CalculationResult Calculate(StartParams startParams, RoomLaying entity)
        {
            CalculationResult result = new CalculationResult();
            CalculateQs(startParams, entity, result);
            CalculateQc(startParams,entity,result);
            CalculateQres(startParams, entity,result);

            return result;
        }

        private static void CalculateQs(StartParams startParams, RoomLaying entity, CalculationResult result)
        {
            int dTs = startParams.Ts - 15;
            if (dTs >= 35 && dTs < 85)
            {
                result.Qs = entity.Q35 + (entity.Q85 - entity.Q35) * (dTs - 35) / (85 - 35);
            }
            else if (dTs >= 85 && dTs < 185)
            {
                result.Qs = entity.Q85 + (entity.Q185 - entity.Q85) * (dTs - 85) / (135 - 85);
            }
            else if (dTs >= 185 && dTs < 285)
            {
                result.Qs = entity.Q185 + (entity.Q285 - entity.Q185) * (dTs - 185) / (235 - 185);
            }
            else if (dTs >= 285 && dTs < 385)
            {
                result.Qs = entity.Q285 + (entity.Q385 - entity.Q285) * (dTs - 285) / (335 - 285);
            }
            else if (dTs < 35 || dTs > 385)
            {
                throw new Exception();
            }
        }

        private static void CalculateQc(StartParams startParams, RoomLaying entity, CalculationResult result)
        {
            if (startParams.Te == 0)
            {
                result.Tc = 0;
                result.Qc = 0;
            }
            else
            {
                int dTe = startParams.Te - 15;
                if (dTe >= 35 && (dTe < 85))
                {
                    result.Qc = entity.Q35 + (entity.Q85 - entity.Q35) * (dTe - 35) / (85 - 35);
                }
                else if (dTe >= 85 && dTe < 185)
                {
                    result.Qc = entity.Q85 + (entity.Q185 - entity.Q85) * (dTe - 85) / (135 - 85);
                }
                else if (dTe >= 185 && dTe < 285)
                {
                    result.Qc = entity.Q185 + (entity.Q285 - entity.Q185) * (dTe - 185) / (235 - 185);
                }
                else if (dTe >= 285 && (dTe < 385))
                {
                    result.Qc = entity.Q285 + (entity.Q385 - entity.Q285) * (dTe - 285) / (335 - 285);
                }
                else if (dTe < 35 || dTe > 385)
                {
                    throw new Exception();
                }
            }
        }

        private static void CalculateQres(StartParams startParams, RoomLaying entity, CalculationResult result)
        {
            result.Qres_s = result.Qc * startParams.L;
            result.Qres_c = result.Qc * startParams.L;
            if (entity.D < 150)
            {
                result.Qha_s = result.Qres_s * 1.2 * 3.6;
                result.Qha_c = result.Qres_c * 1.2 * 3.6;
            }
            else
            {
                result.Qha_s = result.Qres_s * 1.15 * 3.6;
                result.Qha_c = result.Qres_c * 1.15 * 3.6;
            }
        }
    }
}