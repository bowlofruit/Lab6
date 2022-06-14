using Lab2dll;
using System;

namespace Lab2
{
    class Program
    {
        static int Number()
        {
            if (uint.TryParse(Console.ReadLine(), out uint number) == false)
            {
                Console.Write("Error: value can't be negative\nTry again: ");
                return Number();
            }
            return (int)number;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of excursion: ");

            int number = Number();
            Tour tour = new Tour(RndGenerator.RndCost(), RndGenerator.RndDay(), RndGenerator.RndListExcurs(number));
            Console.WriteLine("\nBEFORE\n");
            tour.Excursions.Sort();
            Console.WriteLine(tour);

            Serializator<Tour> serializator = new Serializator<Tour>("path.txt");
            serializator.Serialize(tour);


            Console.WriteLine("AFTER\n");
            Console.WriteLine(serializator.Deserialize());

            Console.ReadKey();
        }
    }
}
