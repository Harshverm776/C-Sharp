using System;

namespace Excercise_String_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            Console.Write("Please enter your name and press enter : ");
            myName = Console.ReadLine();
            string myNameUpperCase = String.Format("Upper case : {0}", myName.ToUpper());
            string myNameLowerCase = String.Format("Lower case : {0}", myName.ToLower());
            string myNameTrimmed = String.Format("Trimmed value : {0}", myName.Trim());
            string myNameSubString = String.Format("Substring value : {0}", myName.Substring(0, 5));

            Console.WriteLine(myNameUpperCase);
            Console.WriteLine(myNameLowerCase);
            Console.WriteLine(myNameTrimmed);
            Console.WriteLine(myNameSubString);

            Console.Read();
        }
    }
}
