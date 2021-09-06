using TypePassengerAircraft;


namespace TypeMilitaryAircrafts
{
    public enum TypeOfMilitaryAircraft { Fighters, Bombers, Scouts }//Типы военных самолётов
    public class TypeMilitaryAircraft : MilitaryAircraft
    {
        public new TypeOfMilitaryAircraft mili;
        public TypeMilitaryAircraft(string TypeMilitaryAircraftName, int TypeMilitaryAircraftCapacity, int TypeMilitaryAircraftLiftingCapacity, int TypeMilitaryAircraftRangeOfFlight, int TypeMilitaryAircraftParamsFuel, TypeOfMilitaryAircraft mili)
            : base(TypeMilitaryAircraftName, TypeMilitaryAircraftCapacity, TypeMilitaryAircraftLiftingCapacity, TypeMilitaryAircraftRangeOfFlight, TypeMilitaryAircraftParamsFuel, mili)
        {
            this.mili = mili;
        }
    }

}