using System;
using HeatLoss.Dal.Common.Entity.UndergroundLaying;
using HeatLoss.Service.Common.Entity;

namespace HeatLoss.Service.Implementation
{
    public static class UndergroundCalculation
    {
        public static CalculationResult Calculate(StartParams startParams, UndergroundLaying entity)
        {
            CalculationResult result = new CalculationResult();
            CalculateQs(startParams, entity, result);
            result.Tc = startParams.CondensateExist ? 0 : 100;
            result.Qc = startParams.CondensateExist ? 0 : entity.Qk;
            CalculateQres(startParams, entity, result);

            return result;
        }

        private static void CalculateQs(StartParams startParams, UndergroundLaying entity, CalculationResult result)
        {
            int dTs = startParams.Ts - startParams.Te;
            if (dTs >= 110 && dTs < 145)
            {
                result.Qs = entity.Q110 + (entity.Q145 - entity.Q110) * (dTs - 110) / (145 - 110);
            }
            else if ((dTs >= 145) && (dTs < 195))
            {
                result.Qs = entity.Q145 + (entity.Q195 - entity.Q145) * (dTs - 145) / (195 - 145);
            }
            else if (dTs >= 195 && dTs < 245)
            {
                result.Qs = entity.Q195 + (entity.Q245 - entity.Q195) * (dTs - 195) / (245 - 195);
            }
            else if (dTs >= 245 && dTs < 295)
            {
                result.Qs = entity.Q245 + (entity.Q295 - entity.Q245) * (dTs - 245) / (295 - 245);
            }
            else if (dTs >= 295 && dTs < 345)
            {
                result.Qs = entity.Q295 + (entity.Q345 - entity.Q295) * (dTs - 295) / (345 - 295);
            }
            else if (dTs >= 345 && dTs < 395)
            {
                result.Qs = entity.Q345 + (entity.Q395 - entity.Q345) * (dTs - 345) / (395 - 345);
            }
            else if (dTs >= 395 && dTs <= 445)
            {
                result.Qs = entity.Q395 + (entity.Q445 - entity.Q395) * (dTs - 395) / (445 - 395);
            }
            else if (dTs < 110 || dTs > 445)
            {
                throw new Exception();
            }
        }

        private static void CalculateQres(StartParams startParams, UndergroundLaying entity, CalculationResult result)
        {
            result.Qres_s = result.Qs * startParams.L;
            result.Qres_c = result.Qc * startParams.L;
            result.Qha_s = result.Qres_s * 1.15 * 3.6;
            result.Qha_c = result.Qres_c * 1.15 * 3.6;
        }
    }
}