using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask4
{
    public class Polyndrom
    {
        public static bool isPolyndrom(String input) {
         
                for (int i = 0; i < input.Length / 2; i++)
                {
                    if (input[i] != input[input.Length - 1 - i])
                    {
                        return false;
                    }
                }
           
            return true;
        }
    }
}
