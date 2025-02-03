using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Flow_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Task Manager");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the task description: ");
                        string task = Console.ReadLine();
                        tasks.Add(task);
                        Console.WriteLine("Task added successfully.");
                        break;

                    case "2":
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("No tasks available.");
                        }
                        else
                        {
                            Console.WriteLine("Tasks:");
                            for (int i = 0; i < tasks.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {tasks[i]}");
                            }
                        }
                        break;

                    case "3":
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("No tasks available to remove.");
                        }
                        else
                        {
                            Console.Write("Enter the task number to remove: ");
                            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
                            {
                                tasks.RemoveAt(taskNumber - 1);
                                Console.WriteLine("Task removed successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid task number.");
                            }
                        }
                        break;

                    case "4":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Exiting Task Manager. Goodbye!");
        }
    }
}
