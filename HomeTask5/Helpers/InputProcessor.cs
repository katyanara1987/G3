using HomeTask5.Enums;
using HomeTask5.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

public class InputProcessor
{
    public List<Task> Tasks = new List<Task>();


    public void ProcessInput()
    {
        Answers answer = Answers.Yes;
        Console.WriteLine("Please, enter task");
        while (answer == Answers.Yes)
        {
            AddTask();
            Console.Clear();
            Console.WriteLine("Do you want add another task?");
            answer = EnumHelper.RequestForEnumValue<Answers>();
        }
       
    }

    public void AddTask()
    {
        Console.WriteLine("Enter complexity");
        Complexity complexity = EnumHelper.RequestForEnumValue<Complexity>();
        Console.WriteLine("Enter priority");
        Priority priority = EnumHelper.RequestForEnumValue<Priority>();
        Console.WriteLine("enter description");
        string name = Console.ReadLine();
        Task task = new Task(name, priority, complexity);
        Tasks.Add(task);

        int duration = EnumHelper.GetEnumValueAttribute(task.Complexity);
    }

    private Task ProcessTaskInput(String taskName)
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
                //duration = ComplexityHours.GetValueOrDefault<string, int>(value);
            }
            else
            {
                Console.WriteLine("You've entered wrong number.");
                value = null;
            }
        }

        //if (priority != 0 && duration != 0)
        //{
        //    task = new Task(taskName, priority, duration);
        //}

        return task;

    }
    public int ProcessPriorityInput()
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

    public int ProcessDaysInput()
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

