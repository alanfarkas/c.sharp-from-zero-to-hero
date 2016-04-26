using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_Console
{
    class Hello
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");

            #if DEBUG
                Console.WriteLine("\nPress enter to close...");
                Console.ReadLine();
            #endif

        }
    }
}
