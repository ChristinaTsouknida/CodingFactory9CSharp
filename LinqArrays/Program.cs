namespace LinqArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [5, 3, 8, 1, 9, 2];

            int min = arr.Min();
            int max = arr.Max();
            int sum = arr.Sum();
            double average = arr.Average();
            int count = arr.Count();
            int countGreaterThan4 = arr.Count(x => x > 4);

            var filtered = arr.Where(x => x > 4).ToArray();  // filtering
            var doubled = arr.Select(x => x * 2).ToArray();  // map
            var sorted = arr.OrderBy(x => x).ToArray();      // sorting
            var sortedDesc = arr.OrderByDescending(x => x).ToArray(); // sorting in descending order
            bool any = arr.Any(x => x > 8); // checks if any element is greater than 8
            bool all = arr.All(x => x > 0); // checks if all elements are greater than 0
            int first = arr.First(x => x > 4); // returns the first element that is greater than 4

        }
    }
}
