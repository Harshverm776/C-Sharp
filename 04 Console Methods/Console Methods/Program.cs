using System;

namespace Console_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Changing Console color
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

            //Methods
            Console.WriteLine("Hello World!");

            Console.Write("Hi there !!!!");

            string s = Console.ReadLine();
            Console.WriteLine("You have written - {0} ",s);

            int x = Console.Read();
            Console.WriteLine("You have written - {0} ", x);

            Console.ReadKey();
        }
    }
}
