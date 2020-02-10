using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HomeTask7
{
    public class FileProcessor
    {
        public Dictionary<int, Country> ReadFile(string location)
        {
            Dictionary<int, Country> parsedFile = new Dictionary<int, Country>();
            StreamReader sr = new StreamReader(location, Encoding.Default);
            string input = sr.ReadLine();
            string[] fields;
            int key = 0;

            while (input != null) 
            {
                Country country = new Country();
                key++;
                fields = input.Split(' ');
                country.Name = fields[0];
                country.IsTelenorSupported = Convert.ToBoolean(fields[1]);                
                parsedFile.Add(key, country);
                input = sr.ReadLine();
            }
                sr.Close();
                return parsedFile;
        }

        public void WriteFile(string location, Dictionary<int, Country> data)
        {
            StreamWriter sw = new StreamWriter(location);

            foreach(var row in data) 
            {
                sw.WriteLine($"{row.Value.Name} {row.Value.IsTelenorSupported}");
            }

            sw.Close();
        }

        public void PrintFile(Dictionary<int, Country> inputData)
        {
            foreach (var row in inputData)
            {
                Console.WriteLine("{0} - {1} {2}", row.Key, row.Value.Name, row.Value.IsTelenorSupported);
            }
        }
    }
}
