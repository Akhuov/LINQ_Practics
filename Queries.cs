namespace LINQ_001
{
    internal class Queries
    {
        public static void Run()
        {
            List<int> numbers = new List<int>() { 2, 3, 4, 3, 4, 4, 3, 4, 34, 1, 4, 1324, 1, 34 };

            //Method

            var query = (from number in numbers select number).ToList();

            //List<int> query = numbers.Where(x => x%2==0).ToList();

            //foreach (int i in query)
            //{
            //    Console.WriteLine(i);
            //}


        }
    }
}
