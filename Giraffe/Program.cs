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

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello" + name);
            //Console.ReadLine();

            //int num = Convert.ToInt32("48");
            //Console.WriteLine(num + 2);
            //Console.Write("Enter a number ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine(num1);    
            //string color;

            //Console.Write("Enter a color: ");
            //color = Console.ReadLine();
            //Console.WriteLine("Roses are " + color);

            //array
            //int[] luckyNumbers = { 4, 8, 15, 23, 49, 122};
            //luckyNumbers[0] = 9000;
            //string[] friends = new string[10];
            //friends[0] = "Jay";
            //Console.WriteLine(luckyNumbers[0]);

            //method

            //    SayHi("Mike", 55);
            //    SayHi("Jay", 25);
            //    Console.ReadLine();
            //}

            //static void SayHi(string name, int age)
            //{
            //    Console.WriteLine("Hello " + name  + age);
            //}

            //int cubenumber = cube(5);
            //Console.WriteLine(cubenumber);
            //Console.ReadLine();

            
            
            //static int cube(int num)
            //{
            //    int result = num * num * num;
            //    return result;
            
            bool isMale = true;
            bool isTall = false;

            if (isMale && isTall) // || or &&
            {
                Console.WriteLine("You are male");
            } else if (isMale && !isTall)
            {
                Console.WriteLine("Male but short");
            }

            else
            {
                Console.WriteLine("Gay!");
            }

            Console.ReadLine();
        }
    }
}