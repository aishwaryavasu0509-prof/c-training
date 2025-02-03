using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Properties_of_the_Console_Class_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set the title of the console window
            Console.Title = "My Console App";

            // Set the foreground and background colors
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            // Clear the console to apply the background color
            Console.Clear();

            // Write a message to the console
            Console.WriteLine("Hello, World!");

            // Write without a newline
            Console.Write("This is on the same line.");

            // Read a single character from the input
            Console.WriteLine("\nPress any key to continue...");
            int inputChar = Console.Read();
            Console.WriteLine($"You pressed: {(char)inputChar}");

            // Read a line of text from the input
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");

            // Play a beep sound
            Console.Beep();

            // Set the cursor position
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("This text is at position (0, 10)");

            // Read a key press
            Console.WriteLine("Press any key to exit...");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine($"\nYou pressed: {keyInfo.Key}");

            // Set the window size
            Console.WindowWidth = 100;
            Console.WindowHeight = 30;

            // Set the buffer size
            Console.BufferWidth = 120;
            Console.BufferHeight = 300;

            // Toggle cursor visibility
            Console.CursorVisible = false;
            Console.WriteLine("Cursor is now hidden. Press any key to show it again...");
            Console.ReadKey();
            Console.CursorVisible = true;

            // Reset the console colors to their defaults
            Console.ResetColor();
        }
    }
}
