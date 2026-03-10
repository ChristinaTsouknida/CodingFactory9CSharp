namespace DoWhileApp
{

    /// <summary>
    /// Counts the number of digits of an int
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int numberOfDigits = 0;
            int tmp = 0;

            Console.WriteLine("Please enter an integer");

            if (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Invalid input for integer.");
                return;
            }

            tmp = num;

            do
            {
                tmp /= 10;
                numberOfDigits++;

            } while (tmp != 0);

            Console.WriteLine($"Digits count: {numberOfDigits}");
        }
            
    }
}
