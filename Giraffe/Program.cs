// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int index = 1;
            while(index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.ReadLine();
    
        }

    }
}