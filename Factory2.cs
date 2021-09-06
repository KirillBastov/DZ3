using Factory1;
using ParamsA;
using TypeHelicopters;
using TypeMilitaryAircrafts;
using TypeMilitaryHelicopters;
using TypePassengerAircraft;

namespace Factory2
{
    public class AircraftCreator : Creator
    {
        public override Params FactoryMethod(string Aircraftname, int Aircraftcapacity, int AircraftLiftingCapasity, int AircraftRangeOfFlight, int AircraftParamsfuel, PassengerOfAircraft x)//Пассажирские самолёты 
        {

            return new PassengerAircraft(Aircraftname, Aircraftcapacity, AircraftLiftingCapasity, AircraftRangeOfFlight, AircraftParamsfuel, x);
        }
        public override Params FactoryMethod(string Aircraftname, int Aircraftcapacity, int AircraftLiftingCapasity, int AircraftRangeOfFlight, int AircraftParamsfuel, MilitaryOfAircraft x)//Военные самолёты
        {
            return new MilitaryAircraft(Aircraftname, Aircraftcapacity, AircraftLiftingCapasity, AircraftRangeOfFlight, AircraftParamsfuel, x);
        }
        public override Params FactoryMethod(string Aircraftname, int Aircraftcapacity, int AircraftLiftingCapasity, int AircraftRangeOfFlight, int AircraftParamsfuel, CargoOfAircraft x)//Грузовые самолёты
        {
            return new CargoAircraft(Aircraftname, Aircraftcapacity, AircraftLiftingCapasity, AircraftRangeOfFlight, AircraftParamsfuel, x);
        }
        public override Params FactoryMethod(string Aircraftname, int Aircraftcapacity, int AircraftLiftingCapasity, int AircraftRangeOfFlight, int AircraftParamsfuel, TypeOfMilitaryAircraft x)//Типы военных самолётов
        {
            return new TypeMilitaryAircraft(Aircraftname, Aircraftcapacity, AircraftLiftingCapasity, AircraftRangeOfFlight, AircraftParamsfuel, x);
        }
        public override Params FactoryMethod(string Aircraftname, int Aircraftcapacity, int AircraftLiftingCapasity, int AircraftRangeOfFlight, int AircraftParamsfuel, PassengerOfHelicopter x)//Пассажирские вертолёты
        {
            return new PassengerHelicopter(Aircraftname, Aircraftcapacity, AircraftLiftingCapasity, AircraftRangeOfFlight, AircraftParamsfuel, x);
        }
        public override Params FactoryMethod(string Aircraftname, int Aircraftcapacity, int AircraftLiftingCapasity, int AircraftRangeOfFlight, int AircraftParamsfuel, MilitaryOfHelicopter x)//Военные вертолёты
        {
            return new MilitaryHelicopter(Aircraftname, Aircraftcapacity, AircraftLiftingCapasity, AircraftRangeOfFlight, AircraftParamsfuel, x);
        }
        public override Params FactoryMethod(string Aircraftname, int Aircraftcapacity, int AircraftLiftingCapasity, int AircraftRangeOfFlight, int AircraftParamsfuel, MedicalOfHelicopter x)//Медецинские вертолёты
        {
            return new MedicalHelicopter(Aircraftname, Aircraftcapacity, AircraftLiftingCapasity, AircraftRangeOfFlight, AircraftParamsfuel, x);
        }
        public override Params FactoryMethod(string Aircraftname, int Aircraftcapacity, int AircraftLiftingCapasity, int AircraftRangeOfFlight, int AircraftParamsfuel, TypeOfMilitaryHelicopter x)//Типы военных вертолётов 
        {
            return new TypeMilitaryHelicopter(Aircraftname, Aircraftcapacity, AircraftLiftingCapasity, AircraftRangeOfFlight, AircraftParamsfuel, x);
        }
    }
}