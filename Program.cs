// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Enter a number:");

int.TryParse(Console.ReadLine(), out int number);

Console.WriteLine(IfNumberContains3(number));

static bool IfNumberContains3 (int number)
{
    while (number > 0)
    {
        int digit = number % 10; // Get the last digit
        if (digit == 3)
        {
            return true; // Found the digit 3
        }
        number /= 10; // Remove the last digit
    }
    return false; // Digit 3 not found
}