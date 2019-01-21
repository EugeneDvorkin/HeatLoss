namespace HeatLoss.Service.Common.Entity
{
    public class CalculationResult
    {
        /// <summary>
        ///   Gets or sets the condensate temperature.
        /// </summary>
        public int Tc { get; set; }

        /// <summary>
        ///   Gets or sets the steam temperature.
        /// </summary>
        public int Ts { get; set; }

        /// <summary>
        ///   Gets or sets the sector length.
        /// </summary>
        public int L { get; set; }

        /// <summary>
        ///   Gets or sets the specific condensate heat flow.
        /// </summary>
        public double Qc { get; set; }

        /// <summary>
        ///   Gets or sets the result condensate heat flow.
        /// </summary>
        public double Qres_c { get; set; }

        /// <summary>
        ///   Gets or sets the specific steam heat flow.
        /// </summary>
        public double Qs { get; set; }

        /// <summary>
        ///   Gets or sets the result steam heat flow.
        /// </summary>
        public double Qres_s { get; set; }

        /// <summary>
        ///   Gets or sets the steam line diameter.
        /// </summary>
        public int Ds { get; set; }

        /// <summary>
        ///   Gets or sets the condensate line diameter.
        /// </summary>
        public int Dc { get; set; }

        /// <summary>
        ///   Gets or sets the steam hourly average heat loss.
        /// </summary>
        public double Qha_s { get; set; }

        /// <summary>
        ///   Gets or sets the condensate hourly average heat loss.
        /// </summary>
        public double Qha_c { get; set; }
    }
}