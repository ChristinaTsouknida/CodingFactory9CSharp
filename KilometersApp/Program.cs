namespace KilometersApp
{

    /// <summary>
    /// Reads a distance in kilometer from the console and,
    /// converts it to meters, centimeters and miles 
    /// and prints the result, formated to 2 decimal places.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            const double METERS_PER_KM = 1000D;
            const double CM_PER_KM = 100000D;
            const double MILES_PER_KM = 0.621371D;

            double kilometers = 0D;
            double meters = 0D;
            double centimeters = 0D;
            double miles = 0D;

            Console.WriteLine("Please enter a distance in kilometers");
            if (!double.TryParse(Console.ReadLine(), out kilometers) || kilometers < 0)
            {
                Console.WriteLine("Invalid input for kilometers.");
                return;
            }
            
            meters = kilometers * METERS_PER_KM;
            centimeters = kilometers * CM_PER_KM;
            miles = kilometers * MILES_PER_KM;

            Console.WriteLine($"{"Kilomiles:", -15} {kilometers, -15:N2} km");
            Console.WriteLine($"{"Meters:", -15} {meters, -15:N2} m");
            Console.WriteLine($"{"Centimeters", -15} {centimeters,-15:N2} cm");
            Console.WriteLine($"{"Miles", -15} {miles, -15:N2} miles");
        }
    }
}
