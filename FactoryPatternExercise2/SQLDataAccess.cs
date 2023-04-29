using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine($"I am reading data from a SQL data source.");
        }

        public void SaveData()
        {
            Console.WriteLine($"I am writing data to a SQL data source.");
        }
    }
}
