using System;
using HomeTask8.Model;

namespace HomeTask8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "..\\..\\..\\Data\\Task8.json";
            ProcessInput input = new ProcessInput();
            input.PrintShipment(path);

        }
    }
}
