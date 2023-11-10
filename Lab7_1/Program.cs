using Lab7_1;

class Program
{
    static void Main()
    {
        Calculator<int> intCalculator = new Calculator<int>();
        Console.WriteLine("Integer calculations:");
        Console.WriteLine($"Addition: {intCalculator.PerformAddition(5, 3)}");
        Console.WriteLine($"Subtraction: {intCalculator.PerformSubtraction(5, 3)}");
        Console.WriteLine($"Multiplication: {intCalculator.PerformMultiplication(5, 3)}");
        Console.WriteLine($"Division: {intCalculator.PerformDivision(5, 3)}");

        Calculator<double> doubleCalculator = new Calculator<double>();
        Console.WriteLine("\nDouble calculations:");
        Console.WriteLine($"Addition: {doubleCalculator.PerformAddition(5.5, 3.2)}");
        Console.WriteLine($"Subtraction: {doubleCalculator.PerformSubtraction(5.5, 3.2)}");
        Console.WriteLine($"Multiplication: {doubleCalculator.PerformMultiplication(5.5, 3.2)}");
        Console.WriteLine($"Division: {doubleCalculator.PerformDivision(5.5, 3.2)}");
    }
}