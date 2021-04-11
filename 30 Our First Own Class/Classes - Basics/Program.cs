using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Human sissy = new Human("Sissy", "Wagner");
            Human harsh = new Human("Harsh", "Verma");
            sissy.IntroduceMyself();
            harsh.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
