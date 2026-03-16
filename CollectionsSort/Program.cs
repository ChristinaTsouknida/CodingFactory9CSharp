namespace CollectionsSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students =
                [
                    new Student() {Firstname = "Alice", Lastname = "Wonderland", Age = 22},
                    new Student() {Firstname = "Bob", Lastname = "Dylan", Age = 20},

                ];

            students.Sort(); // uses compareTo
            students.Sort((s1, s2) => string.Compare(s1.Lastname, s2.Lastname, StringComparison.Ordinal));   // IComparer

        }
    }
}
