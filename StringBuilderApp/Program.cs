using System.Text;

namespace StringBuilderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            string collector = "Numbers: ";

            for (int i = 1; i < 100000; i++)
            {
                collector += i;
            }

            Console.WriteLine(collector.Substring(0, 20));
            Console.WriteLine(DateTime.Now);


            // string builder 
            Console.WriteLine(DateTime.Now);
            StringBuilder sb = new StringBuilder ("Numbers: ");

            for (int i = 1; i < 100000; i++)
            {
                sb.Append(i);
            }

            Console.WriteLine(sb.ToString().Substring(0, 20));
            Console.WriteLine(DateTime.Now);
        }
    }
}
