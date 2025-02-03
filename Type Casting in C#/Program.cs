using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intNum = 123;
            double doubleNum = intNum;
            Console.WriteLine($"Implicit casting: int {intNum} to double {doubleNum}");

            // Explicit casting
            doubleNum = 123.45;
            intNum = (int)doubleNum;
            Console.WriteLine($"Explicit casting: double {doubleNum} to int {intNum}");

            // Using Convert class
            string strNum = "123";
            intNum = Convert.ToInt32(strNum);
            Console.WriteLine($"Convert class: string \"{strNum}\" to int {intNum}");

            // Using Parse method
            strNum = "456";
            intNum = int.Parse(strNum);
            Console.WriteLine($"Parse method: string \"{strNum}\" to int {intNum}");

            // Using TryParse method
            strNum = "789";
            bool success = int.TryParse(strNum, out intNum);
            if (success)
            {
                Console.WriteLine($"TryParse method: string \"{strNum}\" to int {intNum}");
            }
            else
            {
                Console.WriteLine("TryParse method: Conversion failed.");
            }
        }
    }
}
