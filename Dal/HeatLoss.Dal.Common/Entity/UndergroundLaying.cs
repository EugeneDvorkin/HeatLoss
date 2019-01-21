namespace HeatLoss.Dal.Common.Entity.UndergroundLaying
{
    public class UndergroundLaying : IEntity
    {
        public int Id { get; set; }

        public int Dp { get; set; }

        public int Dk { get; set; }

        public double Qk { get; set; }

        public double Q110 { get; set; }

        public double Q145 { get; set; }

        public double Q195 { get; set; }

        public double Q245 { get; set; }

        public double Q295 { get; set; }

        public double Q345 { get; set; }

        public double Q395 { get; set; }

        public double Q445 { get; set; }
    }
}