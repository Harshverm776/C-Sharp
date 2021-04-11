using System;

namespace Challenge_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Harsh";
            string friend2 = "Brijesh";
            string friend3 = "Durgesh";

            GreetFriends(friend1, friend2, friend3);
            Console.Read();
        }
        public static void GreetFriends(string f1, string f2, string f3)
        {
            Console.WriteLine("Hi " + f1 + ", my friend!");
            Console.WriteLine("Hi " + f2 + ", my friend!");
            Console.WriteLine("Hi " + f3 + ", my friend!");
            
        }
    }
}
