using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class TaskCalculator
{
    const int MAX_WORK_HOURS = 8;
    public static long CalculateTotalDuration(List<Task> list)
    {
        long total = 0;

        foreach (Task task in list)
        {
            total += task.Duration;
        }

        return total;
    }

    public static List<Task> calculateTaskForDays(List<Task> list, int days)
    {
        List<Task> resultList = new List<Task>();
        list.Sort(CompareTasksPriorities);

        int maxPossibleHours = MAX_WORK_HOURS * days;
        int resultHours = 0;

        foreach (Task task in list)
        {
            if (resultHours + task.Duration <= maxPossibleHours)
            {
                resultHours += task.Duration;
                resultList.Add(task);
            }
            else
            {
                break;
            }

        }

        return resultList;

    }
    public static int CompareTasksPriorities(Task t1, Task t2)
    {
        var firstCompare = t1.Priority.CompareTo(t2.Priority);
        return firstCompare != 0 ? firstCompare : t2.Duration.CompareTo(t1.Duration);
    }

}

