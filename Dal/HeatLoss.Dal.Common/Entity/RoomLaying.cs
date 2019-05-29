namespace HeatLoss.Dal.Common.Entity
{
    public class RoomLaying : IEntity
    {
        public int Id { get; set; }

        public int D { get; set; }

        public double Q35 { get; set; }

        public double Q85 { get; set; }

        public double Q185 { get; set; }

        public double Q285 { get; set; }

        public double Q385 { get; set; }
    }
}