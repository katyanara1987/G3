﻿using HomeTask5.Enums;
using HomeTask5.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

public class InputProcessor
{



    public List<Task> ProcessInput()
    {
        List<Task> Tasks = new List<Task>();
        Answers answer = Answers.Yes;
        Console.WriteLine("Please, enter your tasks.");
        while (answer == Answers.Yes)
        {
            AddTask(Tasks);
            Console.WriteLine("Do you want to add another task?");
            answer = EnumHelper.RequestForEnumValue<Answers>();
            Console.Clear();
        }

        return Tasks;
    }

    public void AddTask(List<Task> tasks)
    {
        Console.WriteLine("Enter title.");
        string name = Console.ReadLine();
        Console.WriteLine("Enter complexity.");
        Complexity complexity = EnumHelper.RequestForEnumValue<Complexity>();
        Console.WriteLine("Enter priority.");
        Priority priority = EnumHelper.RequestForEnumValue<Priority>();

        Task task = new Task(name, priority, complexity);
        tasks.Add(task);
    }

   /* private Task ProcessTaskInput(String taskName)
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
    */
    public int ProcessDaysInput()
    {
        int days = 0;

        String value = null;
        while (string.IsNullOrEmpty(value))
        {
            value = Console.ReadLine();
            if (Validations.ValidateDays(value))
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

