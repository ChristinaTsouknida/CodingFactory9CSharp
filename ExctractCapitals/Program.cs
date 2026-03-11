using System.Text;

namespace ExtractCapitals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        // extract capital letters from a string

        public static string ExtractCapitals(string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str?.Length; i++)
            {
                char c = str[i];
                if (char.IsUpper(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();

        }
    }
}
