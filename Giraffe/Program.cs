using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getPow(3, 2));

        static int getPow(int baseNum, int powNum)
            {
                int result = 1;

                for (int i = 0; i < powNum; i++)
                {
                    result = result * baseNum;
                }
                return result;
            }

            Console.ReadLine();
        }
    }
}
