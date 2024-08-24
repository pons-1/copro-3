using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            // Array to store grades
            int[] grades = new int[5];

            // Ask the user to enter five grades
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            // Compute the average of the grades
            double average = ComputeAverage(grades);

            // Round off the average using Math class
            double roundedAverage = Math.Round(average);

            // Display the results
            Console.WriteLine("\nThe average of the grades is: " + average.ToString("F2"));
            Console.WriteLine("The rounded average is: " + roundedAverage);

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }

        static double ComputeAverage(int[] grades)
        {
            int sum = 0;

            // Calculate the sum of all grades
            foreach (int grade in grades)
            {
                sum += grade;
            }

            // Compute the average
            return (double)sum / grades.Length;
        }
    }
}
