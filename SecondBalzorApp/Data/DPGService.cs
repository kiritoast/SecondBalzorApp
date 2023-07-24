using System;
namespace SecondBalzorApp.Data
{
    public class DPGService
    {
        private DailyProduct dp = new DailyProduct();
        private DailyProductService dps;
        public DPGService()
        {
            DailyProductService dps = new DailyProductService();
        }
        public DataItem[] GetGoalData()
        {
            dps = new DailyProductService();
            dp = dps.GetDailyProduct();
            DataItem[] GOAL = new DataItem[]
{
        new DataItem
        {
            STAGE = "DROPS",
            Revenue = dp.GoalDrops,
        },
        new DataItem
        {
            STAGE = "WIP",
            Revenue = dp.GoalWIP,
        },
        new DataItem
        {
            STAGE = "TEST",
            Revenue = dp.GoalTEST,
        },
        new DataItem
        {
            STAGE = "FF",
            Revenue = dp.GoalFF,
        },
        new DataItem
        {
            STAGE = "SERILIZED",
            Revenue = dp.GoalSerialized
        }
};

            return GOAL;
        }
        public DataItem[] GetActualData()
        {
            dps = new DailyProductService();
            dp = dps.GetDailyProduct();
            DataItem[] ACTUAL = new DataItem[]
                {
        new DataItem
        {
            STAGE = "DROPS",
            Revenue = dp.ActualDrops
        },
        new DataItem
        {
            STAGE = "WIP",
            Revenue = dp.ActualWIP
        },
        new DataItem
        {
            STAGE = "TEST",
            Revenue = dp.ActualTEST
        },
        new DataItem
        {
            STAGE = "FF",
            Revenue = dp.ActualFF
        },
        new DataItem
        {
            STAGE = "SERILIZED",
            Revenue = dp.ActualSerialized
        } };
            return ACTUAL;
        }
    }
}