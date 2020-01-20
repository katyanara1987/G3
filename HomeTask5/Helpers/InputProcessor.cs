using System;
using System.Collections.Generic;
using System.Text;

public class InputProcessor
{

    static Dictionary<string, int> ComplexityHours = new Dictionary<string, int>()
    {
        { "1", 1 }, 
        { "2", 2 }, 
        { "3", 4 }
    };

    public static List<Task> ProcessInput()
    {
        List<Task> list = new List<Task>();
                       
        String taskName = null;

        do
        {
            Console.WriteLine("Please enter task name:");
            taskName = Console.ReadLine();
            if (!string.IsNullOrEmpty(taskName))
            {
            list.Add(ProcessTaskInput(taskName));
            }
        }
        while (!string.IsNullOrEmpty(taskName));

        return list;
    }

    private static Task ProcessTaskInput(String taskName)
    {
        Task task = null;
        int priority = 0;
        int duration = 0;

        // Priority part
        Console.WriteLine("Enter task priority. 1 - high, 2 - medium, 3 - low.");
        String value = null;

        priority = ProcessPriorityInput();

        // Duration part
        Console.WriteLine("Enter task complexity. 1 - Easy, 2 - Medium, 3 - Difficult.");
        value = null;
        while (string.IsNullOrEmpty(value))
        {
            value = Console.ReadLine();
            if (Validator.ValidatePriorityOrComplexity(value))
            {
                duration = ComplexityHours.GetValueOrDefault<string, int>(value);
            }
            else
            {
                Console.WriteLine("You've entered wrong number.");
                value = null;
            }
        }

        if (priority != 0 && duration != 0)
        {
            task = new Task(taskName, priority, duration);
        }
                        
        return task;

    }
    public static int ProcessPriorityInput()
    {
        int priority = 0;

        String value = null;
        while (string.IsNullOrEmpty(value))
        {
            value = Console.ReadLine();
            if (Validator.ValidatePriorityOrComplexity(value))
            {
                priority = int.Parse(value);
            }
            else
            {
                Console.WriteLine("You've entered wrong number.");
                value = null;
            }
        }

        return priority;
    }

    public static int ProcessDaysInput()
    {
        int days = 0;

        String value = null;
        while (string.IsNullOrEmpty(value))
        {
            value = Console.ReadLine();
            if (Validator.ValidateDays(value))
            {
                days = int.Parse(value);
            }
            else
            {
                Console.WriteLine("You've entered wrong number.");
                value = null;
            }
        }

        return days;

    }
}

