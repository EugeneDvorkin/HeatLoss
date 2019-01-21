namespace HeatLoss.Service.Common.Entity
{
    public class StartParams
    {
        /// <summary>
        ///   Gets or sets the steam line diameter.
        /// </summary>
        public int D { get; set; }

        /// <summary>
        ///   Gets or sets the steam temperature.
        /// </summary>
        public double Ts { get; set; }

        /// <summary>
        ///   Gets or sets the environment temperature.
        /// </summary>
        public double Te { get; set; }

        /// <summary>
        ///   Gets or sets the existing of condensate line.
        /// </summary>
        public bool CondensateExist { get; set; }
    }
}