using System;

public class Randomizer
{
    private const double MIN_VALUE = 0.5;
    private const double MAX_VALUE = 5;

    //Generates random in range [0.5; 5);
    public static double getRandomValue()
    {
        // generates from 0.0 to 3.0
        Random random = new Random();
        double value = 0;

        do {
            value = random.NextDouble() * MAX_VALUE;
        }
        while (value < MIN_VALUE);

        return value;
    }

}
