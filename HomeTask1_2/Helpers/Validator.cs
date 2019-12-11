using System;

public class Validator
{

    private const double MAX_VALUE = 100000;

    public static bool ValidateInput(String inputValue)
    {
        bool result = true;
        double parsedValue = 0;

        if (string.IsNullOrEmpty(inputValue) || !double.TryParse(inputValue, out parsedValue) ||
             parsedValue <= 0 || parsedValue > MAX_VALUE)
        {
            Console.WriteLine("You have entered invalid value!");
            result = false;
        }

        return result;
    }

}
