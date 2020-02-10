using System;
using System.Collections.Generic;

namespace HomeTask7
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Kateryna.Nesterova\\Desktop\\Automation\\G3\\HomeTask7\\Data\\EU_Countries.txt";

            FileProcessor file = new FileProcessor();
            Dictionary<int, Country> data = new Dictionary<int, Country>();
            data = file.ReadFile(path);

            Console.WriteLine("Initial file state:");
            file.PrintFile(data);

            Console.WriteLine("Press Any key to continue...");
            Console.ReadKey();

            Console.WriteLine("Step1. Add Ukraine to the file. Press Any key to continue...");
            Console.ReadKey();

            Country country = new Country("Украина", false);
            int key = data.Keys.Count;
            data.Add(++key, country);
            file.WriteFile(path, data);

            Console.WriteLine("Step2. Set IsTelenorSupported = true for Danmark and Hungary. Press Any key to continue...");
            Console.ReadKey();
            foreach (var row in data)
            {
                if (row.Value.Name.Equals("Дания") || row.Value.Name.Equals("Венгрия"))
                {
                    row.Value.IsTelenorSupported = true;
                }                        
            }
            file.WriteFile(path, data);

            Console.WriteLine("Result file state:");
            file.PrintFile(data);
            Console.WriteLine("Press Any key to continue...");
            Console.ReadKey();

            Console.WriteLine("Step3. Print countries with IsTelenorSupported == false. Press Any key to continue...");
            Console.ReadKey();
            foreach (var row in data)
            {
                if (row.Value.IsTelenorSupported == false)
                {
                    Console.WriteLine(row.Value.Name);
                }
                
            }


        }
    }
}
