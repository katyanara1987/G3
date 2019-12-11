using System;

public class InputProcessor
{

    public double takeConsoleInput()
    {
        String inputValue = null;
        double inputValueParsed = 0;

        for (int i = 0; i < 3; i++)
        {
            if (i != 0)
            {
                Console.WriteLine("Please try again. You have " + (3 - i) + " attempt(-s) left.");
            }
            Console.WriteLine("Please enter numeric value.");

            inputValue = Console.ReadLine();

            if (Validator.ValidateInput(inputValue)) {
                inputValueParsed = Math.Round(double.Parse(inputValue), 2);
                return inputValueParsed;
            }
        }


            inputValueParsed = Math.Round(Randomizer.getRandomValue(), 2);
            Console.WriteLine("Ok, we will take random value: " + inputValueParsed);
        

        return inputValueParsed;
    }

}
