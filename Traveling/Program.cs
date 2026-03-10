namespace Traveling
{
    /// <summary>
    /// Reads fuel consumption (liters per 100 km) and distance (km) from the console,
    /// calculates the total fuel needed for the trip and the total cost, and
    /// prints the result formatted to 2 decimal places
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            const double FUEL_PRICE = 1.85D;

            double kilometers = 0D;
            double fuelConsumption = 0D;
            double fuelNeeded = 0D;
            double totalCost = 0D;

            Console.WriteLine("Please enter the fuel comsumption for every 1 km of your vehicle");
            if (!double.TryParse(Console.ReadLine(), out fuelConsumption) || fuelConsumption < 0)
            {
                Console.WriteLine("Invalid input for fuel consumption.");
                return;
            }

            Console.WriteLine("Please enter the distance of your trip in kilometers");
            if (!double.TryParse(Console.ReadLine() , out kilometers) || kilometers < 0)
            {
                Console.WriteLine("Invalid input for distance.");
                return;
            }

            fuelNeeded = Math.Round((fuelConsumption * kilometers) / 100, 2);
            totalCost = Math.Round(fuelNeeded * FUEL_PRICE, 2);

            Console.WriteLine($"{"Fuel Needed:", -15} {fuelNeeded, -15:N2}");
            Console.WriteLine($"{"Total Cost:",-15} {totalCost,-15:N2} ");


        }
    }
}
