namespace StringsApp
{
    /// <summary>
    /// strings are immutable 
    /// </summary>
    internal class Program
    {

        static void Main(string[] args)
        {
            string? str1 = "hello";
            string? str2 = "hello";
            string? str3 = new string("hello");

            Console.WriteLine(str1[0]);  // 'h'


            //String equality

            Console.WriteLine(str1 == str2);      // true, compares values
            Console.WriteLine(str1.Equals(str2)); // true, compares values


            //Reference equality
            Console.WriteLine(object.ReferenceEquals(str1, str2));  // true (interned string literals)
            Console.WriteLine(object.ReferenceEquals(str1, str3));  // false (str3 is a new object)


            //Compare strings
            Console.WriteLine(string.Compare(str1, str3));   // 0 (equal)
            Console.WriteLine(str1.CompareTo(str2));         // 0 (equal)
            int resultEqualsIgnoreCase = string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase); // 0 (equal, ignoring case)


            // concat

            string? result = str1 + " " + str2;
            string? result2 = string.Concat(str1, " ", str2);  // using method to concat


            // to Upper and toLower
            string? upper = str1.ToUpper();   // "HELLO"
            string? lower = str2.ToLower();   // "hello"
            
            Console.WriteLine(str1.ToUpper() == str2.ToUpper());

            //substring
            string? sub = str1.Substring(0, 2); // "he"  startIndex, length
            string? part = str1.Substring(2); // "llo"  startIndex to end of string

            // indexOf , lastIndexOf
            int index = str1.IndexOf('l'); // 2 (first occurrence of 'l')
            int lastIndex = str1.LastIndexOf('l'); // 3 (last occurrence of 'l')

            // trim
            string? padded = "  hello  ";
            string? trimmed = padded.Trim(); // "hello"
        }
    }
}
