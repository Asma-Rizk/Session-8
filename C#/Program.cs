using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello!");
        Console.Write("Input the first number: ");
        double num1;
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }
        Console.Write("Input the second number: ");
        double num2;
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }
        Console.WriteLine("What do you want to do with those numbers?");
        Console.WriteLine("Add\nSubtract\nMultiply");
        string choice = Console.ReadLine().ToLower();

        switch (choice)
        {
            case "a":
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;

            case "s":
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;

            case "m":
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;

            default:
                Console.WriteLine("Invalid option");
                break;
        }
        Console.WriteLine("Press any key to close");
        Console.ReadKey();
    }
}
