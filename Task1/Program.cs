namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallCarpetPrice = 25;
            int largeCarpetPrice = 35;

            Console.WriteLine("Number of small carpet ?");
            double countSmallCarpet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Number of large carpet ?");
            double countLargeCarpet = Convert.ToDouble(Console.ReadLine());

            double SmallPriceTottal = smallCarpetPrice * countSmallCarpet;
            double largePriceTottal = largeCarpetPrice * countLargeCarpet;
            double coast = SmallPriceTottal + largePriceTottal;
            double taxes = coast * 6 / 100;
            double totalPrice = coast + taxes;

            Console.WriteLine("Price per small room: $25");
            Console.WriteLine("Price per large room: $35");
            Console.WriteLine($"coast: {coast}$");
            Console.WriteLine($"coast: {taxes}$");
            Console.WriteLine("================================");
            Console.WriteLine($"Total estimate: {totalPrice}$ ");
            Console.WriteLine("This estimate is valid for 30 days");
            Console.WriteLine("================================");
            int X = 10;
            int Y = 20;
            Console.WriteLine($"Equation: {X} + {Y} = {X + Y:C}");

        }
    }
}
