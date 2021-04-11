using System;

namespace Properties_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            Box box1 = new Box(50,60);

            box.height = 20;
            box.Length = 30;

            // accessing rproperties
            Console.WriteLine("L= {0} B= {1}", box.height, box.Length);
            Console.WriteLine("L= {0} B= {1}", box1.height, box1.Length);
            Console.Read();
        }
    }
}
