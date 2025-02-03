using System;

namespace stringmanipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to input a string
            Console.WriteLine("Please input the string:");
            string inputString = Console.ReadLine();

            // Convert the input string to uppercase
            string upperString = inputString.ToUpper();

            // Reverse the string
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);

            // Replace all spaces in the string with underscores (_)
            string replacedString = inputString.Replace(' ', '_');

            // Display the original and manipulated strings
            Console.WriteLine("Original String: " + inputString);
            Console.WriteLine("Uppercase: " + upperString);
            Console.WriteLine("Reversed: " + reversedString);
            Console.WriteLine("Spaces Replaced: " + replacedString);

            // Additional feature: Count the number of characters and words in the string
            int charCount = inputString.Length;
            int wordCount = inputString.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;

            Console.WriteLine("Number of Characters: " + charCount);
            Console.WriteLine("Number of Words: " + wordCount);

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
