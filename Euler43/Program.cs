/*
The number, 1406357289, is a 0 to 9 pandigital number because it is made up of each of the digits 0 to 9 in some order, but it also has a rather interesting sub-string divisibility property.

Let d1 be the 1st digit, d2 be the 2nd digit, and so on. In this way, we note the following:

d2d3d4=406 is divisible by 2
d3d4d5=063 is divisible by 3
d4d5d6=635 is divisible by 5
d5d6d7=357 is divisible by 7
d6d7d8=572 is divisible by 11
d7d8d9=728 is divisible by 13
d8d9d10=289 is divisible by 17
Find the sum of all 0 to 9 pandigital numbers with this property.

int[] multiples = { 1, 2, 3, 5, 7, 11, 13, 17 } represents the divisible 

It take about 3ms - 4ms to finnish on my laptop. to complete
To eliminate unwanted items the code uses:
-each multiple to first set up all the possible 3 digits form 0 to 999
-bit search implented with a array, (int[] usedcheck = new int[10];) to indicate which
integers are used, and eliminate 3 digit integer with non unique integers
-quadratic search with two for loop on prefiltered values

*/
using System;
using System.Diagnostics;

namespace Euler43
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch sw = new Stopwatch();
            sw.Start();
            //****************Search start********************
            int[] conditions = { 1, 2, 3, 5, 7, 11, 13, 17 };
            Pandigitalmanager Pandidgitalten = new Pandigitalmanager(conditions);
            Int64 answer = Pandidgitalten.Getsum();
            //****************Search end***********************
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds.ToString() + "ms to run.");

            Console.WriteLine(answer);
            Console.WriteLine();
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
