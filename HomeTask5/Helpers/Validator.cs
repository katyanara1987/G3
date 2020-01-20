using System;
using System.Collections.Generic;
using System.Text;

public static class Validator
{
    public static bool ValidatePriorityOrComplexity(String inputValue)
    {
        int outputValue;

        if (string.IsNullOrEmpty(inputValue) || (!int.TryParse(inputValue, out outputValue) || outputValue != 1 && outputValue != 2 && outputValue != 3))
        {
            return false;
        }
        
        return true;
    }

 /*   public static bool ValidateComplexity(String inputValue)
    {
        int outputValue;

        if (string.IsNullOrEmpty(inputValue) || (!int.TryParse(inputValue, out outputValue) || outputValue != 1 && outputValue != 2 && outputValue != 4))
        {
            return false;
        }        

        return true;
    }
 */

    public static bool ValidateDays(String inputValue)
    {
        int outputValue = 0;

        if (string.IsNullOrEmpty(inputValue) || (!int.TryParse(inputValue, out outputValue) || outputValue <=0))
        {
            return false;
        }

        return true;
    }
}

