using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finally_Block
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = null;

            try
            {
                // Attempt to open a file
                reader = new StreamReader("example.txt");
                string content = reader.ReadToEnd();
                Console.WriteLine("File content:");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: The file was not found.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            finally
            {
                // Ensure the StreamReader is closed
                if (reader != null)
                {
                    reader.Close();
                    Console.WriteLine("The file has been closed.");
                }
                Console.WriteLine("Execution of the try-catch-finally block is complete.");
            }
        }
    }
}