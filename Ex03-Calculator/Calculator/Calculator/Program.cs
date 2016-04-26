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
            double num1, num2, result = 0;
            Char op = ' ';

            while (1 == 1)
            {
                // Get parm values & operator
                Console.WriteLine("\n\nEnter first number:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nEnter second number:");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nEnter operator (+, -, *, or /) :");
                op = Convert.ToChar(Console.ReadLine());


                // Perform calculation & output result
                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine("\n{0} {1} {2} = {3}", num1, op, num2, result);
                        break;

                    case '-':
                        result = num1 - num2;
                        Console.WriteLine("\n{0} {1} {2} = {3}", num1, op, num2, result);
                        break;

                    case '*':
                        result = num1 * num2;
                        Console.WriteLine("\n{0} {1} {2} = {3}", num1, op, num2, result);
                        break;

                    case '/':
                        result = num1 / num2;
                        Console.WriteLine("\n{0} {1} {2} = {3}", num1, op, num2, result);
                        break;

                    default:
                        Console.WriteLine("Invalid operator entered!!!");
                        break;
                }

            }


            // Pause to read result
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
   
        }
    }
}
