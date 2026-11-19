
using System;

class Program
{
    static void Main(string[] args)
    {
        // Display the welcome message.
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Ask the user to enter the package weight.
        Console.WriteLine("Please enter the package weight:");
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // Check if the package weight exceeds 50.
        if (weight > 50)
        {
            // Display an error message and end the program.
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Ask the user to enter the package width.
        Console.WriteLine("Please enter the package width:");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        // Ask the user to enter the package height.
        Console.WriteLine("Please enter the package height:");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // Ask the user to enter the package length.
        Console.WriteLine("Please enter the package length:");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Calculate the total dimensions of the package.
        decimal totalDimensions = width + height + length;

        // Check if the combined dimensions exceed 50.
        if (totalDimensions > 50)
        {
            // Display an error message and end the program.
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate the shipping quote using the given formula.
        decimal shippingQuote = (height * width * length * weight) / 100m;

        // Display the calculated shipping quote in dollar format.
        Console.WriteLine("Your estimated total for shipping this package is: $" 
            + shippingQuote.ToString("F2"));

        // Display a thank-you message.
        Console.WriteLine("Thank you!");
    }
}

