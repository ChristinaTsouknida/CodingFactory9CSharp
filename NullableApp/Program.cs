namespace NullableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? s = Console.ReadLine();   // possible null value


            // Right way to handle nullable reference types
            if (s != null) Console.WriteLine(s.Length);    // null check


            Console.WriteLine(s?.Length);      // null-conditional operator
            Console.WriteLine(s!.Length);      // null-forgiving operator (use with caution, it tells the compiler to ignore nullability warnings, but can lead to runtime exceptions if s is actually null)
            Console.WriteLine(s ?? "default"); //null-coalescing operator (provides a default value if s is null)
        }
    }
}
