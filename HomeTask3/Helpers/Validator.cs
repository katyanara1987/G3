using System;

public class Validator
{
    public static bool ValidateInput(String inputValue)
    {
        bool isValid = !string.IsNullOrEmpty(inputValue) && int.TryParse(inputValue, out var parsedValue1) && parsedValue1 >= 0;
        if (!isValid)
        {
            Console.WriteLine("You have entered invalid value!");
        }
        return isValid;
    }

}
