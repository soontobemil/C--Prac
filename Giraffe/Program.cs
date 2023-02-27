using System;
using Giraffe;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter","Jay SIm", 5000049, "dog");
            Book book2 = new Book("Harry Potter2", "Jay SIM", 5000050, "Good");
            Console.WriteLine(book1.HasHonors());
            Console.WriteLine(book1.Rating);
            Console.WriteLine(book2.Rating);
            Console.WriteLine(book1.title);
            Console.ReadLine();
        }
    }
}
