using System;
namespace SecondBalzorApp.Data
{
	public class DailyProductService
    {
        private readonly Random random;

        public DailyProductService()
		{
            random = new Random();
        }

        public DailyProduct GetDailyProduct()
        {
            DailyProduct dailyProduct = new DailyProduct();

            dailyProduct.SafetyNumber = random.Next(0, 50);
            dailyProduct.EnvironmentalNumber = random.Next(0, 50);
            dailyProduct.Engineering = random.Next(0, 50);
            dailyProduct.QualityNumber = random.Next(0, 50);

            dailyProduct.GoalDrops = random.Next(0, 50);
            dailyProduct.GoalWIP = random.Next(0, 50);
            dailyProduct.GoalTEST = random.Next(0, 50);
            dailyProduct.GoalFF = random.Next(0, 50);
            dailyProduct.GoalSerialized = random.Next(0, 50);

            dailyProduct.ActualDrops = random.Next(0, 50);
            dailyProduct.ActualWIP = random.Next(0, 50);
            dailyProduct.ActualTEST = random.Next(0, 50);
            dailyProduct.ActualFF = random.Next(0, 50);
            dailyProduct.ActualSerialized = random.Next(0, 50);
            
            return dailyProduct;
        } 

    }
}

