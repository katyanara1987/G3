using System;
using System.Collections.Generic;
using System.Text;

public static class Validations
{
    public static bool ValidateDays(String inputValue)
    {
        int outputValue = 0;

        if (!int.TryParse(inputValue, out outputValue) || outputValue <=0)
        {
            return false;
        }

        return true;
    }
}

