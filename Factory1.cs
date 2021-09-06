using ParamsA;
using TypeHelicopters;
using TypeMilitaryAircrafts;
using TypeMilitaryHelicopters;
using TypePassengerAircraft;

namespace Factory1
{
    public abstract class Creator
    {
        public abstract Params FactoryMethod(string Aircraftname, int Aircraftcapacity, int AircraftLiftingCapasity, int AircraftRangeOfFlight, int AircraftParamsfuel, PassengerOfAircraft x);//Пассажирские самолёты 
        public abstract Params FactoryMethod(string Aircraftname, int Aircraftcapacity, int AircraftLiftingCapasity, int AircraftRangeOfFlight, int AircraftParamsfuel, MilitaryOfAircraft x);//Военные самолёты
        public abstract Params FactoryMethod(string Aircraftname, int Aircraftcapacity, int AircraftLiftingCapasity, int AircraftRangeOfFlight, int AircraftParamsfuel, CargoOfAircraft x);//Грузовые самолёты
        public abstract Params FactoryMethod(string Aircraftname, int Aircraftcapacity, int AircraftLiftingCapasity, int AircraftRangeOfFlight, int AircraftParamsfuel, TypeOfMilitaryAircraft x);//Типы военных самолётов
        public abstract Params FactoryMethod(string Aircraftname, int Aircraftcapacity, int AircraftLiftingCapasity, int AircraftRangeOfFlight, int AircraftParamsfuel, PassengerOfHelicopter x);//Пассажирские вертолёты
        public abstract Params FactoryMethod(string Aircraftname, int Aircraftcapacity, int AircraftLiftingCapasity, int AircraftRangeOfFlight, int AircraftParamsfuel, MilitaryOfHelicopter x);//Военные вертолёты
        public abstract Params FactoryMethod(string Aircraftname, int Aircraftcapacity, int AircraftLiftingCapasity, int AircraftRangeOfFlight, int AircraftParamsfuel, MedicalOfHelicopter x);//Медецинские вертолёты
        public abstract Params FactoryMethod(string Aircraftname, int Aircraftcapacity, int AircraftLiftingCapasity, int AircraftRangeOfFlight, int AircraftParamsfuel, TypeOfMilitaryHelicopter x);//Типы военных вертолётов 

    }
}