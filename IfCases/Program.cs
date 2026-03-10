namespace IfCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            string name = null;
            string nickname = "Ally";

            if (age > 18)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Minor");
            }

            var status = age > 18 ? "Adult" : "Minor";
            Console.WriteLine(status);   //Adult

            var displayName = name ?? "Unknown";
            Console.WriteLine(displayName);

            var length = name?.Length ?? 0;
            Console.WriteLine(length);
        }
    }
}
