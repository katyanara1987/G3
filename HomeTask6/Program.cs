using System;
using HomeTask6.Model;
using System.Threading;

namespace HomeTask6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number of bulbs in Garland:");
            string bulbsNumber = Console.ReadLine();

            Console.WriteLine("Current state of Simple Garland:");
            SimpleGarland simpleGarland = new SimpleGarland(int.Parse(bulbsNumber));
            simpleGarland.PrintGarland();

            Console.WriteLine("Current state of Color Garland:");
            ColorGarland colorGarland = new ColorGarland(int.Parse(bulbsNumber));
            colorGarland.PrintGarland();
        }
    }
}
