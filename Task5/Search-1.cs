using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter integers separated by spaces:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j] && !string.IsNullOrWhiteSpace(numbers[i]))
                    {
                        throw new Exception("Duplicate number detected: " + numbers[i]);
                    }
                }
            }
            Console.WriteLine("All numbers are unique!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
