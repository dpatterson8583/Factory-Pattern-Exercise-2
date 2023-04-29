namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var connection = DataAccessFactory.GetDataAccess("list");

            var connection2 = DataAccessFactory.GetDataAccess("sql");

            var connection3 = DataAccessFactory.GetDataAccess("mongo");
        }
    }
}
