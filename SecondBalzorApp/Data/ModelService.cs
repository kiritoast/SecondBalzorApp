using System;
namespace SecondBalzorApp.Data
{
	public class ModelService
	{
        List<Model> AllModel;
        public List<Model> GetModels(int num)
        {
            AllModel = new List<Model>();
            init(num);
            return AllModel;
        }
        public void init(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Model temp = new Model { Name = "Model " + i, Description = "Description " + i };
                AllModel.Add(temp);
            }
        }

    }
}

