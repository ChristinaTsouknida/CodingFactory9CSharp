using System.Text;

namespace MethodChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        public static int Add(int a, int b)
        {
            return a + b;
        }


        // method that checks if a number is odd

        public static bool isOdd(int num)
        {
            return num % 2 == 0;
        }


        // calculates the max between two numbers

        //public static int Max(int a, int b)
        //{
        //    if ( a > b)
        //    {
        //        return a;
        //    } 
        //    else
        //    {
        //        return b;

        //    }
        //}

        public static int Max2(int a , int b)
        {
            return Math.Max(a, b);
           // return a > b ? a : b;
        }


        // calculates the area of circle

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }



        // convert celsius to fahrenheit   f = (c * 9/5) + 32

        public static double CelsiusToFahr(double celsius)
        {
            return (celsius * 9 / 5) + 32;

        }


        // returns repeated string n times

        public static string RepeatedString(string str, int n)
        {
           StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(str);
            }
            return sb.ToString();
        }

    }
}
