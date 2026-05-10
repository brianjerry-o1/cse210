using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber = -1;

        // Keep asking until the user enters 0
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            // Do not add 0 to the list
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Variables for calculations
        int sum = 0;
        int largest = numbers[0];

        // Stretch challenge variable
        int smallestPositive = int.MaxValue;

        // Loop through the list
        foreach (int number in numbers)
        {
            // Calculate sum
            sum += number;

            // Find largest number
            if (number > largest)
            {
                largest = number;
            }

            // Find smallest positive number
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        // Calculate average
        double average = (double)sum / numbers.Count;

        // Display results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        // Stretch challenge output
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Sort the list
        numbers.Sort();

        Console.WriteLine("The sorted list is:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}