using list1;
using System;

namespace Vivod
{
    public static class Exetensions
    {
        public static void ShowItems(this IMetod y)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                             _____________***AIRPORT***_____________\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                             <<<<Aircraft located at the airport>>>> ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var i in y.Items)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Brand: {0} |Capacity: {1} |Carrying capacity: {2} |Range of flight: {3} |Fuel: {4} |{5}",
                    i.Name, i.Capacity, i.LiftingCapacity, i.RangeOfFlight, i.Fuel, i.Type);
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
    }
}
