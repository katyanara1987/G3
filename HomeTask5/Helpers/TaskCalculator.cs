using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using HomeTask5.Helpers;

public class TaskCalculator
{
    const int MAX_WORK_HOURS = 8;
    public long CalculateTotalDuration(List<Task> list)
    {
        return list.Sum(x => EnumHelper.GetEnumValueAttribute(x.Complexity));
    }

    public void CalculateTaskForDays(List<Task> list, int days)
    {
        List<Task> resultList = list.OrderBy(x => x.Priority).ToList(); 

        int maxPossibleHours = MAX_WORK_HOURS * days, duration;        

        foreach (Task task in list)
        {
            duration = EnumHelper.GetEnumValueAttribute(task.Complexity);
            maxPossibleHours -= duration;
            if (maxPossibleHours >= 0)
            {
                Console.WriteLine($"Task priority: {task.Priority}, task name: {task.Name}, duration: {duration}");
            }
            else
            {
                break;
            }

        }
    }
}

