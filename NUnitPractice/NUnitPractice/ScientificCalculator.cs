using System;
using System.Collections.Generic;
using System.Text;

public class ScientificCalculator : Calculator
{
    public double Pow(double x, double y)
    {
        return Math.Pow(x, y);
    }

    public double Percents(double x, double y)
    {
        return x * y / 100;
    }

    public int Max(List<int> x)
    {
        int max = 0;
        for (int i = 0; i < x.Count; i++)
        {
            max = Math.Max(max, x[i]);
        }
        return max;

    }

    public double Sum(List<int> x)
    {
        int sum = 0;
        for (int i = 0; i < x.Count; i++)
        {
            sum += x[i];
        }
        return sum;
    }

}

