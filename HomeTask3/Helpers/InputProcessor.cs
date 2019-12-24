using System;
using System.Collections.Generic;
using System.Text;

public class InputProcessor
{

    public int TakeConsoleInput()
    {
        string inputValue = null;
        int returnValue = 0;

        for (int i = 0; i < 3; i++) {

            inputValue = Console.ReadLine();

            if (Validator.ValidateInput(inputValue))
            {
                return int.Parse(inputValue);
            }
        }

        Console.WriteLine("Value is set to 0");

        return returnValue;
    }
}
