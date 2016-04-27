using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = "", strippedText, reverseText;

            // Loop until user just presses enter without any other input
            do
            {
                // Get input from user
                Console.WriteLine("\n\nEnter the palindrome to verify:");
                text = Console.ReadLine();

                // Check if entered text is a palindrome
                if (text.Length > 0)
                {
                    // Strip off spaces
                    strippedText = text.Replace(" ", string.Empty);

                    // Reverse text
                    char[] charAr = strippedText.ToCharArray();
                    Array.Reverse(charAr);
                    reverseText = new string(charAr);

                    // Validate and output findings
                    if (strippedText.Equals(reverseText))
                    {
                        Console.WriteLine("\n{0} is a palindrome!", text);
                    }
                    else
                    {
                        Console.WriteLine("\n{0} is NOT a palindrome!!", text);
                    }
                }

            } while (text != "");
        }
    }
}
