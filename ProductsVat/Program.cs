namespace ProductsVat
{
    /// <summary>
    /// Reads a price from the console and, calculates the VAT (24%)
    /// and the total price (price + VAT) and prints the result, formated to 2 decimal places.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            const double VAT_RATE = 0.24D;

            double price = 0D;
            double vat = 0D;
            double totalPrice = 0D;


            Console.WriteLine("Please enter the price of the product");
            if (!double.TryParse(Console.ReadLine(), out price) || price < 0)
            {
                Console.WriteLine("Invalid input for price.");
                return;
            }

            vat = price * VAT_RATE;
            totalPrice = price + vat;

            Console.WriteLine($"{"Vat:", -15} {vat, -15:N2} ");
            Console.WriteLine($"{"Total Price:",-15} {totalPrice,-15:N2} €");





        }
    }
}

