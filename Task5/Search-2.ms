using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();
            
            CheckVowels(userInput);
            Console.WriteLine("The string contains vowels.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void CheckVowels(string text)
    {
        bool foundVowel = false;
        string vowels = "aeiouAEIOU";

        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < vowels.Length; j++)
            {
                if (text[i] == vowels[j])
                {
                    foundVowel = true;
                    break;
                }
            }
            if (foundVowel) break;
        }
        if (foundVowel == false)
        {
            throw new Exception("No vowels found in the string!");
        }
    }
}
