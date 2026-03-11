namespace MoreMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            result = Add(1, 2, 3); // 6

            DateTime dateTime = getDateTIme(2024, 6, 1);
            DateTime defaultDateTime = getDateTIme(); // 1970-01-01T00:00:00Z

        }


        public static int Add(params int[] arr)
        {
            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }

            return sum;
        }


        public static DateTime getDateTIme(int year = 1970, int month = 1, int day = 1, int min = 0, int sec = 0, int ms = 0)
        {

            return new DateTime(year, month, day, min, sec, ms, DateTimeKind.Utc);
        }


        public static void SayHello(string message)
        {
            Console.WriteLine(message);
        }


        public static void SayHello()
        {
            Console.WriteLine("coding");
        }

    }
}
