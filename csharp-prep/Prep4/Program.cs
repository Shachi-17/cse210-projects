using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {

       List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input;
        
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0);

        // Core Requirement 1
        int sum = numbers.Sum();

        // Core Requirement 2
        double average = numbers.Average();

        // Core Requirement 3
        int max = numbers.Max();

    
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge 1
        int smallestPositive = numbers.Where(num => num > 0).DefaultIfEmpty(0).Min();

        // Stretch Challenge 2
        List<int> sortedNumbers = numbers.OrderBy(num => num).ToList();

        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is:");
        foreach (int num in sortedNumbers)
        {
            Console.WriteLine(num);

        }
    }


}