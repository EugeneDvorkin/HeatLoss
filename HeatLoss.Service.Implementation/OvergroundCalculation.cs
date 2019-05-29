using System;
using HeatLoss.Dal.Common.Entity.OvergroundLaying.CanalLaying;
using HeatLoss.Service.Common.Entity;

namespace HeatLoss.Service.Implementation
{
    public static class OvergroundCalculation
    {
        public static CalculationResult Calculate(OvergroundCanalLaying entity, StartParams startParams)
        {
            CalculationResult result = new CalculationResult();
            int dTs = startParams.Ts - 40;
            
            if (dTs >= 10 && dTs < 60)
            {
                result.Qs = entity.Q10 + (entity.Q60 - entity.Q10) * (dTs - 10) / (60 - 10);
            }
            else if (dTs >= 60 && dTs < 160)
            {
                result.Qs = entity.Q60 + (entity.Q160 - entity.Q60) * (dTs - 60) / (160 - 60);
            }
            else if (dTs >= 160 && dTs < 260)
            {
                result.Qs = entity.Q160 + (entity.Q260 - entity.Q160) * (dTs - 160) / (260 - 160);
            }
            else if (dTs >= 260 && dTs <= 360)
            {
                result.Qs = entity.Q260 + (entity.Q360 - entity.Q260) * (dTs - 260) / (360 - 260);
            }
            else if (dTs < 10 || dTs > 360)
            {
                throw new Exception();
            }

            if (startParams.Te == 0)
            {
                result.Tc = 0;
                result.Qc = 0;
            }
            else
            {
                int dTe = startParams.Te - 40;
                if ((dTe >= 10) && (dTe < 60))
                {
                    result.Qc = (entity.Q10 + ((entity.Q60 - entity.Q10) * (dTs - 10) / (60 - 10)));
                }
                else if ((dTe >= 60) && (dTe < 160))
                {
                    result.Qc = (entity.Q60 + ((entity.Q160 - entity.Q60) * (dTs - 60) / (160 - 60)));
                }
                else if ((dTe >= 160) && (dTe < 260))
                {
                    result.Qc = (entity.Q160 + ((entity.Q260 - entity.Q160) * (dTs - 160) / (260 - 160)));
                }
                else if ((dTe >= 260) && (dTe <= 360))
                {
                    result.Qc = (entity.Q260 + ((entity.Q360 - entity.Q260) * (dTs - 260) / (360 - 260)));
                }
                else if ((dTe < 10) || (dTe > 360))
                {
                    throw new Exception();
                }
            }

            result.Qres_s = result.Qs * startParams.L;
            result.Qres_c = result.Qc * startParams.L;
            if (startParams.D < 150)
            {
                result.Qha_s = result.Qres_s * 1.2 * 3.6;
                result.Qha_c = result.Qres_c * 1.2 * 3.6;
            }
            else
            {
                result.Qha_s = result.Qres_s * 1.15 * 3.6;
                result.Qha_c = result.Qres_c * 1.15 * 3.6;
            }

            return result;
        }
    }
}