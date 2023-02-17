using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int i = 1;
            //while (i <=5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            int[] luckyNumbers = { 5, 7, 55, 99, 19 };
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
            Console.ReadLine(); 

        }
    }
}
