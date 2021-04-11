using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Numerics;

namespace If_And_Else_If___Try_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();

            int numTemp;
            int number;
            if (int.TryParse(temperature,out number))
                numTemp = number;
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered is not number, set to 0.");
            }
                

            if (numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }else if (numTemp == 20)
            {
                Console.WriteLine("Pants and Pull Over should be fine");
            }else if (numTemp > 20)
            {
                Console.WriteLine("Shorts are enough today");
            }

            Console.Read();
        }
    }
}
