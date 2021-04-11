using System;

namespace Datatype_String_And_Some_Of_Its
{
    class Program
    {
        static void Main(string[] args)
        {
            string myname = "Harsh";

            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();

            string lowerCaseMessage = message.ToLower();

            Console.WriteLine(lowerCaseMessage);
            Console.Read();
        }
    }
}
