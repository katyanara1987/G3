using System;
using System.Collections.Generic;
using System.Text;

public class Calculator
{
    public double Add(double x, double y)
    {
        return x + y;
    }

    public double Substruct(double x, double y)
    {
        return x - y;
    }

    public string Divide(double x, double y)
    {
        if (y == 0)
        {
            return "Can't divide to Zero";
        }

        return Convert.ToString(x / y);
    }

    public double Multiply(double x, double y)
    {
        return x * y;
    }

}
