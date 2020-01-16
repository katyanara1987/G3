using System;

namespace HomeTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application has started.");
            ConsoleKeyInfo ExitCriteria;

            for (int i = 0; i < 20; i++){
                Console.WriteLine("Please input something...");

                String input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    if (Polyndrom.isPolyndrom(input))
                    {
                        Console.WriteLine("Your input is a polyndrom.");
                    }
                    else
                    {
                        Console.WriteLine("Your input is not a polyndrom.");
                    }
                }
                else {
                    Console.WriteLine("Empty input.");
                }
                    

                Console.WriteLine("Do you want to try again? Press 'N' to Exit or any other key to Continue.");

                ExitCriteria = Console.ReadKey();
                if (ExitCriteria.KeyChar == 'N' || ExitCriteria.KeyChar == 'n')
                    break;
            }

            Console.WriteLine("Application has ended.");
        }
    }
}
