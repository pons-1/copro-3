using System;

namespace DataTypesApp
{
    class DataTypesProgram
    {
        static void Main(string[] args)
        {
            // Ask the user to enter the pieces of apple
            Console.Write("Enter the number of pieces of apple: ");
            int appleCount = int.Parse(Console.ReadLine());

            // Ask the user to enter the total price of the apple(s)
            Console.Write("Enter the total price of the apples: ");
            decimal totalPrice = decimal.Parse(Console.ReadLine());

            // Print the total price of the entered pieces of apple(s)
            Console.WriteLine("\nThe total price for " + appleCount + " pieces of apple(s) is $" + totalPrice.ToString("F2") + ".");

            // Convert the entered price into a whole number
            int convertedPrice = (int)totalPrice;

            // Display the values of the original price and the converted price
            Console.WriteLine("Original price: $" + totalPrice.ToString("F2"));
            Console.WriteLine("Converted price (whole number): $" + convertedPrice);

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}

