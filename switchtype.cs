namespace ConsoleApp.CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter Started");
            Console.WriteLine("Choose 1. Fahrenheit to Celsisus");
            Console.WriteLine("Choose 1. Celsisus to Fahrenheit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    Console.Write("Enter Fahrenheit temperature: ");
                    double fahrenheit = Convert.ToDouble(Console.ReadLine());
                    double celsisus = (fahrenheit - 32) / 1.8;
                    Console.Write($"Temperature in Celsisus : {celsisus:F2}");
                    break;

                case 2:
                    Console.Write("Enter Celsisus temperature: ");
                    double cels = Convert.ToDouble(Console.ReadLine());
                    double fahr = cels * 1.8 + 32;
                    Console.Write($"Temperature in Fahrenheit {fahr:F2}");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;


            }
        }

    }
}
