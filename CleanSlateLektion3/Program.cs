using System;
using System.Linq;

namespace CleanSlateLektion3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning två

            // int[] firstOne = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // int[] secondOne = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            // Console.WriteLine(string.Join(',', firstOne));
            // Console.WriteLine(string.Join(',', secondOne));

            //Ett annat sätt för samma

            //Console.WriteLine(string.Join(',', firstOne));
            //Console.WriteLine(string.Join(',', firstOne.Reverse));
            //int a;
            //int yes;

            string[] stringArray = new string[]
                {"January" +
                "Febuary" +
                "mars" +
                "april" +
                "maj" +
                "juni" +
                "juli" +
                "augusti" +
                "september" +
                "oktober" +
                "november" +
                "december" 
                 };
            string number;
            int choice;

            do
            {
                Console.WriteLine("Skriv ett nummer från 1-12");
                number = Console.ReadLine();
                choice = Convert.ToInt32(number);
                if (choice <=12)
                {
                    Console.WriteLine(stringArray[choice -1]);
                }

            } while (choice < 12);


 
        }
    }
}
