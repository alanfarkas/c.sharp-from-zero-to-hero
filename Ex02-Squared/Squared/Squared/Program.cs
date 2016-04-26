using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squared
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, ans = 0;

            Console.WriteLine("Enter a number to square:");
            num = Convert.ToInt32(Console.ReadLine());
            ans = num * num;
            Console.WriteLine("\n{0} Squared is: {1}", num, ans);
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
