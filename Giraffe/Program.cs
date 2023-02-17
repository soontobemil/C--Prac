using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(FormatException e) // diff types of exception is avaliable 
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally //will get executed no matter what
            {
                Console.WriteLine("Program is ending");
            }
            Console.ReadLine();
        }
    }
}
