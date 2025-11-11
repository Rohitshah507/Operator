using System;

namespace OperatorsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance (object) of the Calculator class
            Calculator calc = new Calculator();

            // Declare variables
            int a = 10, b = 5;

            // 🧮 Call all Calculator methods
            Console.WriteLine("---- Calculator Operations ----");
            Console.WriteLine($"Addition of {a} and {b}: {calc.Add(a, b)}");
            Console.WriteLine($"Subtraction of {a} and {b}: {calc.Subtract(a, b)}");
            Console.WriteLine($"Multiplication of {a} and {b}: {calc.Multiply(a, b)}");
            Console.WriteLine($"Division of {a} and {b}: {calc.Divide(a, b)}");

            // 🔢 Call OddEvenFinder method
            Console.WriteLine("\n---- Odd or Even Check ----");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            calc.OddEvenFinder(number);

            Console.WriteLine("\nAll methods executed successfully!");
            Console.WriteLine("Press any key to exit...");

            NullOperations ops = new NullOperations();
            ops.PerformNullChecks();

            Console.ReadLine(); // keep console open
        }
    }
}