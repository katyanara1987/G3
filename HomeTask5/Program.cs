using HomeTask5.Enums;
using HomeTask5.Helpers;
using System;
using System.Collections.Generic;

namespace HomeTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application start.");
            InputProcessor processor = new InputProcessor();
            TaskCalculator calculations = new TaskCalculator();
            List<Task> list = processor.ProcessInput();

            Console.WriteLine($"For all your tasks you need {calculations.CalculateTotalDuration(list)} hours");
            Console.WriteLine("\n Press Any key to continue...");
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("Enter priority and see what tasks correspond to it.");
            
            Priority priority = EnumHelper.RequestForEnumValue<Priority>();
            foreach (Task task in list)
            {
                if (task.Priority == priority)
                {
                    Console.WriteLine(task.Name);
                }
            }

            Console.WriteLine("\n Press Any key to continue...");
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("Now you need to enter amount of days to get list of tasks that can be done.");
            
            int days = processor.ProcessDaysInput();
            Console.WriteLine($"Next tasks could be done on {days} days:");
            calculations.CalculateTaskForDays(list, days);

            Console.WriteLine("Application end.");
        }
    }
}
