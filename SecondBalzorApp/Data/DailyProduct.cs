using System;
namespace SecondBalzorApp.Data
{

    public class DailyProduct
    {
        public int SafetyNumber { get; set; }
        public int EnvironmentalNumber { get; set; }
        public int Engineering { get; set; }
        public int QualityNumber { get; set; }

        public int GoalDrops { get; set; }
        public int GoalWIP { get; set; }
        public int GoalTEST { get; set; }
        public int GoalFF { get; set; }
        public int GoalSerialized { get; set; }

        public int ActualDrops { get; set; }
        public int ActualWIP { get; set; }
        public int ActualTEST { get; set; }
        public int ActualFF { get; set; }
        public int ActualSerialized { get; set; }
}

}

