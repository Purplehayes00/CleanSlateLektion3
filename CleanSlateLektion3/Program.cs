using System;
using System.Linq;

namespace CleanSlateLektion3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning två

            int[] firstOne = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
           // int[] secondOne = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

           // Console.WriteLine(string.Join(',', firstOne));
            // Console.WriteLine(string.Join(',', secondOne));

            //Ett annat sätt för samma

            Console.WriteLine(string.Join(',', firstOne));
            Console.WriteLine(string.Join(',', firstOne.Reverse));
        }
    }
}
