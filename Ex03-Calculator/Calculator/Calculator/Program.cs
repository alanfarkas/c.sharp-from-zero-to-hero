using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int parm1, parm2;
            float result = 0;
            Char op = ' ';

            // Get parm values & operator
            Console.WriteLine("Enter first parameter:");
            parm1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter second parameter:");
            parm2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter operator:");
            op = Convert.ToChar(Console.ReadLine());


            // Perform calculation & output result
            switch(op)
            {
                case '+':
                    result = parm1 + parm2;
                    Console.WriteLine("\n{0} + {1} = {2}", parm1, parm2, result);
                    break;
            }


            // Pause to read result
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
   
        }
    }
}
