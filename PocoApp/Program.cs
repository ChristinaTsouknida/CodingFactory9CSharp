namespace PocoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student alice = new Student();
            Student bob = new();
            var julia = new Student();


            Teacher teacher = new (1, "Μάκης", "Καπέτης");
            Teacher teacher2 = new() { Id = 2, Firstname = "Γιάννης", Lastname = "Παπαδόπουλος" };




        }
    }
}
