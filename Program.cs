using Factory1;
using MetodStart;
using Factory2;
using list1;
using System;
using Vivod;
using TypeHelicopters;
using TypeMilitaryHelicopters;
using TypePassengerAircraft;
using TypeMilitaryAircrafts;

namespace DZZ3
{
    class Program
    {
        static void Main(string[] args)
        {

            Creator[] creators = new Creator[1];
            creators[0] = new AircraftCreator();


            IMetod g = new Ms();

            foreach (Creator i in creators)

            {

                g.Add(i.FactoryMethod("Airbus", 200, 10000, 13500, 2000, PassengerOfAircraft.PassengerAircraft));
                g.Add(i.FactoryMethod("Boing 1", 210, 11000, 12500, 2900, PassengerOfAircraft.PassengerAircraft));

                g.Add(i.FactoryMethod("AgustaWestland AW609", 30, 20000, 18000, 3500, CargoOfAircraft.CargoAircraft));

                g.Add(i.FactoryMethod("Су-57", 2, 4000, 20000, 2500, TypeOfMilitaryAircraft.Bombers));


                g.Add(i.FactoryMethod("Белл AH-1 «Кобра»", 14, 2000, 9000, 1400, TypeOfMilitaryHelicopter.Fighters));

                g.Add(i.FactoryMethod("Robinson R44", 8, 1000, 6500, 900, PassengerOfHelicopter.PassengerHelicopters));
            }

            g.sorting();
            g.ShowItems();

            Console.WriteLine();
            foreach (var Items in g.FuelConsumption(5000))//Смена диапазона топлива 
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Brand: {Items.Name} | Type of: {Items.Type} | Fuel consumption: {Items.Fuel}");
                Console.ForegroundColor = ConsoleColor.White;

            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"The maximum volume of the fuel tank at the airport: {g.MaximumFuelSupply()}");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total capacity: {g.AircraftCapacity()}\nTotal lifting capacity: {g.AircraftLiftingCapacity()}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}