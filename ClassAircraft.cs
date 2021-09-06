using ParamsA;

namespace TypePassengerAircraft
{
    public enum PassengerOfAircraft { PassengerAircraft } //Пассажирские самолёты 
    public class PassengerAircraft : Params
    {
        public PassengerOfAircraft pass;
        public PassengerAircraft(string PassengerAircraftName, int PassengerAircraftCapacity, int PassengerAircraftLiftingCapacity, int PassengerAircraftRangeOfFlight, int PassengerAircraftParamsFuel, PassengerOfAircraft pass)

            : base(PassengerAircraftName, PassengerAircraftCapacity, PassengerAircraftLiftingCapacity, PassengerAircraftRangeOfFlight, PassengerAircraftParamsFuel, pass)
        {
            this.pass = pass;
        }
    }

    public enum MilitaryOfAircraft { MilitaryAircraft } //Военные самолёты
    public class MilitaryAircraft : Params
    {

        public MilitaryAircraft(string Paramsname, int Paramscapacity, int ParamsLiftingCapacity, int ParamsRangeOfFlight, int Paramsfuel, object Paramstype)//наследует
            : base(Paramsname, Paramscapacity, ParamsLiftingCapacity, ParamsRangeOfFlight, Paramsfuel, Paramstype)
        {
        }
        public MilitaryOfAircraft mili;
        public MilitaryAircraft(string MilitaryAircraftName, int MilitaryAircraftCapacity, int MilitaryAircraftLiftingCapacity, int MilitaryAircraftRangeOfFlight, int MilitaryAircraftParamsFuel, MilitaryOfAircraft mili)
            : base(MilitaryAircraftName, MilitaryAircraftCapacity, MilitaryAircraftLiftingCapacity, MilitaryAircraftRangeOfFlight, MilitaryAircraftParamsFuel, mili)
        {
            this.mili = mili;
        }
    }


    public enum CargoOfAircraft { CargoAircraft }//Грузовые самолёты
    public class CargoAircraft : Params
    {
        public CargoOfAircraft car;
        public CargoAircraft(string CargoAircraftName, int CargoAircraftCapacity, int CargoAircraftLiftingCapacity, int CargoAircraftRangeOfFlight, int CargoAircraftParamsFuel, CargoOfAircraft car)
            : base(CargoAircraftName, CargoAircraftCapacity, CargoAircraftLiftingCapacity, CargoAircraftRangeOfFlight, CargoAircraftParamsFuel, car)
        {
            this.car = car;
        }

    }


}





