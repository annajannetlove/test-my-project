using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");

        string operation = Console.ReadLine();

        double result = 0;

        switch (operation)
        {
            case "1":
                result = num1 + num2;
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;
            case "2":
                result = num1 - num2;
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;
            case "3":
                result = num1 * num2;
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;
            case "4":
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
