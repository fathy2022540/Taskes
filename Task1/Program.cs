namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Islam's Carpet Cleaning Service");

            Console.Write("Please Enter The Number Of Small Carpets: ");

            int numSmall=Convert.ToInt32( Console.ReadLine());

            Console.Write("Please Enter The Number Of Large Carpets: ");

            int numLarge = Convert.ToInt32(Console.ReadLine());

            int costSmall = 25;
            int costLarge = 35;
            double tax = 0.06;

            Console.WriteLine($"Price Per Small Carpet : ${costSmall}");
            Console.WriteLine($"Price Per Large Carpet: ${costLarge}");
            

            int totalCost =(numSmall * costSmall) + (numLarge * costLarge);
            double totalTax = totalCost * tax;

            Console.WriteLine($"Cost : ${totalCost}");
            Console.WriteLine($"Tax : ${totalTax}");

            double totalEstimate = totalCost + totalTax;
            Console.WriteLine($"Total estimate: ${totalEstimate}");
            Console.WriteLine("This estimate is valid for 30 days");

        }
    }
}
