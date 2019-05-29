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
        public int Ts { get; set; }

        /// <summary>
        ///   Gets or sets the environment temperature.
        /// </summary>
        public int Te { get; set; }

        /// <summary>
        ///   Gets or sets the line length.
        /// </summary>
        public int L { get; set; }

        /// <summary>
        ///   Gets or sets the line type.
        /// </summary>
        public AreaType Type { get; set; }

        /// <summary>
        ///   Gets or sets a value indicating whether [condensate exist].</summary>
        /// <value>
        ///   <c>true</c> if [condensate exist]; otherwise, <c>false</c>.
        /// </value>
        public bool CondensateExist { get; set; }
    }

    public enum AreaType
    {
        Overground = 0,
        Underground = 1,
        Room = 2
    }
}