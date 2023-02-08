// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //first class

            //string characterName = "John";
            //int characterAge;
            //characterAge = 35; 
            //Console.WriteLine("My name is " + characterName);
            //Console.WriteLine("Age is" + characterAge + " years old");
            //Console.WriteLine(" /");
            //Console.WriteLine("/");

            //core data types

            //string phrase = "Jay's Academy";
            //char grade = 'A'; // character, only can put 1 word with '
            //int age = 30; // no quotation mark needed
            ////float, double, decimal // decimal points can be stored >>>
            //double gpa = 4.3;
            //bool isGeninus = true; //true or false 

            //Strings
            //Console.WriteLine("write\n write please");
            //Console.WriteLine("\"write\" write please");
            //string coding = "coding" + "isfun";
            //Console.WriteLine(coding.Length); // get the length of the string
            //Console.WriteLine( coding.ToUpper() );
            //Console.WriteLine( coding.Contains("Academy") );
            //Console.WriteLine(coding[0]);
            //Console.WriteLine(coding.IndexOf("is"));
            //Console.WriteLine(coding.Substring(8,3));


            //Console.WriteLine("?");
            //Console.WriteLine( Math.Abs(-40) );
            //
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello" + name);
            Console.ReadLine();
        }
    }
}