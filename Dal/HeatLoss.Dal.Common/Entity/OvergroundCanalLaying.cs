namespace HeatLoss.Dal.Common.Entity.OvergroundLaying.CanalLaying
{
    public class OvergroundCanalLaying : IEntity
    {
        public int Id { get; set; }

        public int D { get; set; }

        public double Q10 { get; set; }

        public double Q60 { get; set; }

        public double Q160 { get; set; }

        public double Q260 { get; set; }

        public double Q360 { get; set; }
    }
}