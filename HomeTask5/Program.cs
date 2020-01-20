using System;
using System.Collections.Generic;

namespace HomeTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application start.");
            Console.WriteLine("Step1. Please enter all TODO tasks. You can enter any amount of tasks you need.");
            Console.WriteLine("Enter empty task name when your list is finished.");                       

            List<Task> list = InputProcessor.ProcessInput();

            Console.WriteLine($"For all your tasks you need {TaskCalculator.CalculateTotalDuration(list)} hours");

            Console.WriteLine("\nStep2. Enter priority and see what tasks correspond to it.");

            int priority = InputProcessor.ProcessPriorityInput();

            foreach (Task task in list)
            {
                if (task.Priority == priority)
                
                {
                    Console.WriteLine(task.Name);
                }
            }

            Console.WriteLine("\nStep3. Now you need to enter amount of days to get list of tasks that can be done.");
            
            int days = InputProcessor.ProcessDaysInput();

            list = TaskCalculator.calculateTaskForDays(list, days);

            Console.WriteLine($"Next tasks could be done on {days} days:");

            foreach (Task task in list)
            {
                Console.WriteLine($"Task priority: {task.Priority}, task name: {task.Name}, duration: {task.Duration}");
            }

            Console.WriteLine("Application end.");
        }
    }
}
