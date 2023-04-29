using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine($"I am reading data from a MongoDb data source.");
        }

        public void SaveData()
        {
            Console.WriteLine($"I am writing data to a MongoDb data source.");
        }
    }
}
