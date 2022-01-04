/*
 * Positive, Negative, or Zero
 * Pawelski
 * 1/3/2022
 * Read the code and run the program a few times so you understand
 * what the program does and how it works. Once you understand what
 * the program does and how it works, answer the questions found
 * on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveNegativeZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number >> ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine(number + " is negative.");
            }
            else if (number > 0)
            {
                Console.WriteLine(number + " is positive.");
            }
            else
            {
                Console.WriteLine(number + " is niether positive or negative.");
            }
        }
    }
}
