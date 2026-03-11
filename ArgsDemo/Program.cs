using System;

namespace ArgsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Error in CLI");
                Environment.Exit(1); // exit with error code
            }

            Console.WriteLine($"{args[0]}, {args[1]}, {args[2]}");
        }
    }
}
