namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Swap(a, b);

            Console.WriteLine($"a: {a}, b: {b}");
        }



        /// <summary>
        /// Pass by value swap method. It does not swap the values of a and b in the caller method.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Swap(int a, int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }


        public static void SwapRef(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;

        }


        public static (int, int) SwapWithTuple(int a, int b)
        {
            return (b, a);

        }
    }
}
