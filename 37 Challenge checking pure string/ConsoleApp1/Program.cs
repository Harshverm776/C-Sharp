using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write  something :");
            string s = Console.ReadLine();

            //checking fully alphabetic or not

            // Note ' ' is not a valid IsLetter
            Console.WriteLine("It is a completely alphabetic - {0}",alphabetic(s));
            Console.WriteLine(char.IsLetter(' '));
            Console.ReadKey();
        }

        public static bool alphabetic(string s)
        {
            foreach(char c in s)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }
    }

}
