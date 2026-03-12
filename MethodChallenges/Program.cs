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


        // method that creates a random pin of 4 digits


        public static string GeneratePin()
        {
            Random rand = new();
            return rand.Next(1000, 10000).ToString();

        }


        // filtering even numbers from an array

        public static int[] FilterEvenNumbers(int[] array)
        {
            //return array.Where(num => num % 2 == 0).ToArray();
            return [ .. array.Where(num => num % 2 == 0)];
        }


        // bubble sort

        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap arr[j] and arr[j+1]
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);   // tuple swap
                    }
                }
            }

        }


        //binary search

        public static int BinarySearch(int[] arr, int val)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (arr[middle] == val) return middle;

                if (arr[middle] < val)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return -1;


        }


        // checks if two strings are anagrams
        
        public static bool IsAnagrams(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;

            char[] chars1 = str1.ToUpper().ToCharArray();
            char[] chars2 = str2.ToUpper().ToCharArray();

            Array.Sort(chars1);
            Array.Sort(chars2);

            return new string(chars1) == new string(chars2);
        }


        // calculate the common elements between two arrays

        public static int[] GetCommonElements(int[] arr1, int[] arr2)
        {
            HashSet<int> set1 = [.. arr1];
            HashSet<int> set2 = [.. arr2];

            set1.IntersectWith(set2);
            return [.. set1];
        }
    }
}
