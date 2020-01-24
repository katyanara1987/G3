using HomeTask5.Enums;
using System;
using System.Collections.Generic;
using System.Text;

    public class Task   
    {
    public Task(string name, Priority priority, Complexity complexity) 
        {
            Name = name;
            Priority = priority;
            Complexity = complexity;
        }

    public string Name { get; private set; }

    public Priority Priority { get; private set; }

    public Complexity Complexity { get; private set; }

    public int Duration { get; set; }

}

