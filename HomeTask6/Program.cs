using System;
using HomeTask6.Model;

namespace HomeTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new SimpleGarland(12);


            Console.WriteLine("Enter number of bulbs in Garland:");
            string bulbsNumber = Console.ReadLine();

            Console.WriteLine("Current state of Simple Garland:");
            SimpleGarland garland = new SimpleGarland(int.Parse(bulbsNumber));
            foreach (Bulb bulb in garland.GetBulbs())
            {
                Console.WriteLine(bulb.State);
            }
        }
    }
}
