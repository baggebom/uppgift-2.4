using System;

namespace uppgift
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Skriv in första lönen på den anställda");
            double anställd1= double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Clear();

            Console.WriteLine("Skirv in andra lönen på den anställda?");
            double anställd2 =double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Skriv in tredje lönen på den anställda");
            double anställd3 = double.Parse(Console.ReadLine());

            double medelvärde = (anställd1 + anställd2 + anställd3) / 3;

            Console.WriteLine("Medelvärdet är " + medelvärde);

            Console.ReadKey();
        }
    }
}
